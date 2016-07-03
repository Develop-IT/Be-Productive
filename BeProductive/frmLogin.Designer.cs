namespace BeProductive
{
    partial class frmLogin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.linkRegister = new MetroFramework.Controls.MetroLink();
            this.btnLoginButton = new MetroFramework.Controls.MetroButton();
            this.txtUser = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.txtPassword = new MetroFramework.Controls.MetroTextBox();
            this.lblEmail = new MetroFramework.Controls.MetroLabel();
            this.txtEmail = new MetroFramework.Controls.MetroTextBox();
            this.txtName = new MetroFramework.Controls.MetroTextBox();
            this.lblName = new MetroFramework.Controls.MetroLabel();
            this.rbtnPersonal = new MetroFramework.Controls.MetroRadioButton();
            this.rbtnBusiness = new MetroFramework.Controls.MetroRadioButton();
            this.gboxMode = new System.Windows.Forms.GroupBox();
            this.gboxMode.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel1.Location = new System.Drawing.Point(338, 25);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(231, 25);
            this.metroLabel1.TabIndex = 16;
            this.metroLabel1.Text = "Bienvenido a ¡BeProductive!";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel2.Location = new System.Drawing.Point(23, 79);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(505, 19);
            this.metroLabel2.TabIndex = 15;
            this.metroLabel2.Text = "Con el fin de obtener tus estadisticas es necesario que incies sesión o te regist" +
    "res.";
            // 
            // linkRegister
            // 
            this.linkRegister.Location = new System.Drawing.Point(463, 281);
            this.linkRegister.Name = "linkRegister";
            this.linkRegister.Size = new System.Drawing.Size(106, 23);
            this.linkRegister.TabIndex = 5;
            this.linkRegister.Text = "Registrar";
            this.linkRegister.UseSelectable = true;
            this.linkRegister.Click += new System.EventHandler(this.linkRegister_Click);
            // 
            // btnLoginButton
            // 
            this.btnLoginButton.Location = new System.Drawing.Point(221, 268);
            this.btnLoginButton.Name = "btnLoginButton";
            this.btnLoginButton.Size = new System.Drawing.Size(157, 45);
            this.btnLoginButton.TabIndex = 4;
            this.btnLoginButton.Text = "Iniciar Sesión";
            this.btnLoginButton.UseSelectable = true;
            this.btnLoginButton.Click += new System.EventHandler(this.btnLoginButton_Click);
            // 
            // txtUser
            // 
            // 
            // 
            // 
            this.txtUser.CustomButton.Image = null;
            this.txtUser.CustomButton.Location = new System.Drawing.Point(230, 1);
            this.txtUser.CustomButton.Name = "";
            this.txtUser.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtUser.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtUser.CustomButton.TabIndex = 1;
            this.txtUser.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtUser.CustomButton.UseSelectable = true;
            this.txtUser.CustomButton.Visible = false;
            this.txtUser.Lines = new string[0];
            this.txtUser.Location = new System.Drawing.Point(221, 107);
            this.txtUser.MaxLength = 32767;
            this.txtUser.Name = "txtUser";
            this.txtUser.PasswordChar = '\0';
            this.txtUser.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtUser.SelectedText = "";
            this.txtUser.SelectionLength = 0;
            this.txtUser.SelectionStart = 0;
            this.txtUser.Size = new System.Drawing.Size(252, 23);
            this.txtUser.TabIndex = 0;
            this.txtUser.UseSelectable = true;
            this.txtUser.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtUser.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel3.Location = new System.Drawing.Point(136, 107);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(56, 19);
            this.metroLabel3.TabIndex = 5;
            this.metroLabel3.Text = "Usuario";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel4.Location = new System.Drawing.Point(136, 145);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(79, 19);
            this.metroLabel4.TabIndex = 7;
            this.metroLabel4.Text = "Contraseña";
            // 
            // txtPassword
            // 
            // 
            // 
            // 
            this.txtPassword.CustomButton.Image = null;
            this.txtPassword.CustomButton.Location = new System.Drawing.Point(230, 1);
            this.txtPassword.CustomButton.Name = "";
            this.txtPassword.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtPassword.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtPassword.CustomButton.TabIndex = 1;
            this.txtPassword.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtPassword.CustomButton.UseSelectable = true;
            this.txtPassword.CustomButton.Visible = false;
            this.txtPassword.Lines = new string[0];
            this.txtPassword.Location = new System.Drawing.Point(221, 145);
            this.txtPassword.MaxLength = 32767;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPassword.SelectedText = "";
            this.txtPassword.SelectionLength = 0;
            this.txtPassword.SelectionStart = 0;
            this.txtPassword.Size = new System.Drawing.Size(252, 23);
            this.txtPassword.TabIndex = 1;
            this.txtPassword.UseSelectable = true;
            this.txtPassword.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtPassword.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lblEmail.Location = new System.Drawing.Point(136, 233);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(41, 19);
            this.lblEmail.TabIndex = 8;
            this.lblEmail.Text = "Email";
            this.lblEmail.Visible = false;
            // 
            // txtEmail
            // 
            // 
            // 
            // 
            this.txtEmail.CustomButton.Image = null;
            this.txtEmail.CustomButton.Location = new System.Drawing.Point(230, 1);
            this.txtEmail.CustomButton.Name = "";
            this.txtEmail.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtEmail.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtEmail.CustomButton.TabIndex = 1;
            this.txtEmail.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtEmail.CustomButton.UseSelectable = true;
            this.txtEmail.CustomButton.Visible = false;
            this.txtEmail.Lines = new string[0];
            this.txtEmail.Location = new System.Drawing.Point(221, 233);
            this.txtEmail.MaxLength = 32767;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.PasswordChar = '\0';
            this.txtEmail.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtEmail.SelectedText = "";
            this.txtEmail.SelectionLength = 0;
            this.txtEmail.SelectionStart = 0;
            this.txtEmail.Size = new System.Drawing.Size(252, 23);
            this.txtEmail.TabIndex = 3;
            this.txtEmail.UseSelectable = true;
            this.txtEmail.Visible = false;
            this.txtEmail.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtEmail.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtName
            // 
            // 
            // 
            // 
            this.txtName.CustomButton.Image = null;
            this.txtName.CustomButton.Location = new System.Drawing.Point(230, 1);
            this.txtName.CustomButton.Name = "";
            this.txtName.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtName.CustomButton.TabIndex = 1;
            this.txtName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtName.CustomButton.UseSelectable = true;
            this.txtName.CustomButton.Visible = false;
            this.txtName.Lines = new string[0];
            this.txtName.Location = new System.Drawing.Point(221, 190);
            this.txtName.MaxLength = 32767;
            this.txtName.Name = "txtName";
            this.txtName.PasswordChar = '\0';
            this.txtName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtName.SelectedText = "";
            this.txtName.SelectionLength = 0;
            this.txtName.SelectionStart = 0;
            this.txtName.Size = new System.Drawing.Size(252, 23);
            this.txtName.TabIndex = 2;
            this.txtName.UseSelectable = true;
            this.txtName.Visible = false;
            this.txtName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lblName.Location = new System.Drawing.Point(136, 190);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(59, 19);
            this.lblName.TabIndex = 10;
            this.lblName.Text = "Nombre";
            this.lblName.Visible = false;
            // 
            // rbtnPersonal
            // 
            this.rbtnPersonal.AutoSize = true;
            this.rbtnPersonal.Checked = true;
            this.rbtnPersonal.Location = new System.Drawing.Point(14, 22);
            this.rbtnPersonal.Name = "rbtnPersonal";
            this.rbtnPersonal.Size = new System.Drawing.Size(91, 15);
            this.rbtnPersonal.TabIndex = 11;
            this.rbtnPersonal.TabStop = true;
            this.rbtnPersonal.Text = "Uso personal";
            this.rbtnPersonal.UseSelectable = true;
            // 
            // rbtnBusiness
            // 
            this.rbtnBusiness.AutoSize = true;
            this.rbtnBusiness.Location = new System.Drawing.Point(13, 45);
            this.rbtnBusiness.Name = "rbtnBusiness";
            this.rbtnBusiness.Size = new System.Drawing.Size(107, 15);
            this.rbtnBusiness.TabIndex = 12;
            this.rbtnBusiness.Text = "Uso empresarial";
            this.rbtnBusiness.UseSelectable = true;
            // 
            // gboxMode
            // 
            this.gboxMode.Controls.Add(this.rbtnPersonal);
            this.gboxMode.Controls.Add(this.rbtnBusiness);
            this.gboxMode.Location = new System.Drawing.Point(8, 233);
            this.gboxMode.Name = "gboxMode";
            this.gboxMode.Size = new System.Drawing.Size(122, 78);
            this.gboxMode.TabIndex = 17;
            this.gboxMode.TabStop = false;
            this.gboxMode.Text = "Modo";
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(592, 327);
            this.Controls.Add(this.gboxMode);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.txtUser);
            this.Controls.Add(this.btnLoginButton);
            this.Controls.Add(this.linkRegister);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmLogin";
            this.Text = "Inicio de Sesión";
            this.gboxMode.ResumeLayout(false);
            this.gboxMode.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLink linkRegister;
        private MetroFramework.Controls.MetroButton btnLoginButton;
        private MetroFramework.Controls.MetroTextBox txtUser;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroTextBox txtPassword;
        private MetroFramework.Controls.MetroLabel lblEmail;
        private MetroFramework.Controls.MetroTextBox txtEmail;
        private MetroFramework.Controls.MetroTextBox txtName;
        private MetroFramework.Controls.MetroLabel lblName;
        private MetroFramework.Controls.MetroRadioButton rbtnPersonal;
        private MetroFramework.Controls.MetroRadioButton rbtnBusiness;
        private System.Windows.Forms.GroupBox gboxMode;
    }
}