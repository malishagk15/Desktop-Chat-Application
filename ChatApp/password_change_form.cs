using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChatApp
{
    public partial class password_change_form : Form
    {
        public password_change_form(string user)
        {
            InitializeComponent();
            which_user.Text = user;
        }

        private void Logout_btn_Click(object sender, EventArgs e)
        {
            const string message = "Are you sure that you would like to Logout?";
            const string caption = "Logout!";
            var result = MessageBox.Show(message, caption,
                                         MessageBoxButtons.YesNo,
                                         MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                login_form lg_form = new login_form();
                this.Visible = false;
                lg_form.Visible = true;
            }
        }

        private void Min_btn_MouseHover(object sender, EventArgs e)
        {
            min_btn.BackColor = Color.Blue;
        }

        private void Min_btn_MouseLeave(object sender, EventArgs e)
        {
            min_btn.BackColor = Color.DimGray;
        }

        private void Home_btn_Click(object sender, EventArgs e)
        {
            home_form home = new home_form(which_user.Text);
            this.Visible = false;
            home.Visible = true;
        }

        private void Profile_btn_Click(object sender, EventArgs e)
        {
            profile_form profile = new profile_form(which_user.Text);
            this.Visible = false;
            profile.Visible = true;
        }

        private void Change_pass_btn_Click(object sender, EventArgs e)
        {

        }
    }
}
