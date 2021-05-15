using System;
using System.Drawing;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace WindowsCloseTimer
{
    public partial class Form1 : Form
    {
        int sn, dk, st, sure;
        string sn2, dk2, st2;
        string saat;

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd,
                         int Msg, int wParam, int lParam);

        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(0, 0, 0);
            TransparencyKey = Color.FromArgb(0, 0, 0);
        }

        private void hide_lbl_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void notifyIcon1_Click(object sender, EventArgs e)
        {
            this.Show();
        }

        private void show_menu_Click(object sender, EventArgs e)
        {
            this.Show();
        }

        private void hide_menu_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void info_lbl_Click(object sender, EventArgs e)
        {
            infopanel.Visible = true;

            shutdown_chck.Visible = false;
            restart_chck.Visible = false;
            hibernate_chck.Visible = false;

            pictureBox2.Visible = false;
        }

        private void hide_info_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            infopanel.Visible = false;

            shutdown_chck.Visible = true;
            restart_chck.Visible = true;
            hibernate_chck.Visible = true;

            pictureBox2.Visible = true;
        }

        private void close_lbl_Click(object sender, EventArgs e)
        {
            DialogResult cevap = new DialogResult();
            cevap = MessageBox.Show("If you close the program, your shutdown will be canceled. \nDo you want to close it?", "Notification", MessageBoxButtons.YesNo,MessageBoxIcon.Warning);
            if (DialogResult.Yes == cevap)
            {
                System.Diagnostics.Process.Start("shutdown", "-a");
                timer1.Stop();
                timer1.Enabled = false;
                timer2.Stop();
                timer2.Enabled = false;
                goster.Visible = false;
                hour.Value = 0;
                minute.Value = 0;
                second.Value = 0;

                try
                {
                    Application.Exit();
                }
                catch (Exception)
                {
                    Application.Exit();
                }                
            }
        }

        private void attime_chck_CheckedChanged(object sender, EventArgs e)
        {
            if (attime_chck.Checked == true)
            {
                muchtime_chck.Checked = false;
            }
        }

        private void muchtime_chck_CheckedChanged(object sender, EventArgs e)
        {
            if (muchtime_chck.Checked == true)
            {
                attime_chck.Checked = false;
            }
        }

        private void shutdown_chck_CheckedChanged(object sender, EventArgs e)
        {
            if (shutdown_chck.Checked == true)
            {
                restart_chck.Checked = false;
                hibernate_chck.Checked = false;
            }
        }

        private void restart_chck_CheckedChanged(object sender, EventArgs e)
        {
            if (restart_chck.Checked == true)
            {
                shutdown_chck.Checked = false;
                hibernate_chck.Checked = false;
            }
        }

        private void hibernate_chck_CheckedChanged(object sender, EventArgs e)
        {
            if (hibernate_chck.Checked == true)
            {
                shutdown_chck.Checked = false;
                restart_chck.Checked = false;
            }
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void start_btn_Click(object sender, EventArgs e)
        {
            if ((minute.Value == 0) && (hour.Value == 0) && (second.Value == 0))
            {
                MessageBox.Show("Time fields can not all be zero.", "Notification", MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
            else
            {
                if (muchtime_chck.Checked == true)
                {
                    if (shutdown_chck.Checked == true)
                    {
                        sn = Convert.ToInt32(second.Value.ToString());
                        dk = ((Convert.ToInt32(minute.Value.ToString())) * 60);
                        st = (((Convert.ToInt32(hour.Value.ToString())) * 60) * 60);
                        sure = sn + dk + st;
                        System.Diagnostics.Process.Start("shutdown", "-s -t " + sure + " -f");
                        goster.Visible = true;
                        timer1.Enabled = true;
                        timer1.Start();
                    }
                    if (restart_chck.Checked == true)
                    {
                        sn = Convert.ToInt32(second.Value.ToString());
                        dk = ((Convert.ToInt32(minute.Value.ToString())) * 60);
                        st = (((Convert.ToInt32(hour.Value.ToString())) * 60) * 60);
                        sure = sn + dk + st;
                        System.Diagnostics.Process.Start("shutdown", "-r -t " + sure + " -f");
                        goster.Visible = true;
                        timer1.Enabled = true;
                        timer1.Start();
                    }
                    if (hibernate_chck.Checked == true)
                    {
                        sn = Convert.ToInt32(second.Value.ToString());
                        dk = ((Convert.ToInt32(minute.Value.ToString())) * 60);
                        st = (((Convert.ToInt32(hour.Value.ToString())) * 60) * 60);
                        sure = sn + dk + st;
                        System.Diagnostics.Process.Start("shutdown", "-h -t " + sure + " -f");
                        goster.Visible = true;
                        timer1.Enabled = true;
                        timer1.Start();
                    }
                }

                if (attime_chck.Checked == true)
                {
                    sn2 = second.Value.ToString();
                    dk2 = minute.Value.ToString();
                    st2 = hour.Value.ToString();
                    timer2.Enabled = true;
                    timer2.Start();

                    if (Convert.ToInt32(sn2) < 10) { sn2 = "0" + sn2; }
                    if (Convert.ToInt32(dk2) < 10) { dk2 = "0" + dk2; }
                    if (Convert.ToInt32(st2) < 10) { st2 = "0" + st2; }

                    MessageBox.Show("The computer is set to shutdown at " + (st2 + ":" + dk2 + ":" + sn2), "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                shutdown_chck.Visible = false;
                restart_chck.Visible = false;
                hibernate_chck.Visible = false;

                pictureBox2.Visible = false;
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            saat = DateTime.Now.ToLongTimeString();

            if (saat == (st2 + ":" + dk2 + ":" + sn2))
            {
                if (shutdown_chck.Checked == true)
                {
                    System.Diagnostics.Process.Start("shutdown", "-s -f");
                }
                if (restart_chck.Checked == true)
                {
                    System.Diagnostics.Process.Start("shutdown", "-r -f");
                }
                if (hibernate_chck.Checked == true)
                {
                    System.Diagnostics.Process.Start("shutdown", "-h -f");
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (second.Value < 1)
            {
                second.Value = 59;
                if (minute.Value == 0)
                {
                    minute.Value = 59;
                    if (hour.Value != 0)
                    {
                        hour.Value -= 1;
                    }
                }
                else
                {
                    minute.Value -= 1;
                }
            }
            else
            {
                second.Value -= 1;
            }

            tm1.Text = hour.Value.ToString();
            tm2.Text = minute.Value.ToString();
            tm3.Text = second.Value.ToString();
        }

        private void now_btn_Click(object sender, EventArgs e)
        {
            DialogResult cevap = new DialogResult();
            cevap = MessageBox.Show("Are you sure you want to reboot now?", "Notification", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (DialogResult.Yes == cevap)
            {
                System.Diagnostics.Process.Start("shutdown", "-r");
            }            
        }

        private void cancel_btn_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("shutdown", "-a");
            timer1.Stop();
            timer1.Enabled = false;
            goster.Visible = false;
            timer2.Stop();
            timer2.Enabled = false;
            shutdown_chck.Visible = true;
            restart_chck.Visible = true;
            hibernate_chck.Visible = true;
            pictureBox2.Visible = true;
            hour.Value = 0;
            minute.Value = 0;
            second.Value = 0;

            MessageBox.Show("The current time setting and operation has been canceled.", "Notification", MessageBoxButtons.OK,MessageBoxIcon.Information);
        }
    }
}
