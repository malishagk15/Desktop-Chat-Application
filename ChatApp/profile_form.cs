using System;
using System.Windows.Forms;

using System.Text.RegularExpressions;

using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;
using System.IO;

using Firebase.Storage;

namespace ChatApp
{
    public partial class profile_form : Form
    {
        IFirebaseConfig config = new FirebaseConfig
        {
            AuthSecret = "NxLQZab2e8J3C9Ocd7ecOYaEBeHYbVm4khyFEi1D",
            BasePath = "https://chat-application-2c1f1.firebaseio.com/"
        };

        IFirebaseClient client;
        public profile_form(string user)
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

        private void Home_btn_Click(object sender, EventArgs e)
        {
            home_form home = new home_form(which_user.Text);
            this.Visible = false;
            home.Visible = true;
        }

        private void Change_password_btn_Click(object sender, EventArgs e)
        {
            password_change_form pw_change = new password_change_form(which_user.Text);
            this.Visible = false;
            pw_change.Visible = true;
        }

        private async void Profile_form_Load(object sender, EventArgs e)
        {
            client = new FireSharp.FirebaseClient(config);

            cancel_btn.Visible = false;
            update_btn.Visible = false;
            upload_profie_btn.Visible = false;

            user_name.Enabled = false;
            name.Enabled = false;
            email_address.Enabled = false;
            phone_no.Enabled = false;

            FirebaseResponse response = await client.GetTaskAsync("Us/" + which_user.Text);
            Data user = response.ResultAs<Data>();

            user_name.Text = user.UserName;
            name.Text = user.Name;
            email_address.Text = user.Email;
            phone_no.Text = user.PhoneNo;

            
        }

        private void Edit_profile_btn_Click(object sender, EventArgs e)
        {
            name.Enabled = true;
            email_address.Enabled = true;
            phone_no.Enabled = true;

            edit_profile_btn.Visible = false;
            update_btn.Visible = true;
            cancel_btn.Visible = true;
            upload_profie_btn.Visible = true;

            home_btn.Enabled = false;
            change_password_btn.Enabled = false;
            logout_btn.Enabled = false;
        }

        private void Cancel_btn_Click(object sender, EventArgs e)
        {
            const string message = "Are you sure that you would like to Cancel?";
            const string caption = "Cancel!";
            var result = MessageBox.Show(message, caption,
                                         MessageBoxButtons.YesNo,
                                         MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                profile_form pro_fm = new profile_form(which_user.Text);
                this.Visible = false;
                pro_fm.Visible = true;
            }
        }

        private async void Update_btn_Click(object sender, EventArgs e)
        {
            if (name.Text.Length == 0 || phone_no.Text.Length == 0 || email_address.Text.Length == 0)
            {
                MessageBox.Show("Please Fill All Fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (IsValidEmailId(email_address.Text))
                {
                    UpdateProfile();
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

        private async void UpdateProfile()
        {
            var data = new UpdateData
            {
                Name = name.Text,
                Email = email_address.Text,
                PhoneNo = phone_no.Text

            };

            if (CheckInternet())
            {
                FirebaseResponse get_response = await client.UpdateTaskAsync("Us/" + user_name.Text, data);
                Data obj = get_response.ResultAs<Data>();

                if (get_response != null)
                {
                    MessageBox.Show("Data Updated Successfully", "Update", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    profile_form pro_fm = new profile_form(which_user.Text);
                    this.Visible = false;
                    pro_fm.Visible = true;
                }
                else
                {
                    MessageBox.Show("Data Updated Fail,Try again", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please check your internet connection", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private async void Upload_profie_btn_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog()
            {
                Multiselect = false,
                ValidateNames=true,
                Filter="All files|*.*"
            })
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    FileInfo fi = new FileInfo(ofd.FileName);
                    /*
                    var stream = File.Open(@ofd.FileName, FileMode.Open);

                    

                    // Construct FirebaseStorage with path to where you want to upload the file and put it there
                    var task = new FirebaseStorage("gs://chat-application-2c1f1.appspot.com")
                     .Child("Us")
                     .Child("Profile_pic")
                     .PutAsync(stream);

                    // Track progress of the upload
                    task.Progress.ProgressChanged += (s, e1) => Console.WriteLine($"Progress: {e1.Percentage} %");

                    // Await the task to wait until upload is completed and get the download url
                    var downloadUrl = await task;

                    if (downloadUrl.Length != 0)
                    {
                        MessageBox.Show("done");
                    }
                    */
                }
                

            }

        }

    }
}

class UpdateData
{
    public string Name { get; set; }
    public string Email { get; set; }
    public string PhoneNo { get; set; }

}