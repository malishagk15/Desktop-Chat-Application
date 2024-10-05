using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;


namespace ChatApp
{
    public partial class welcome_from : Form
    {
        public welcome_from()
        {
            InitializeComponent();
        }

        private void Welcome_from_Load(object sender, EventArgs e)
        {
            close_btn.BackColor = Color.DimGray;
            min_btn.BackColor = Color.DimGray;
            

        }
        private void Close_btn_MouseHover(object sender, EventArgs e)
        {
            close_btn.BackColor = Color.Red;
        }

        private void Close_btn_MouseLeave(object sender, EventArgs e)
        {
            close_btn.BackColor = Color.DimGray;
        }

        private void Min_btn_MouseHover(object sender, EventArgs e)
        {
            min_btn.BackColor = Color.Blue;
        }

        private void Min_btn_MouseLeave(object sender, EventArgs e)
        {
            min_btn.BackColor = Color.DimGray;
        }

        private void Login_btn_Click(object sender, EventArgs e)
        {
            CheckInternet();
        }

        private void CheckInternet()
        {
            try
            {
                using (var check_internet = new System.Net.WebClient())
                using (var stream = check_internet.OpenRead("https://chat-application-2c1f1.firebaseio.com/"))
                {
                    login_form lg_form = new login_form();
                    this.Visible = false;
                    lg_form.Visible = true;
                }
            }
            catch
            {
                 MessageBox.Show("Please Check Your Internet Connection", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Login_btn_MouseHover(object sender, EventArgs e)
        {
            login_btn.BackColor = Color.Green;
        }

        private void Login_btn_MouseLeave(object sender, EventArgs e)
        {
            login_btn.BackColor = Color.Transparent;
        }

        private void Close_btn_Click(object sender, EventArgs e)
        {
            const string message = "Are you sure that you would like to Exit?";
            const string caption = "Exit!";
            var result = MessageBox.Show(message, caption,
                                         MessageBoxButtons.YesNo,
                                         MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void Min_btn_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
    }
}
