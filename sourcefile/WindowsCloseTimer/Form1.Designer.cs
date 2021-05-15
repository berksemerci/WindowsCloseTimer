namespace WindowsCloseTimer
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.close_lbl = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.hour = new System.Windows.Forms.NumericUpDown();
            this.minute = new System.Windows.Forms.NumericUpDown();
            this.second = new System.Windows.Forms.NumericUpDown();
            this.attime_chck = new System.Windows.Forms.CheckBox();
            this.muchtime_chck = new System.Windows.Forms.CheckBox();
            this.restart_chck = new System.Windows.Forms.CheckBox();
            this.now_btn = new System.Windows.Forms.Button();
            this.start_btn = new System.Windows.Forms.Button();
            this.info_lbl = new System.Windows.Forms.Label();
            this.hide_lbl = new System.Windows.Forms.Label();
            this.tm2 = new System.Windows.Forms.TextBox();
            this.tm1 = new System.Windows.Forms.TextBox();
            this.tm3 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.cancel_btn = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.goster = new System.Windows.Forms.Panel();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.show_menu = new System.Windows.Forms.ToolStripMenuItem();
            this.hide_menu = new System.Windows.Forms.ToolStripMenuItem();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.infopanel = new System.Windows.Forms.Panel();
            this.hide_info = new System.Windows.Forms.LinkLabel();
            this.label99 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.hibernate_chck = new System.Windows.Forms.CheckBox();
            this.shutdown_chck = new System.Windows.Forms.CheckBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.hour)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minute)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.second)).BeginInit();
            this.goster.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.infopanel.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // close_lbl
            // 
            this.close_lbl.AutoSize = true;
            this.close_lbl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(179)))), ((int)(((byte)(238)))));
            this.close_lbl.Cursor = System.Windows.Forms.Cursors.Default;
            this.close_lbl.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.close_lbl.ForeColor = System.Drawing.Color.White;
            this.close_lbl.Location = new System.Drawing.Point(421, 112);
            this.close_lbl.Name = "close_lbl";
            this.close_lbl.Size = new System.Drawing.Size(18, 24);
            this.close_lbl.TabIndex = 1;
            this.close_lbl.Text = "X";
            this.close_lbl.Click += new System.EventHandler(this.close_lbl_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(179)))), ((int)(((byte)(238)))));
            this.label2.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.label2.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(144, 187);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(189, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Please Enter The Switch-Off Time";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(179)))), ((int)(((byte)(238)))));
            this.label3.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(167, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(151, 17);
            this.label3.TabIndex = 22;
            this.label3.Text = "Hour              Minute           Second";
            // 
            // hour
            // 
            this.hour.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(179)))), ((int)(((byte)(238)))));
            this.hour.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.hour.ForeColor = System.Drawing.Color.White;
            this.hour.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.hour.Location = new System.Drawing.Point(20, 10);
            this.hour.Maximum = new decimal(new int[] {
            24,
            0,
            0,
            0});
            this.hour.Name = "hour";
            this.hour.Size = new System.Drawing.Size(52, 26);
            this.hour.TabIndex = 21;
            // 
            // minute
            // 
            this.minute.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(179)))), ((int)(((byte)(238)))));
            this.minute.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.minute.ForeColor = System.Drawing.Color.White;
            this.minute.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.minute.Location = new System.Drawing.Point(77, 10);
            this.minute.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.minute.Name = "minute";
            this.minute.Size = new System.Drawing.Size(52, 26);
            this.minute.TabIndex = 20;
            // 
            // second
            // 
            this.second.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(179)))), ((int)(((byte)(238)))));
            this.second.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.second.ForeColor = System.Drawing.Color.White;
            this.second.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.second.Location = new System.Drawing.Point(134, 10);
            this.second.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.second.Name = "second";
            this.second.Size = new System.Drawing.Size(52, 26);
            this.second.TabIndex = 19;
            // 
            // attime_chck
            // 
            this.attime_chck.AutoSize = true;
            this.attime_chck.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(179)))), ((int)(((byte)(238)))));
            this.attime_chck.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 9.75F);
            this.attime_chck.ForeColor = System.Drawing.Color.White;
            this.attime_chck.Location = new System.Drawing.Point(204, 231);
            this.attime_chck.Name = "attime_chck";
            this.attime_chck.Size = new System.Drawing.Size(79, 21);
            this.attime_chck.TabIndex = 23;
            this.attime_chck.Text = "At the time";
            this.attime_chck.UseVisualStyleBackColor = false;
            this.attime_chck.CheckedChanged += new System.EventHandler(this.attime_chck_CheckedChanged);
            // 
            // muchtime_chck
            // 
            this.muchtime_chck.AutoSize = true;
            this.muchtime_chck.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(179)))), ((int)(((byte)(238)))));
            this.muchtime_chck.Checked = true;
            this.muchtime_chck.CheckState = System.Windows.Forms.CheckState.Checked;
            this.muchtime_chck.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 9.75F);
            this.muchtime_chck.ForeColor = System.Drawing.Color.White;
            this.muchtime_chck.Location = new System.Drawing.Point(181, 210);
            this.muchtime_chck.Name = "muchtime_chck";
            this.muchtime_chck.Size = new System.Drawing.Size(122, 21);
            this.muchtime_chck.TabIndex = 24;
            this.muchtime_chck.Text = "After this much time";
            this.muchtime_chck.UseVisualStyleBackColor = false;
            this.muchtime_chck.CheckedChanged += new System.EventHandler(this.muchtime_chck_CheckedChanged);
            // 
            // restart_chck
            // 
            this.restart_chck.AutoSize = true;
            this.restart_chck.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(179)))), ((int)(((byte)(238)))));
            this.restart_chck.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.restart_chck.ForeColor = System.Drawing.Color.White;
            this.restart_chck.Location = new System.Drawing.Point(55, 212);
            this.restart_chck.Name = "restart_chck";
            this.restart_chck.Size = new System.Drawing.Size(58, 20);
            this.restart_chck.TabIndex = 25;
            this.restart_chck.Text = "Restart";
            this.restart_chck.UseVisualStyleBackColor = false;
            this.restart_chck.CheckedChanged += new System.EventHandler(this.restart_chck_CheckedChanged);
            // 
            // now_btn
            // 
            this.now_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(179)))), ((int)(((byte)(238)))));
            this.now_btn.Cursor = System.Windows.Forms.Cursors.Default;
            this.now_btn.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 9.75F);
            this.now_btn.ForeColor = System.Drawing.Color.White;
            this.now_btn.Location = new System.Drawing.Point(16, 34);
            this.now_btn.Name = "now_btn";
            this.now_btn.Size = new System.Drawing.Size(140, 23);
            this.now_btn.TabIndex = 28;
            this.now_btn.Text = "Restart Now";
            this.now_btn.UseVisualStyleBackColor = false;
            this.now_btn.Click += new System.EventHandler(this.now_btn_Click);
            // 
            // start_btn
            // 
            this.start_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(179)))), ((int)(((byte)(238)))));
            this.start_btn.Cursor = System.Windows.Forms.Cursors.Default;
            this.start_btn.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 9.75F);
            this.start_btn.ForeColor = System.Drawing.Color.White;
            this.start_btn.Location = new System.Drawing.Point(16, 7);
            this.start_btn.Name = "start_btn";
            this.start_btn.Size = new System.Drawing.Size(140, 23);
            this.start_btn.TabIndex = 26;
            this.start_btn.Text = "Start Time";
            this.start_btn.UseVisualStyleBackColor = false;
            this.start_btn.Click += new System.EventHandler(this.start_btn_Click);
            // 
            // info_lbl
            // 
            this.info_lbl.AutoSize = true;
            this.info_lbl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(179)))), ((int)(((byte)(238)))));
            this.info_lbl.Cursor = System.Windows.Forms.Cursors.Default;
            this.info_lbl.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.info_lbl.ForeColor = System.Drawing.Color.White;
            this.info_lbl.Location = new System.Drawing.Point(51, 135);
            this.info_lbl.Name = "info_lbl";
            this.info_lbl.Size = new System.Drawing.Size(19, 24);
            this.info_lbl.TabIndex = 30;
            this.info_lbl.Text = "?";
            this.info_lbl.Click += new System.EventHandler(this.info_lbl_Click);
            // 
            // hide_lbl
            // 
            this.hide_lbl.AutoSize = true;
            this.hide_lbl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(179)))), ((int)(((byte)(238)))));
            this.hide_lbl.Cursor = System.Windows.Forms.Cursors.Default;
            this.hide_lbl.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.hide_lbl.ForeColor = System.Drawing.Color.White;
            this.hide_lbl.Location = new System.Drawing.Point(404, 121);
            this.hide_lbl.Name = "hide_lbl";
            this.hide_lbl.Size = new System.Drawing.Size(14, 16);
            this.hide_lbl.TabIndex = 31;
            this.hide_lbl.Text = "_";
            this.hide_lbl.Click += new System.EventHandler(this.hide_lbl_Click);
            // 
            // tm2
            // 
            this.tm2.Enabled = false;
            this.tm2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tm2.Location = new System.Drawing.Point(110, 55);
            this.tm2.Name = "tm2";
            this.tm2.Size = new System.Drawing.Size(35, 29);
            this.tm2.TabIndex = 36;
            this.tm2.Text = "0";
            this.tm2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tm1
            // 
            this.tm1.Enabled = false;
            this.tm1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tm1.Location = new System.Drawing.Point(69, 55);
            this.tm1.Name = "tm1";
            this.tm1.Size = new System.Drawing.Size(35, 29);
            this.tm1.TabIndex = 35;
            this.tm1.Text = "0";
            this.tm1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tm3
            // 
            this.tm3.Enabled = false;
            this.tm3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tm3.Location = new System.Drawing.Point(151, 55);
            this.tm3.Name = "tm3";
            this.tm3.Size = new System.Drawing.Size(35, 29);
            this.tm3.TabIndex = 37;
            this.tm3.Text = "0";
            this.tm3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 9.75F);
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(71, 112);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(122, 17);
            this.label7.TabIndex = 34;
            this.label7.Text = "In computer will turn off.";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 9.75F);
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(71, 88);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(31, 17);
            this.label9.TabIndex = 38;
            this.label9.Text = "Hour";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(48, 24);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(163, 24);
            this.label6.TabIndex = 33;
            this.label6.Text = "Remaining Time";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 9.75F);
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(108, 88);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(42, 17);
            this.label10.TabIndex = 39;
            this.label10.Text = "Minute";
            // 
            // cancel_btn
            // 
            this.cancel_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(179)))), ((int)(((byte)(238)))));
            this.cancel_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cancel_btn.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 9.75F);
            this.cancel_btn.ForeColor = System.Drawing.Color.White;
            this.cancel_btn.Location = new System.Drawing.Point(71, 148);
            this.cancel_btn.Name = "cancel_btn";
            this.cancel_btn.Size = new System.Drawing.Size(120, 23);
            this.cancel_btn.TabIndex = 29;
            this.cancel_btn.Text = "Cancel Process";
            this.cancel_btn.UseVisualStyleBackColor = false;
            this.cancel_btn.Click += new System.EventHandler(this.cancel_btn_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 9.75F);
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(148, 88);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(44, 17);
            this.label11.TabIndex = 40;
            this.label11.Text = "Second";
            // 
            // goster
            // 
            this.goster.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(179)))), ((int)(((byte)(238)))));
            this.goster.Controls.Add(this.label11);
            this.goster.Controls.Add(this.cancel_btn);
            this.goster.Controls.Add(this.label10);
            this.goster.Controls.Add(this.label6);
            this.goster.Controls.Add(this.label9);
            this.goster.Controls.Add(this.label7);
            this.goster.Controls.Add(this.tm3);
            this.goster.Controls.Add(this.tm1);
            this.goster.Controls.Add(this.tm2);
            this.goster.Location = new System.Drawing.Point(117, 121);
            this.goster.Name = "goster";
            this.goster.Size = new System.Drawing.Size(254, 190);
            this.goster.TabIndex = 32;
            this.goster.Visible = false;
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.ContextMenuStrip = this.contextMenuStrip1;
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "Windows Kapatıcı";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.Click += new System.EventHandler(this.notifyIcon1_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.show_menu,
            this.hide_menu});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(104, 48);
            // 
            // show_menu
            // 
            this.show_menu.Name = "show_menu";
            this.show_menu.Size = new System.Drawing.Size(103, 22);
            this.show_menu.Text = "Show";
            this.show_menu.Click += new System.EventHandler(this.show_menu_Click);
            // 
            // hide_menu
            // 
            this.hide_menu.Name = "hide_menu";
            this.hide_menu.Size = new System.Drawing.Size(103, 22);
            this.hide_menu.Text = "Hide";
            this.hide_menu.Click += new System.EventHandler(this.hide_menu_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Interval = 1000;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(179)))), ((int)(((byte)(238)))));
            this.panel1.Controls.Add(this.hour);
            this.panel1.Controls.Add(this.minute);
            this.panel1.Controls.Add(this.second);
            this.panel1.Location = new System.Drawing.Point(138, 133);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(207, 54);
            this.panel1.TabIndex = 34;
            // 
            // infopanel
            // 
            this.infopanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(179)))), ((int)(((byte)(238)))));
            this.infopanel.Controls.Add(this.hide_info);
            this.infopanel.Controls.Add(this.label99);
            this.infopanel.Location = new System.Drawing.Point(117, 121);
            this.infopanel.Name = "infopanel";
            this.infopanel.Size = new System.Drawing.Size(254, 190);
            this.infopanel.TabIndex = 41;
            this.infopanel.Visible = false;
            // 
            // hide_info
            // 
            this.hide_info.AutoSize = true;
            this.hide_info.Cursor = System.Windows.Forms.Cursors.Hand;
            this.hide_info.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 9.75F);
            this.hide_info.ForeColor = System.Drawing.Color.White;
            this.hide_info.LinkColor = System.Drawing.Color.White;
            this.hide_info.Location = new System.Drawing.Point(86, 9);
            this.hide_info.Name = "hide_info";
            this.hide_info.Size = new System.Drawing.Size(80, 17);
            this.hide_info.TabIndex = 35;
            this.hide_info.TabStop = true;
            this.hide_info.Text = "Close to Inform";
            this.hide_info.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.hide_info_LinkClicked);
            // 
            // label99
            // 
            this.label99.AutoSize = true;
            this.label99.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 9.75F);
            this.label99.ForeColor = System.Drawing.Color.White;
            this.label99.Location = new System.Drawing.Point(3, 44);
            this.label99.Name = "label99";
            this.label99.Size = new System.Drawing.Size(261, 136);
            this.label99.TabIndex = 34;
            this.label99.Text = resources.GetString("label99.Text");
            this.label99.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(179)))), ((int)(((byte)(238)))));
            this.panel2.Controls.Add(this.now_btn);
            this.panel2.Controls.Add(this.start_btn);
            this.panel2.Location = new System.Drawing.Point(159, 254);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(186, 60);
            this.panel2.TabIndex = 42;
            // 
            // hibernate_chck
            // 
            this.hibernate_chck.AutoSize = true;
            this.hibernate_chck.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(179)))), ((int)(((byte)(238)))));
            this.hibernate_chck.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.hibernate_chck.ForeColor = System.Drawing.Color.White;
            this.hibernate_chck.Location = new System.Drawing.Point(76, 237);
            this.hibernate_chck.Name = "hibernate_chck";
            this.hibernate_chck.Size = new System.Drawing.Size(71, 20);
            this.hibernate_chck.TabIndex = 43;
            this.hibernate_chck.Text = "Hibernate";
            this.hibernate_chck.UseVisualStyleBackColor = false;
            this.hibernate_chck.CheckedChanged += new System.EventHandler(this.hibernate_chck_CheckedChanged);
            // 
            // shutdown_chck
            // 
            this.shutdown_chck.AutoSize = true;
            this.shutdown_chck.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(179)))), ((int)(((byte)(238)))));
            this.shutdown_chck.Checked = true;
            this.shutdown_chck.CheckState = System.Windows.Forms.CheckState.Checked;
            this.shutdown_chck.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.shutdown_chck.ForeColor = System.Drawing.Color.White;
            this.shutdown_chck.Location = new System.Drawing.Point(37, 187);
            this.shutdown_chck.Name = "shutdown_chck";
            this.shutdown_chck.Size = new System.Drawing.Size(73, 20);
            this.shutdown_chck.TabIndex = 44;
            this.shutdown_chck.Text = "Shutdown";
            this.shutdown_chck.UseVisualStyleBackColor = false;
            this.shutdown_chck.CheckedChanged += new System.EventHandler(this.shutdown_chck_CheckedChanged);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::WindowsCloseTimer.Properties.Resources.Başlıksız_1;
            this.pictureBox2.Location = new System.Drawing.Point(354, 166);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(79, 77);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 45;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = global::WindowsCloseTimer.Properties.Resources.Untitled;
            this.pictureBox1.Location = new System.Drawing.Point(-1, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(472, 332);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(470, 330);
            this.Controls.Add(this.infopanel);
            this.Controls.Add(this.goster);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.attime_chck);
            this.Controls.Add(this.shutdown_chck);
            this.Controls.Add(this.hibernate_chck);
            this.Controls.Add(this.hide_lbl);
            this.Controls.Add(this.info_lbl);
            this.Controls.Add(this.restart_chck);
            this.Controls.Add(this.muchtime_chck);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.close_lbl);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Windows Shutdown Timer";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.hour)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minute)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.second)).EndInit();
            this.goster.ResumeLayout(false);
            this.goster.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.infopanel.ResumeLayout(false);
            this.infopanel.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label close_lbl;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown hour;
        private System.Windows.Forms.NumericUpDown minute;
        private System.Windows.Forms.NumericUpDown second;
        private System.Windows.Forms.CheckBox attime_chck;
        private System.Windows.Forms.CheckBox muchtime_chck;
        private System.Windows.Forms.CheckBox restart_chck;
        private System.Windows.Forms.Button now_btn;
        private System.Windows.Forms.Button start_btn;
        private System.Windows.Forms.Label info_lbl;
        private System.Windows.Forms.Label hide_lbl;
        private System.Windows.Forms.TextBox tm2;
        private System.Windows.Forms.TextBox tm1;
        private System.Windows.Forms.TextBox tm3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button cancel_btn;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Panel goster;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem show_menu;
        private System.Windows.Forms.ToolStripMenuItem hide_menu;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel infopanel;
        private System.Windows.Forms.LinkLabel hide_info;
        private System.Windows.Forms.Label label99;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.CheckBox hibernate_chck;
        private System.Windows.Forms.CheckBox shutdown_chck;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}

