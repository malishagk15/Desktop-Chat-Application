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
    public partial class forget_pass_form : Form
    {
        IFirebaseConfig config = new FirebaseConfig
        {
            AuthSecret = "NxLQZab2e8J3C9Ocd7ecOYaEBeHYbVm4khyFEi1D",
            BasePath = "https://chat-application-2c1f1.firebaseio.com/"
        };

        IFirebaseClient client;
        public forget_pass_form()
        {
            InitializeComponent();
        }

        private void Email_id_Enter(object sender, EventArgs e)
        {

        }

        private void Email_id_Leave(object sender, EventArgs e)
        {

        }

        private void Back_btn_MouseHover(object sender, EventArgs e)
        {
            back_btn.BackColor = Color.Gold;
        }

        private void Back_btn_MouseLeave(object sender, EventArgs e)
        {
            back_btn.BackColor = Color.DimGray;
        }

        private void Back_btn_Click(object sender, EventArgs e)
        {
            login_form lg_form = new login_form();
            this.Visible = false;
            lg_form.Visible = true;
        }

        private void Min_btn_MouseHover(object sender, EventArgs e)
        {
            min_btn.BackColor = Color.Blue;
        }

        private void Min_btn_MouseLeave(object sender, EventArgs e)
        {
            min_btn.BackColor = Color.DimGray;
        }

        private void Min_btn_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void Close_btn_MouseHover(object sender, EventArgs e)
        {
            close_btn.BackColor = Color.Red;
        }

        private void Close_btn_MouseLeave(object sender, EventArgs e)
        {
            close_btn.BackColor = Color.DimGray;
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

        private void Search_btn_MouseHover(object sender, EventArgs e)
        {
            search_btn.BackColor = Color.Blue;
        }

        private void Search_btn_MouseLeave(object sender, EventArgs e)
        {
            search_btn.BackColor = Color.Silver;
        }

        private void Email_id_TextChanged(object sender, EventArgs e)
        {

        }

        private void Search_btn_Click(object sender, EventArgs e)
        {
            if (user_name.Text.Length != 0)
            {
                SearchData();
            }            
        }

        private async void SearchData()
        {
            var data = new ForgetPassData
            {
                UserName = user_name.Text
            };

            try
            {
                FirebaseResponse response = await client.GetTaskAsync("Us/" + user_name.Text);
                ForgetPassData user = response.ResultAs<ForgetPassData>();

                security_check sc_form = new security_check(user.UserName);
                this.Visible = false;
                sc_form.Visible = true;


            }
            catch (Exception e)
            {
                MessageBox.Show("User not found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private static bool CheckInternet()
        {
            try
            {
                using (var check_internet = new System.Net.WebClient())
                using (var stream = check_internet.OpenRead("https://chat-application-2c1f1.firebaseio.com/"))
                {
                    return true;
                }
            }
            catch
            {
                return false;
            }
        }

        private void Forget_pass_form_Load(object sender, EventArgs e)
        {
            client = new FireSharp.FirebaseClient(config);
        }
    }
}

class ForgetPassData
{
    public string UserName { get; set; }

}