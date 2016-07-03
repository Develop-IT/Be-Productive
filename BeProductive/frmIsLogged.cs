using System;
using System.IO;
using System.Text;
using System.Windows.Forms;
using MetroFramework.Forms;
using System.Net;
using MetroFramework;
using System.Globalization;
using System.Collections.Generic;
using Newtonsoft.Json;
using System.Diagnostics;

namespace BeProductive
{
    public partial class frmIsLogged : MetroForm
    {
        public DateTime startTime;
        public string[] userInformation = new string[6]; // ID,NAME,EMAIL,PersonalORBusiness,DateExtremeMode,UserHours
        public DateTime finishTime;
        public string blockedList;
        public string userTotalHours;
        public string[] appNames = { "winword", "EXCEL" , "POWERPNT", "sublime_text","atom", "devenv" };
        public int[] appIds = {1,11,21,22,23,24 };//Word,Excel.Pp,Sublimetext,Atom,Visual studio
        public double[] appTimes = new double[6];


        int userLevel;
        public string mainPath= Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.System), "drivers\\etc\\");
        public frmIsLogged()
        {
            InitializeComponent();
            ntiBeProductive.Visible = true;
            ntiBeProductive.ContextMenuStrip=cmsIcon;
            cmbLevel.SelectedIndex = 0;
            loadUserInfo();
            sendToIcon("Bienvenido a BeProductive " + userInformation[1].ToString().Split(' ')[0],"Bienvenido!",1000);
            
        }
        public void sendToIcon(string Message,string Title,int Time)
        {
            
            ntiBeProductive.BalloonTipText = Message;
            ntiBeProductive.BalloonTipTitle = Title;
            ntiBeProductive.ShowBalloonTip(Time);
        }
        

       
        private void frmIsLogged_Load(object sender, EventArgs e)
        {
            
            if (isFirstTime())
            {
                File.Copy(Path.Combine(mainPath, "hosts"), Path.Combine(mainPath, "firstExecution.beproductive"), true);
                MetroMessageBox.Show(this,"Bienvenido a BeProductive! , Detectamos que es la primera vez que ejecutas el programa asi que realizamos un respaldo de tu informacion para evitar cualquier accidente , ¡Se productivo!","¡Bienvenido!",MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            if (userInformation[3]=="0")
            {
                //EsPersonal
                checkPersonalExtremeMode();

            }
            else
            {
                //EsEmpresarial
                lblTime.Visible = false;
                mtbTime.Visible = false;
                lblShowTime.Visible = false;
                cmbLevel.Visible = false;
                metroLabel1.Visible = false;
            }
        }
        
        public void startProductiveTime(int userHours)
        {
            StreamWriter w = new StreamWriter(Path.Combine(mainPath, "hosts"),true);
            w.WriteLine();
            w.WriteLine(blockedList);
            w.Close();
            if (userInformation[3]=="0" && userLevel==1)//es personal
            {
                StreamReader objReader = new StreamReader(Path.Combine(mainPath, "configuration.beproductive"));
                string line = objReader.ReadLine();
                StringBuilder objBuilder = new StringBuilder();
                while (line!=null && line!="")
                {
                    if (line!=null && line!="")
                    {
                        objBuilder.AppendLine(line);
                        line = objReader.ReadLine();
                    }
                }
                objReader.Close();
                StreamWriter objWriter = new StreamWriter(Path.Combine(mainPath, "configuration.beproductive"),true);
                objBuilder.AppendLine(""+DateTime.Now.AddMinutes(userHours));
                objBuilder.AppendLine(userHours + "BeProductive");
                objWriter.WriteLine(objBuilder.ToString());
                objWriter.Close();
                userInformation[5] = userHours.ToString();
            }
            
        }
        public void registerProductiveTime(DateTime finishDate,int weekOfTheYear)
        {
            if (userLevel==1)
            {
                userTotalHours = userTotalHours + ":00:00";
            }
            sendPOST("date=" + finishDate.ToString("yyyyy-MM-dd") + "&time_data=" + userTotalHours + "&userId=" + userInformation[0] + "&week="+weekOfTheYear+"", "http://www.beproductive.xyz:8080/api/productive_time_data", 0);

        }
        public void checkPersonalExtremeMode()
        {
            string finalDate = userInformation[4];
            string totalHours = userInformation[5];
            
            if (finalDate != null && totalHours!=null)
            {
                DateTime objFinishTime = DateTime.Parse(userInformation[4]);
                DateTime objNowTime = DateTime.Now;
                userTotalHours = totalHours.Replace("BeProductive", "");
                if (objFinishTime< objNowTime) //ya termino
                {
                    //Ya termino.
                    deleteFinishDate();
                    enableControls(true);
                    finishProductiveTime();
                  
                }
                else //No a terminado
                {
                    enableControls(false);
                    toggleStart.CheckState = CheckState.Checked;
                    toggleStart.Enabled = false;
                    userLevel = 1;
                    TimeSpan objTimeSpan =objFinishTime-DateTime.Now;
                    
                    //deleteFinishDate();
                    tmrProductive.Interval = (int)(objTimeSpan.TotalMilliseconds);
                    tmrProductive.Start();
                   
                }
                userInformation[4] = null;
                userInformation[5] = null;
                //MessageBox.Show("La fecha de finalizacion es: "+objFinishTime.ToString());
            }
        }
        #region fileManage
        public void loadUserInfo()
        {
            try
            {
                StreamReader objReader = new StreamReader(Path.Combine(mainPath, "configuration.beproductive"));
                string line = objReader.ReadLine();
                int slot = 0;
                while (line != null && line != "")
                {
                    if (line != null && line!="")
                    {
                        userInformation[slot] = line;
                        line = objReader.ReadLine();
                        slot++;
                    }

                }
                objReader.Close();
            }
            catch (Exception op)
            {

                MetroMessageBox.Show(this, "Hubo un error durante la carga de la aplicacion , se cerrara automaticamente." + op.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }

        }
        public void backupFile()
        {
            File.Copy(Path.Combine(mainPath, "hosts"), Path.Combine(mainPath, "BeProductive.beproductive"), true);
        }
        public void readBlockedList()
        {
            var webClient = new WebClient();
            blockedList = webClient.DownloadString("http://beproductive.azurewebsites.net/beproductive.txt");
        }
        public bool isFirstTime()
        {
            if (File.Exists(Path.Combine(mainPath, "firstExecution.beproductive")))
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        #endregion

        #region mainEvents
        private void toggleStart_CheckedChanged(object sender, EventArgs e)
        {
            if (toggleStart.CheckState == CheckState.Checked)
            {
                if (userInformation[3] == "0")
                {
                    if (userInformation[4] == null)
                    {
                        int userHours = mtbTime.Value;
                        userLevel = cmbLevel.SelectedIndex;
                        if (userLevel == 1)
                        {
                            toggleStart.Enabled = false;
                        }

                        tmrProductive.Enabled = false;
                        tmrProductive.Enabled = true;
                        tmrSoftware.Enabled = false;
                        tmrSoftware.Enabled = true;
                        tmrProductive.Stop();
                        tmrSoftware.Stop();
                        if (userLevel==0)
                        {
                            tmrSoftware.Start();
                        }
                        tmrProductive.Interval = (int)TimeSpan.FromMinutes(userHours).TotalMilliseconds;
                        tmrProductive.Start();
                        backupFile();
                        readBlockedList();
                        startProductiveTime(userHours);
                        enableControls(false);
                        startTime = DateTime.Now;
                        sendToIcon("Inicio tu tiempo productivo en modo  " + cmbLevel.Items[userLevel].ToString(), "¡Se productivo!", 1000);
                        this.Hide();
                    }
                }
                else
                {

                    toggleStart.Enabled = false;
                    backupFile();
                    readBlockedList();
                    startProductiveTime(0);
                    enableControls(false);
                    this.Hide();
                }
            }
            else
            {
                finishProductiveTime();
            }

        }
        public void finishBusinessTime()
        {
            File.Copy(Path.Combine(mainPath, "BeProductive.beproductive"), Path.Combine(mainPath, "hosts"), true);
            File.Delete(Path.Combine(mainPath, "BeProductive.beproductive"));
            enableControls(true);
        }
        public void finishProductiveTime()
        {
            
            try {
                int weekOfTheYear=0;
                if (userLevel == 1)
                {
                    toggleStart.Enabled = true;
                }
               
                File.Copy(Path.Combine(mainPath, "BeProductive.beproductive"), Path.Combine(mainPath, "hosts"), true);
                File.Delete(Path.Combine(mainPath, "BeProductive.beproductive"));
                enableControls(true);
                finishTime = DateTime.Now;
                DateTimeFormatInfo dfi = DateTimeFormatInfo.CurrentInfo;
                Calendar cal = dfi.Calendar;
                weekOfTheYear = cal.GetWeekOfYear(finishTime, dfi.CalendarWeekRule, dfi.FirstDayOfWeek);
                if (userLevel!=1)
                {
                    
                    

                    TimeSpan objTotalTime = new TimeSpan(finishTime.Ticks - startTime.Ticks);

                    TimeSpan duration = TimeSpan.FromMilliseconds(objTotalTime.TotalMilliseconds);

                    userTotalHours = duration.ToString("hh\\:mm\\:ss");
                    
                    sendToIcon("Felicidades! " + userInformation[1].ToString().Split(' ')[0] + " , hasta ahora lograste ser " + getProductiveTime(objTotalTime) + " mas productivo", "Finalizo tu periodo productivo", 1000);
                    int appCounter = 0;
                    foreach (var item in appNames)
                    {
                        
                        TimeSpan ts = TimeSpan.FromMilliseconds(appTimes[appCounter]);
                        if (ts.TotalHours>0.00000001)
                        {
                            sendPOST("captureDate=" + DateTime.Now.ToString("yyyyy-MM-dd") + "&appId=" + appIds[appCounter] + "&userId=" + userInformation[0] + "&week=" + weekOfTheYear + "&totalTime=" + ts.TotalHours + "", "http://www.beproductive.xyz:8080/api/app_data_user", 0);

                        }
                        appCounter++;
                    }

                }
                else
                {
                    if (userInformation[4]!=null)
                    {
                        deleteFinishDate();
                    }
                    sendToIcon("Felicidades! " + userInformation[1].ToString().Split(' ')[0] + " , hasta ahora lograste ser " + userTotalHours + " horas mas productivo", "Finalizo tu periodo productivo", 1000);

                }
                registerProductiveTime(finishTime, weekOfTheYear);
            }
            catch(Exception op)
            {
                MessageBox.Show("Error Manu "+op.Message);
            }
        }
        

        public void deleteFinishDate()
        {
            try {
                string[] lines = File.ReadAllLines(Path.Combine(mainPath, "configuration.beproductive"));
                int lineNum = 0;
                //MessageBox.Show(userTotalHours);
                while (lineNum < lines.Length)
                {
                    lines[lineNum]= lines[lineNum].Replace(userInformation[4].ToString(), null);
                   
                    lines[lineNum] = lines[lineNum].Replace(userTotalHours+ "BeProductive", null);
                    lineNum++;
                }
                StreamWriter objWriter = new StreamWriter(Path.Combine(mainPath, "configuration.beproductive"));
                StringBuilder objBuilder = new StringBuilder();

                foreach (var line in lines)
                {
                    objBuilder.AppendLine(line);
                }
                objWriter.WriteLine(objBuilder.ToString());
                objBuilder.Clear();
                objWriter.Close();
                
            }catch(Exception op)
            {
                MessageBox.Show("Error papu "+op.Message);
            }
        }
        public string getProductiveTime(TimeSpan objTotalTime)
        {

            return string.Format("{0:D2} horas , {1:D2} minutos  y {2:D2} segundos",
                        objTotalTime.Hours,
                        objTotalTime.Minutes,
                        objTotalTime.Seconds);
        }
       

        private void frmIsLogged_FormClosed(object sender, FormClosedEventArgs e)
        {

            if (toggleStart.CheckState == CheckState.Checked && userLevel != 1)
            {
                finishProductiveTime();
            }
            Application.Exit();

        }
        public void enableControls(bool enable)
        {
            cmbLevel.Enabled = enable;
            mtbTime.Enabled = enable;
        }
        #endregion

        #region restore
        public void askForCredentials()
        {
            frmRestore testDialog = new frmRestore(uint.Parse(userInformation[0].ToString()));
            if (testDialog.ShowDialog(this) == DialogResult.OK)
            {
                restoreHosts();
            }
            else
            {
                MetroMessageBox.Show(this, "Las credenciales que introdujo no son correctas.", "Error en las credenciales.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            testDialog.Dispose();
        }
        public void restoreHosts()
        {
            File.Copy(Path.Combine(mainPath, "firstExecution.beproductive"), Path.Combine(mainPath, "hosts"), true);
            MetroMessageBox.Show(this,"La configuracion de la computadora fue restablecida.","Se restablecido la informacion.",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }
        #endregion

        #region request

        public bool sendPOST(string postData,string url,int postType)
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
            if (postType==0)
            {
                return true;
            }
            else if (postType==1)
            {
                return verifyHours(deserializeJSON(respuesta));
            }
            return false;
        }
        public void getStatistics()
        {
            
        }
        public bool verifyHours(getHoursList registerErrors)
        {
            if (registerErrors.Error == "True")
            {
                return false;
            }
            else if (registerErrors.Error == "False")
            {
                return true;
            }

            return false;
        }
        public getHoursList deserializeJSON(string json)
        {

            getHoursList hours = JsonConvert.DeserializeObject<getHoursList>(json);
            return hours;
        }
        public class getHoursList
        {
            public List<getHours> Weeks { get; set; }
            public string Error { get; set; }
        }
        public class getHours
        {
            public string lunes { get; set; }
            public string martes { get; set; }
            public string miercoles { get; set; }
            public string jueves { get; set; }
            public string viernes { get; set; }
            public string sabado { get; set; }
            public string domingo { get; set; }
        }
        #endregion

        #region controlEvents
        private void mtbTime_ValueChanged(object sender, EventArgs e)
        {
            lblShowTime.Text = mtbTime.Value + " horas";

        }
        private void tmrProductive_Tick(object sender, EventArgs e)
        {

            //finishProductiveTime();
            try
            {
                toggleStart.Enabled = true;
                toggleStart.CheckState = CheckState.Unchecked;
                
            }
            catch (Exception op)
            {

                MessageBox.Show("Error gg easy "+op.Message);
            }
            
        }
        private void btnRestore_Click(object sender, EventArgs e)
        {
            askForCredentials();
        }

        private void mostrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Show();
            this.BringToFront();
        }
        #endregion

        private void ntiBeProductive_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.Show();
            this.BringToFront();
        }

        private void cerrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void tmrSoftware_Tick(object sender, EventArgs e)
        {
            appChecker();
            tmrSoftware.Enabled = false;
            tmrSoftware.Enabled = true;
            tmrSoftware.Stop();
            tmrSoftware.Interval = 15000;
            tmrSoftware.Start();
        }
        public void appChecker()
        {
            int appCounter = 0;
            foreach (var appName in appNames)
            {
                Process[] appProcess = Process.GetProcessesByName(appName);
                if (appProcess.Length > 0)
                    appTimes[appCounter] += 15000;
                appCounter++;
            }
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            
            
            
        }
    }
}
