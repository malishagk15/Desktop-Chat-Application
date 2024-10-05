using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;

using MySql.Data.MySqlClient;

namespace ChatApp
{
    public partial class home_form : Form
    {
        IFirebaseConfig config = new FirebaseConfig
        {
            AuthSecret = "NxLQZab2e8J3C9Ocd7ecOYaEBeHYbVm4khyFEi1D",
            BasePath = "https://chat-application-2c1f1.firebaseio.com/"
        };

        IFirebaseClient client;
        public home_form(string userid)
        {
            InitializeComponent();
            which_user.Text = userid;

            SqlConnection();

        }

        private void Minimize_btn_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void Minimize_btn_MouseHover(object sender, EventArgs e)
        {
            minimize_btn.BackColor = Color.Blue;
        }

        private void Minimize_btn_MouseLeave(object sender, EventArgs e)
        {
            minimize_btn.BackColor = Color.DimGray;

        }

        public string mysqlstring = "SERVER='localhost';PORT='3306';DATABASE='chat_app';UID='root';PASSWORD='';";
        public void SqlConnection()
        {
            
            MySqlConnection con = new MySqlConnection(mysqlstring);
            try
            {
                con.Open();

                MessageBox.Show("Sql Connection sucessful");

                con.Close();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Sql connection fail"+ex.Message);
            }
        }


        private  async void Home_form_Load(object sender, EventArgs e)
        {
            client = new FireSharp.FirebaseClient(config);

            FirebaseResponse response = await client.GetTaskAsync("Us/" + which_user.Text);
            Data user = response.ResultAs<Data>();

            Name_lbl.Text = user.Name;

            chat_box.Visible = false;

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

        private void Profile_btn_Click(object sender, EventArgs e)
        {
            if (CheckInternet())
            {
                profile_form profile = new profile_form(which_user.Text);
                this.Visible = false;
                profile.Visible = true;
            }
            else
            {
                MessageBox.Show("Please Check Your Internet Connection", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void Change_password_btn_Click(object sender, EventArgs e)
        {
            if (CheckInternet())
            {
                password_change_form pw_change = new password_change_form(which_user.Text);
                this.Visible = false;
                pw_change.Visible = true;
            }
            else
            {
                MessageBox.Show("Please Check Your Internet Connection", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        //public string mysqlstring = "SERVER='remotemysql.com';PORT='3306';DATABASE='ADaIimiPVx';UID='ADaIimiPVx';PASSWORD='pdo921PEWJ';";
        //private async void Group_chat_btn_Click(object sender, EventArgs e)
        //{
        //    MySqlConnection con = new MySqlConnection(mysqlstring);
        //    try
        //    {
        //        con.Open();

        //        MessageBox.Show("successful connection");

        //        con.Close();
        //    }
        //    catch (MySqlException ex)
        //    {
        //        MessageBox.Show(ex.Message);
        //    }
        //}

        //public string mysqlstring = "SERVER='remotemysql.com';PORT='3306';DATABASE='ADaIimiPVx';UID='ADaIimiPVx';PASSWORD='pdo921PEWJ';";
        private void Group_chat_btn_Click(object sender, EventArgs e)
        {
            PopulateGroupChat();
        }

        private async void Search_btn_Click(object sender, EventArgs e)
        {
            try
            {
                FirebaseResponse response = await client.GetTaskAsync("Us/" + search_input.Text);
                ChatList list = response.ResultAs<ChatList>();

                //chat_list.Items.Add(list.Name);

                if (list.Name != null)
                {
                    if (chat_list.Items.Contains(list.Name))
                    {
                        chat_list.SelectedItem = list.Name;
                    }
                    else
                    {
                        chat_list.Items.Add(list.Name);
                    }
                }
            }catch(Exception search)
            {
                MessageBox.Show("User Not Exit", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
            
        }

        private void Send_btn_MouseHover(object sender, EventArgs e)
        {
            send_btn.BackColor = Color.Green;
        }

        private void Send_btn_MouseLeave(object sender, EventArgs e)
        {
            send_btn.BackColor = Color.Silver;
        }

        private void Chat_list_SelectedIndexChanged(object sender, EventArgs e)
        {
            friend_group_name.Text = chat_list.SelectedItem.ToString();
        }

        private void Send_btn_Click(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection(mysqlstring);
            con.Open();
            MySqlCommand comm = con.CreateCommand();
            comm.CommandText = "insert into group_chat(username,name,message) values ('" + which_user.Text.ToString() + "','" + Name_lbl.Text.ToString() + "','" + message_box.Text.ToString() + "')";
            comm.ExecuteNonQuery();

            message_box.Text = "";
            PopulateGroupChat();
        }

        private void PopulateGroupChat()
        {/*
            MySqlConnection con = new MySqlConnection(mysqlstring);
            con.Open();
            MySqlCommand comm = con.CreateCommand();
            comm.CommandText = "select message from group_chat";
            comm.ExecuteNonQuery();

            MySqlDataReader DR1 = comm.ExecuteReader();
            if (DR1.Read())
            {
                chatting_box.Text = DR1.GetValue(0).ToString();

            }*/
            chat_box.Visible = true;
            var select = "select name,message from group_chat";
            var c = new MySqlConnection(mysqlstring); // Your Connection String here
            var dataAdapter = new MySqlDataAdapter(select, c);

            var commandBuilder = new MySqlCommandBuilder(dataAdapter);
            var ds = new DataSet();
            dataAdapter.Fill(ds);
            chat_box.ReadOnly = true;
            chat_box.DataSource = ds.Tables[0];

            this.chat_box.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;


        }
    }
}

class ChatList
{
    public string UserName { get; set; }
    public String Name { get; set; }
}