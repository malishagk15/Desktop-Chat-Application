using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Text.RegularExpressions;

using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;

namespace ChatApp
{
    public partial class change_pass_form : Form
    {
        IFirebaseConfig config = new FirebaseConfig
        {
            AuthSecret = "NxLQZab2e8J3C9Ocd7ecOYaEBeHYbVm4khyFEi1D",
            BasePath = "https://chat-application-2c1f1.firebaseio.com/"
        };

        IFirebaseClient client;
        public change_pass_form(string user)
        {
            InitializeComponent();
            username.Text = user;
        }

        private void Back_btn_MouseHover(object sender, EventArgs e)
        {
            back_btn.BackColor = Color.Gold;
        }

        private void Back_btn_MouseLeave(object sender, EventArgs e)
        {
            back_btn.BackColor = Color.DimGray;
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

        public string value;

        private void Back_btn_Click(object sender, EventArgs e)
        {
            security_check scheck_form = new security_check(value);
            this.Visible = false;
            scheck_form.Visible = true;
        }
        
        private void Change_pass_btn_MouseHover(object sender, EventArgs e)
        {
            change_pass_btn.BackColor = Color.DarkBlue;
        }

        private void Change_pass_btn_MouseLeave(object sender, EventArgs e)
        {
            change_pass_btn.BackColor = Color.Silver;
        }

        private async void Change_pass_btn_Click(object sender, EventArgs e)
        {
            var data = new UpdatePassword
            {
                Password = password.Text
            };

            if (password.Text.Length!=0 && c_password.Text.Length != 0)
            {
                if (password.Text == c_password.Text)
                {
                    FirebaseResponse get_response = await client.UpdateTaskAsync("Us/" + username.Text,data);
                    Data obj = get_response.ResultAs<Data>();

                    MessageBox.Show("Password change successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    home_form home = new home_form(username.Text.ToString());
                    this.Visible = false;
                    home.Visible = true;
                }
                else
                {
                    MessageBox.Show("Passwords doesn't match", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    password.Text = "";
                    c_password.Text="";
                }
            }
            else
            {
                MessageBox.Show("Please fill all fields");
            }
        }

        private void Change_pass_form_Load(object sender, EventArgs e)
        {
            client = new FireSharp.FirebaseClient(config);
        }
    }
}

class UpdatePassword
{ 
    public string Password { get; set; }
   
}