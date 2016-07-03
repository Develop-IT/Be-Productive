using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;
using System.Net;
using MetroFramework;
using System.IO;
using Newtonsoft.Json;
using System.Security.Cryptography;

namespace BeProductive
{
    public partial class frmRestore : MetroForm
    {
        public uint user_id;
        public frmRestore(uint user_id)
        {
            this.user_id = user_id;
            InitializeComponent();
        }

        private void frmRestore_Load(object sender, EventArgs e)
        {

        }

        private void btnRestore_Click(object sender, EventArgs e)
        {
            
            if (sendPOST("username=" + txtUsername.Text + "", "http://beproductiveapi.azurewebsites.net/api/get_user"))
            {

                btnRestore.DialogResult = DialogResult.OK;
            }
            else
            {
                btnRestore.DialogResult = DialogResult.No;
            }
        }

        public bool sendPOST(string postData, string url)
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
            return verifyLogin(deserializeJSON(respuesta));
            
        }

        public bool verifyLogin(getUserList usersList)
        {

            foreach (var item in usersList.Users)
            {
                if (item.user_password == MD5Hash(txtPassword.Text) && item.user_id== user_id)
                {
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
