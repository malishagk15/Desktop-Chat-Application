using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

using System.Text.RegularExpressions;

using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;


namespace ChatApp
{
    public partial class login_form : Form
    {
        IFirebaseConfig config = new FirebaseConfig
        {
            AuthSecret = "NxLQZab2e8J3C9Ocd7ecOYaEBeHYbVm4khyFEi1D",
            BasePath = "https://chat-application-2c1f1.firebaseio.com/"
        };

        IFirebaseClient client;

        public login_form()
        {
            InitializeComponent();
        }

        private void Login_form_Load(object sender, EventArgs e)
        {
            client = new FireSharp.FirebaseClient(config);
        }
        
        private void Login_Click(object sender, EventArgs e)
        {
            if (user_name.Text.Length == 0 || password.Text.Length == 0)
            {
                MessageBox.Show("Please Fill Email and Password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                    if (CheckInternet())
                    {
                        LoginUser();
                    }
                    else
                    {
                        MessageBox.Show("Please Check Your Internet Connection", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }               
            }
            
        }

        private async void LoginUser()
        {
            var data = new LoginData
            {
                UserName = user_name.Text,
                Password = password.Text,
            };

            try
            {
                FirebaseResponse response = await client.GetTaskAsync("Us/" + user_name.Text);
                LoginData user = response.ResultAs<LoginData>();

                if (user.Password == password.Text)
                {
                    MessageBox.Show("Login Successfully", "Welcome " + user.Name, MessageBoxButtons.OK, MessageBoxIcon.Information);

                    home_form home = new home_form(user.UserName);
                    this.Visible = false;
                    home.Visible = true;
                }
                else
                {
                    MessageBox.Show("Username or Password is wrong", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    password.Text = "";
                }

            }
            catch(Exception e)
            {
                MessageBox.Show("User not found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);

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

        private void Min_btn_MouseHover(object sender, EventArgs e)
        {
            min_btn.BackColor = Color.Blue;
        }

        private void Min_btn_MouseLeave(object sender, EventArgs e)
        {
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

        private void Email_id_TextChanged(object sender, EventArgs e)
        {

        }

        private void Email_id_Enter(object sender, EventArgs e)
        {
            
        }

        private void Email_id_Leave(object sender, EventArgs e)
        {
            
        }

        private void Password_Enter(object sender, EventArgs e)
        {
            
        }

        private void Password_Leave(object sender, EventArgs e)
        {
            
        }

        private void Register_btn_Click(object sender, EventArgs e)
        {
            register_form rg_form = new register_form();
            this.Visible = false;
            rg_form.Visible = true;
        }

        private void Login_btn_MouseHover(object sender, EventArgs e)
        {
            login_btn.BackColor = Color.Green;
        }

        private void Login_btn_MouseLeave(object sender, EventArgs e)
        {
            login_btn.BackColor = Color.Transparent;
        }

        private void Register_btn_MouseHover(object sender, EventArgs e)
        {
            register_btn.BackColor = Color.Aqua;
        }

        private void Register_btn_MouseLeave(object sender, EventArgs e)
        {
            register_btn.BackColor = Color.Transparent;
        }

        private void Forget_password_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            forget_pass_form for_pass_form = new forget_pass_form();
            this.Visible = false;
            for_pass_form.Visible = true;
        }

        private void User_name_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsLetter(ch) && !Char.IsDigit(ch) && ch!=8)
            {
                e.Handled = true;
            }
        }
    }
}

class LoginData
{
    public string UserName { get; set; }
    public string Password { get; set; }
    public string Name { get; set; }
}