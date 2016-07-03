using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using MetroFramework.Forms;
using System.Net;
using MetroFramework;
using System.IO;
using Newtonsoft.Json;
using System.Security.Cryptography;
using System.Net.Http;

namespace BeProductive
{
    public partial class frmLogin : MetroForm
    {
        public static string mainPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.System), "drivers\\etc\\");
        public frmLogin()
        {
            InitializeComponent();
        }
        
        private void linkRegister_Click(object sender, EventArgs e)
        {
            if (linkRegister.Text== "Registrar")
            {
                isLogin(false);
                
            }
            else
            {
                isLogin(true);
                
            }
            
        }
        public void isLogin(bool isLogin)
        {
            txtEmail.Visible = !isLogin;
            lblEmail.Visible = !isLogin;
            txtName.Visible = !isLogin;
            lblName.Visible = !isLogin;
            gboxMode.Visible = isLogin;

            if (isLogin)
            {
                btnLoginButton.Text = "Iniciar Sesión";
                linkRegister.Text = "Registrar";
            }
            else
            {
                btnLoginButton.Text = "Registrar";
                linkRegister.Text = "Iniciar Sesión";
            }
        }

        private void btnLoginButton_Click(object sender, EventArgs e)
        {
            if (btnLoginButton.Text=="Iniciar Sesión")
            {
                if (sendPOST("username=" + txtUser.Text + "", "http://www.beproductive.xyz:8080/api/get_user", 1))
                {
                    
                    frmIsLogged frmLogged = new frmIsLogged();
                    frmLogged.Show();
                    this.Hide();
                }
                else
                {
                    MetroMessageBox.Show(this,"Error, Verifica tu informacion de acceso","Acceso incorrecto!",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
            }
            else //Registro
            {
                if (sendPOST("email=" + txtEmail.Text + "&password=" + txtPassword.Text + "&username=" + txtUser.Text + "&name=" + txtName.Text + "", "http://www.beproductive.xyz:8080/api/users", 0))
                {
                    MetroMessageBox.Show(this, "Correcto , Usuario registrado con exito!", "Registro Exitoso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    isLogin(true);
                }
                else
                {
                    MetroMessageBox.Show(this, "Error, El usuario ya esta registrado", "Registro incorrecto!", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
               

            }
        }

        public void createConfigFile(uint user_id,string username,string name,string email,uint mode)
        {
            StreamWriter objWriter = new StreamWriter(Path.Combine(mainPath, "configuration.beproductive"),true);
            objWriter.WriteLine(user_id);
            objWriter.WriteLine(name);
            objWriter.WriteLine(email);
            objWriter.WriteLine(mode);
            objWriter.Close();
        }

        
        public bool sendPOST(string postData, string url,int actionType) //actiontype 0=Registro , 1=Login
        {
            HttpWebRequest request = (HttpWebRequest)
            WebRequest.Create(url); request.KeepAlive = false;
            request.ProtocolVersion = HttpVersion.Version10;
            request.Method = "POST";
            byte[] postBytes = Encoding.ASCII.GetBytes(postData);
            request.ContentType = "application/x-www-form-urlencoded";
            request.ContentLength = postBytes.Length;
            Stream requestStream = request.GetRequestStream();
            requestStream.Write(postBytes, 0, postBytes.Length);
            requestStream.Close();
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            string respuesta = new StreamReader(response.GetResponseStream()).ReadToEnd();
            if (actionType==0)
            {
                return verifyRegister(deserializeJSON(respuesta));
            }
            else if (actionType==1)
            {
                return verifyLogin(deserializeJSON(respuesta));
            }
            else
            {
                return false;
            }
        }
        public bool verifyRegister(getUserList registerErrors)
        {
            if (registerErrors.Error=="True")
            {
                return false;
            }
            else if (registerErrors.Error == "False")
            {
                return true;
            }
            
            return false;
        }
        public bool verifyLogin(getUserList usersList)
        {
            
            foreach (var item in usersList.Users)
            {
                //MessageBox.Show(item.user_id + " " + item.user_name + " " + item.user_password);
                if (item.user_password == MD5Hash(txtPassword.Text))
                {
                    uint mode = 0;
                    if (rbtnPersonal.Checked && !rbtnBusiness.Checked)
                    {
                        mode = 0;
                    }
                    else if (!rbtnPersonal.Checked && rbtnBusiness.Checked)
                    {
                        mode = 1;
                    }
                    createConfigFile(item.user_id,item.user_username,item.user_name,item.user_email,mode);
                    return true;
                }
                else
                {
                    return false;
                }
            }
            return false;
        }
        public getUserList deserializeJSON(string json)
        {
            
            getUserList account = JsonConvert.DeserializeObject<getUserList>(json);
            return account;
        }
        public class getUserList
        {

            public List<getUsers> Users { get; set; }

            public string Error { get; set; }
        }

        public class getUsers
        {
            public uint user_id { get; set; }
            public string user_email { get; set; }
            public string user_name { get; set; }
            public string user_password { get; set; }
            public string user_join_date { get; set; }
            public string user_username { get; set; }

        }
        public static string MD5Hash(string text)
        {
            MD5 md5 = new MD5CryptoServiceProvider();

            //compute hash from the bytes of text
            md5.ComputeHash(ASCIIEncoding.ASCII.GetBytes(text));

            //get hash result after compute it
            byte[] result = md5.Hash;

            StringBuilder strBuilder = new StringBuilder();
            for (int i = 0; i < result.Length; i++)
            {
                //change it into 2 hexadecimal digits
                //for each byte
                strBuilder.Append(result[i].ToString("x2"));
            }

            return strBuilder.ToString();
        }
    }
}
