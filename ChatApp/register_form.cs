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
    public partial class register_form : Form
    {
        IFirebaseConfig config = new FirebaseConfig
        {
            AuthSecret = "NxLQZab2e8J3C9Ocd7ecOYaEBeHYbVm4khyFEi1D",
            BasePath = "https://chat-application-2c1f1.firebaseio.com/"
        };

        IFirebaseClient client;
        public register_form()
        {
            InitializeComponent();
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

        private void Min_btn_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
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

        private void Register_btn_MouseHover(object sender, EventArgs e)
        {
            register_btn.BackColor = Color.Green;
        }

        private void Register_btn_MouseLeave(object sender, EventArgs e)
        {
            register_btn.BackColor = Color.Silver;
        }

        private void Reset_btn_MouseHover(object sender, EventArgs e)
        {
            reset_btn.BackColor = Color.Red;
        }

        private void Reset_btn_MouseLeave(object sender, EventArgs e)
        {
            reset_btn.BackColor = Color.Silver;
        }

        private void Reset_btn_Click(object sender, EventArgs e)
        {
            name.Text = "";
            email_address.Text = "";
            phone_no.Text = "";
            password.Text = "";
            c_password.Text = "";
            ques_selection.SelectedIndex = -1;
            answer.Text = "";
        }

        private void Register_btn_Click(object sender, EventArgs e)
        {
            if (name.Text.Length ==0 || email_address.Text.Length ==0 || phone_no.Text.Length ==0||password.Text.Length ==0||c_password.Text.Length ==0||answer.Text.Length ==0||ques_selection.SelectedIndex ==-1)
            {
                MessageBox.Show("Please Fill All Fields","Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
            }
            else
            {
                if (IsValidEmailId(email_address.Text))
                {
                    if (phone_no.Text.Length == 10)
                    {
                        if (password.Text == c_password.Text)
                        {
                            if (agree_checkbox.Checked)
                            {
                                if (CheckInternet())
                                {
                                    RegisterUser();
                                }
                                else
                                {
                                    MessageBox.Show("Please Check Your Internet Connection", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }

                            }
                            else
                            {
                                MessageBox.Show("You doesn't agree our terms and policy", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Passwords doesn't match", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            password.Text = "";
                            c_password.Text = "";
                        }
                    }
                    else
                    {
                        MessageBox.Show("Phone number is invalid", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Email Address is Invalid", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        
        public static bool IsValidEmailId(string InputEmail)
        {
            Regex regex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
            Match match = regex.Match(InputEmail);
            if (match.Success)
                return true;
            else
                return false;
        }


        private async void RegisterUser()
        {
            var data = new Data
            {
                Name = name.Text,
                Email = email_address.Text,
                PhoneNo = phone_no.Text,
                Password = password.Text,
                SeQues = ques_selection.Text,
                Answer = answer.Text,
                UserName=user_name.Text

            };
            
            try
            {
                FirebaseResponse get_response = await client.GetTaskAsync("Us/" + user_name.Text);
                Data obj = get_response.ResultAs<Data>();

                MessageBox.Show("Username already exits", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                

            }
            catch(Exception e)
            {
               
                    SetResponse response = await client.SetTaskAsync("Us/" + user_name.Text, data);
                    Data result = response.ResultAs<Data>();
                    MessageBox.Show("Your account registered successfully", "Welcome " + name.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);


                    home_form home = new home_form(user_name.Text);
                    this.Visible = false;
                    home.Visible = true;
                
               
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

        private void Register_form_Load(object sender, EventArgs e)
        {
            client = new FireSharp.FirebaseClient(config);
        }

        private void Phone_no_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8)
            {
                e.Handled = true;
            }
        }

        private void User_name_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsLetter(ch) && !Char.IsDigit(ch) && ch != 8)
            {
                e.Handled = true;
            }
        }
    }
}

class Data
{
    public string Email { get; set; }
    public string Name { get; set; }
    public string PhoneNo { get; set; }
    public string Password { get; set; }
    public string SeQues { get; set; }
    public string Answer { get; set; }
    public string UserName { get; set; }
}