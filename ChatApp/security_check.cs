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
    public partial class security_check : Form
    {
        IFirebaseConfig config = new FirebaseConfig
        {
            AuthSecret = "NxLQZab2e8J3C9Ocd7ecOYaEBeHYbVm4khyFEi1D",
            BasePath = "https://chat-application-2c1f1.firebaseio.com/"
        };

        IFirebaseClient client;
        public security_check(string user)
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

        private void Back_btn_Click(object sender, EventArgs e)
        {
            forget_pass_form fp_form = new forget_pass_form();
            this.Visible = false;
            fp_form.Visible = true;
        }

        private void Next_btn_MouseHover(object sender, EventArgs e)
        {
            next_btn.BackColor = Color.Blue;
        }

        private void Next_btn_MouseLeave(object sender, EventArgs e)
        {
            next_btn.BackColor = Color.Silver;
        }

        private void Security_check_Load(object sender, EventArgs e)
        {
            client = new FireSharp.FirebaseClient(config);
        }

        private async void Next_btn_Click(object sender, EventArgs e)
        {
            FirebaseResponse get_response = await client.GetTaskAsync("Us/" + username.Text);
            Data obj = get_response.ResultAs<Data>();

            if(ques_selection.SelectedIndex>-1 && answer.Text.Length != 0)
            {
                if (ques_selection.SelectedItem.Equals(obj.SeQues) && answer.Text == obj.Answer)
                {
                    //MessageBox.Show("Sccuess");
                    change_pass_form cp_form = new change_pass_form(username.Text);
                    this.Visible = false;
                    cp_form.Visible = true;
                }
                else
                {
                    MessageBox.Show("Question or Answer is wrong","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please select Question Type the answer when your create the account","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
                
        }

    }
}
