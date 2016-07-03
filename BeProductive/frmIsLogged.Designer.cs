namespace BeProductive
{
    partial class frmIsLogged
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmIsLogged));
            this.tabMain = new MetroFramework.Controls.MetroTabControl();
            this.metroTabPage1 = new MetroFramework.Controls.MetroTabPage();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.cmbLevel = new MetroFramework.Controls.MetroComboBox();
            this.lblShowTime = new MetroFramework.Controls.MetroLabel();
            this.lblTime = new MetroFramework.Controls.MetroLabel();
            this.mtbTime = new MetroFramework.Controls.MetroTrackBar();
            this.toggleStart = new MetroFramework.Controls.MetroToggle();
            this.metroTabPage3 = new MetroFramework.Controls.MetroTabPage();
            this.btnRestore = new MetroFramework.Controls.MetroButton();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.mttLevel = new MetroFramework.Components.MetroToolTip();
            this.tmrProductive = new System.Windows.Forms.Timer(this.components);
            this.ntiBeProductive = new System.Windows.Forms.NotifyIcon(this.components);
            this.cmsIcon = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.mostrarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cerrarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.metroContextMenu1 = new MetroFramework.Controls.MetroContextMenu(this.components);
            this.tmrSoftware = new System.Windows.Forms.Timer(this.components);
            this.tabMain.SuspendLayout();
            this.metroTabPage1.SuspendLayout();
            this.metroTabPage3.SuspendLayout();
            this.cmsIcon.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabMain
            // 
            this.tabMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabMain.Controls.Add(this.metroTabPage1);
            this.tabMain.Controls.Add(this.metroTabPage3);
            this.tabMain.Location = new System.Drawing.Point(23, 63);
            this.tabMain.Name = "tabMain";
            this.tabMain.SelectedIndex = 0;
            this.tabMain.Size = new System.Drawing.Size(600, 295);
            this.tabMain.TabIndex = 0;
            this.tabMain.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.tabMain.UseSelectable = true;
            // 
            // metroTabPage1
            // 
            this.metroTabPage1.Controls.Add(this.metroLabel2);
            this.metroTabPage1.Controls.Add(this.metroLabel1);
            this.metroTabPage1.Controls.Add(this.cmbLevel);
            this.metroTabPage1.Controls.Add(this.lblShowTime);
            this.metroTabPage1.Controls.Add(this.lblTime);
            this.metroTabPage1.Controls.Add(this.mtbTime);
            this.metroTabPage1.Controls.Add(this.toggleStart);
            this.metroTabPage1.HorizontalScrollbarBarColor = true;
            this.metroTabPage1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.HorizontalScrollbarSize = 10;
            this.metroTabPage1.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage1.Name = "metroTabPage1";
            this.metroTabPage1.Size = new System.Drawing.Size(592, 253);
            this.metroTabPage1.TabIndex = 0;
            this.metroTabPage1.Text = "Principal";
            this.metroTabPage1.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroTabPage1.VerticalScrollbarBarColor = true;
            this.metroTabPage1.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.VerticalScrollbarSize = 10;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(3, 26);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(48, 19);
            this.metroLabel2.TabIndex = 8;
            this.metroLabel2.Text = "Estado";
            this.metroLabel2.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroLabel1
            // 
            this.metroLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(3, 199);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(38, 19);
            this.metroLabel1.TabIndex = 7;
            this.metroLabel1.Text = "Nivel";
            this.metroLabel1.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // cmbLevel
            // 
            this.cmbLevel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbLevel.FormattingEnabled = true;
            this.cmbLevel.ItemHeight = 23;
            this.cmbLevel.Items.AddRange(new object[] {
            "Normal - Terminara cuando se completen las horas o cuando el usuario lo desee.",
            "Extremo - Terminara cuando se completen las horas (No podras cancelarlo)."});
            this.cmbLevel.Location = new System.Drawing.Point(3, 221);
            this.cmbLevel.Name = "cmbLevel";
            this.cmbLevel.Size = new System.Drawing.Size(586, 29);
            this.cmbLevel.TabIndex = 6;
            this.cmbLevel.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.cmbLevel.UseSelectable = true;
            // 
            // lblShowTime
            // 
            this.lblShowTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblShowTime.AutoSize = true;
            this.lblShowTime.Location = new System.Drawing.Point(544, 77);
            this.lblShowTime.Name = "lblShowTime";
            this.lblShowTime.Size = new System.Drawing.Size(45, 19);
            this.lblShowTime.TabIndex = 5;
            this.lblShowTime.Text = "1 hora";
            this.lblShowTime.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // lblTime
            // 
            this.lblTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTime.AutoSize = true;
            this.lblTime.Location = new System.Drawing.Point(514, 14);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(54, 19);
            this.lblTime.TabIndex = 4;
            this.lblTime.Text = "Tiempo";
            this.lblTime.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // mtbTime
            // 
            this.mtbTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.mtbTime.BackColor = System.Drawing.Color.Transparent;
            this.mtbTime.LargeChange = 2;
            this.mtbTime.Location = new System.Drawing.Point(514, 51);
            this.mtbTime.Maximum = 15;
            this.mtbTime.Minimum = 1;
            this.mtbTime.Name = "mtbTime";
            this.mtbTime.Size = new System.Drawing.Size(75, 23);
            this.mtbTime.TabIndex = 3;
            this.mtbTime.Text = "metroTrackBar1";
            this.mtbTime.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.mtbTime.Value = 1;
            this.mtbTime.ValueChanged += new System.EventHandler(this.mtbTime_ValueChanged);
            // 
            // toggleStart
            // 
            this.toggleStart.AutoSize = true;
            this.toggleStart.Location = new System.Drawing.Point(3, 57);
            this.toggleStart.Name = "toggleStart";
            this.toggleStart.Size = new System.Drawing.Size(80, 17);
            this.toggleStart.TabIndex = 2;
            this.toggleStart.Text = "Off";
            this.toggleStart.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.toggleStart.UseSelectable = true;
            this.toggleStart.CheckedChanged += new System.EventHandler(this.toggleStart_CheckedChanged);
            // 
            // metroTabPage3
            // 
            this.metroTabPage3.Controls.Add(this.btnRestore);
            this.metroTabPage3.Controls.Add(this.metroLabel8);
            this.metroTabPage3.Controls.Add(this.metroLabel7);
            this.metroTabPage3.Controls.Add(this.metroLabel6);
            this.metroTabPage3.Controls.Add(this.metroLabel5);
            this.metroTabPage3.Controls.Add(this.metroLabel4);
            this.metroTabPage3.Controls.Add(this.metroLabel3);
            this.metroTabPage3.HorizontalScrollbarBarColor = true;
            this.metroTabPage3.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage3.HorizontalScrollbarSize = 10;
            this.metroTabPage3.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage3.Name = "metroTabPage3";
            this.metroTabPage3.Size = new System.Drawing.Size(592, 253);
            this.metroTabPage3.TabIndex = 2;
            this.metroTabPage3.Text = "Acerca de";
            this.metroTabPage3.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroTabPage3.VerticalScrollbarBarColor = true;
            this.metroTabPage3.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage3.VerticalScrollbarSize = 10;
            // 
            // btnRestore
            // 
            this.btnRestore.Location = new System.Drawing.Point(462, 69);
            this.btnRestore.Name = "btnRestore";
            this.btnRestore.Size = new System.Drawing.Size(75, 23);
            this.btnRestore.TabIndex = 8;
            this.btnRestore.Text = "Restablecer";
            this.btnRestore.UseSelectable = true;
            this.btnRestore.Click += new System.EventHandler(this.btnRestore_Click);
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel8.Location = new System.Drawing.Point(439, 29);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(98, 25);
            this.metroLabel8.TabIndex = 7;
            this.metroLabel8.Text = "Restablecer";
            this.metroLabel8.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.Location = new System.Drawing.Point(3, 194);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(190, 19);
            this.metroLabel7.TabIndex = 6;
            this.metroLabel7.Text = "Ulises Isaac Santana Hernandez";
            this.metroLabel7.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(3, 222);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(159, 19);
            this.metroLabel6.TabIndex = 5;
            this.metroLabel6.Text = "Esteban Juarez Rodriguez";
            this.metroLabel6.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel5.Location = new System.Drawing.Point(3, 164);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(130, 25);
            this.metroLabel5.TabIndex = 4;
            this.metroLabel5.Text = "Desarrolladores";
            this.metroLabel5.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(3, 54);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(199, 19);
            this.metroLabel4.TabIndex = 3;
            this.metroLabel4.Text = "Aumenta tu productividad diaria";
            this.metroLabel4.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel3.Location = new System.Drawing.Point(3, 29);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(111, 25);
            this.metroLabel3.TabIndex = 2;
            this.metroLabel3.Text = "BeProductive";
            this.metroLabel3.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // mttLevel
            // 
            this.mttLevel.Style = MetroFramework.MetroColorStyle.Blue;
            this.mttLevel.StyleManager = null;
            this.mttLevel.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // tmrProductive
            // 
            this.tmrProductive.Tick += new System.EventHandler(this.tmrProductive_Tick);
            // 
            // ntiBeProductive
            // 
            this.ntiBeProductive.Icon = ((System.Drawing.Icon)(resources.GetObject("ntiBeProductive.Icon")));
            this.ntiBeProductive.Text = "Be Productive!";
            this.ntiBeProductive.Visible = true;
            this.ntiBeProductive.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.ntiBeProductive_MouseDoubleClick);
            // 
            // cmsIcon
            // 
            this.cmsIcon.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mostrarToolStripMenuItem,
            this.cerrarToolStripMenuItem});
            this.cmsIcon.Name = "cmsIcon";
            this.cmsIcon.Size = new System.Drawing.Size(116, 48);
            // 
            // mostrarToolStripMenuItem
            // 
            this.mostrarToolStripMenuItem.Name = "mostrarToolStripMenuItem";
            this.mostrarToolStripMenuItem.Size = new System.Drawing.Size(115, 22);
            this.mostrarToolStripMenuItem.Text = "Mostrar";
            this.mostrarToolStripMenuItem.Click += new System.EventHandler(this.mostrarToolStripMenuItem_Click);
            // 
            // cerrarToolStripMenuItem
            // 
            this.cerrarToolStripMenuItem.Name = "cerrarToolStripMenuItem";
            this.cerrarToolStripMenuItem.Size = new System.Drawing.Size(115, 22);
            this.cerrarToolStripMenuItem.Text = "Cerrar";
            this.cerrarToolStripMenuItem.Click += new System.EventHandler(this.cerrarToolStripMenuItem_Click);
            // 
            // metroContextMenu1
            // 
            this.metroContextMenu1.Name = "metroContextMenu1";
            this.metroContextMenu1.Size = new System.Drawing.Size(61, 4);
            // 
            // tmrSoftware
            // 
            this.tmrSoftware.Interval = 15000;
            this.tmrSoftware.Tick += new System.EventHandler(this.tmrSoftware_Tick);
            // 
            // frmIsLogged
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(646, 381);
            this.Controls.Add(this.tabMain);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmIsLogged";
            this.Text = "Be Productive";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmIsLogged_FormClosed);
            this.Load += new System.EventHandler(this.frmIsLogged_Load);
            this.tabMain.ResumeLayout(false);
            this.metroTabPage1.ResumeLayout(false);
            this.metroTabPage1.PerformLayout();
            this.metroTabPage3.ResumeLayout(false);
            this.metroTabPage3.PerformLayout();
            this.cmsIcon.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private MetroFramework.Controls.MetroTabControl tabMain;
        private MetroFramework.Controls.MetroTabPage metroTabPage1;
        private MetroFramework.Controls.MetroToggle toggleStart;
        private MetroFramework.Controls.MetroLabel lblShowTime;
        private MetroFramework.Controls.MetroLabel lblTime;
        private MetroFramework.Controls.MetroTrackBar mtbTime;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroComboBox cmbLevel;
        private MetroFramework.Components.MetroToolTip mttLevel;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private System.Windows.Forms.Timer tmrProductive;
        private System.Windows.Forms.NotifyIcon ntiBeProductive;
        private MetroFramework.Controls.MetroTabPage metroTabPage3;
        private MetroFramework.Controls.MetroButton btnRestore;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private System.Windows.Forms.ContextMenuStrip cmsIcon;
        private System.Windows.Forms.ToolStripMenuItem mostrarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cerrarToolStripMenuItem;
        private MetroFramework.Controls.MetroContextMenu metroContextMenu1;
        private System.Windows.Forms.Timer tmrSoftware;
    }
}

