namespace ChatApp
{
    partial class home_form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(home_form));
            this.label1 = new System.Windows.Forms.Label();
            this.top_lbl = new System.Windows.Forms.Label();
            this.profie_panel = new System.Windows.Forms.Panel();
            this.Name_lbl = new System.Windows.Forms.Label();
            this.which_user = new System.Windows.Forms.Label();
            this.profile_pic = new System.Windows.Forms.PictureBox();
            this.logout_btn = new System.Windows.Forms.Button();
            this.change_password_btn = new System.Windows.Forms.Button();
            this.profile_btn = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pc_gc_panel = new System.Windows.Forms.Panel();
            this.search_btn = new System.Windows.Forms.Button();
            this.search_input = new System.Windows.Forms.TextBox();
            this.chat_list = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.group_chat_btn = new System.Windows.Forms.Button();
            this.chat_panel = new System.Windows.Forms.Panel();
            this.chat_box = new System.Windows.Forms.DataGridView();
            this.send_btn = new System.Windows.Forms.PictureBox();
            this.friend_group_name = new System.Windows.Forms.Label();
            this.message_box = new System.Windows.Forms.RichTextBox();
            this.chatting_box = new System.Windows.Forms.RichTextBox();
            this.minimize_btn = new System.Windows.Forms.PictureBox();
            this.min_btn = new System.Windows.Forms.PictureBox();
            this.chat_logo = new System.Windows.Forms.PictureBox();
            this.profie_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.profile_pic)).BeginInit();
            this.pc_gc_panel.SuspendLayout();
            this.chat_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chat_box)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.send_btn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minimize_btn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.min_btn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chat_logo)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.DimGray;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(573, 1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(180, 31);
            this.label1.TabIndex = 30;
            this.label1.Text = "UOK Chat";
            // 
            // top_lbl
            // 
            this.top_lbl.BackColor = System.Drawing.Color.DimGray;
            this.top_lbl.Location = new System.Drawing.Point(-421, 0);
            this.top_lbl.Name = "top_lbl";
            this.top_lbl.Size = new System.Drawing.Size(1943, 32);
            this.top_lbl.TabIndex = 28;
            // 
            // profie_panel
            // 
            this.profie_panel.Controls.Add(this.Name_lbl);
            this.profie_panel.Controls.Add(this.which_user);
            this.profie_panel.Controls.Add(this.profile_pic);
            this.profie_panel.Controls.Add(this.logout_btn);
            this.profie_panel.Controls.Add(this.change_password_btn);
            this.profie_panel.Controls.Add(this.profile_btn);
            this.profie_panel.Controls.Add(this.panel2);
            this.profie_panel.Location = new System.Drawing.Point(2, 35);
            this.profie_panel.Name = "profie_panel";
            this.profie_panel.Size = new System.Drawing.Size(298, 645);
            this.profie_panel.TabIndex = 32;
            // 
            // Name_lbl
            // 
            this.Name_lbl.Location = new System.Drawing.Point(40, 299);
            this.Name_lbl.Name = "Name_lbl";
            this.Name_lbl.Size = new System.Drawing.Size(227, 37);
            this.Name_lbl.TabIndex = 39;
            // 
            // which_user
            // 
            this.which_user.Location = new System.Drawing.Point(37, 14);
            this.which_user.Name = "which_user";
            this.which_user.Size = new System.Drawing.Size(228, 23);
            this.which_user.TabIndex = 38;
            // 
            // profile_pic
            // 
            this.profile_pic.BackgroundImage = global::ChatApp.Properties.Resources.profile;
            this.profile_pic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.profile_pic.Location = new System.Drawing.Point(37, 37);
            this.profile_pic.Name = "profile_pic";
            this.profile_pic.Size = new System.Drawing.Size(230, 230);
            this.profile_pic.TabIndex = 37;
            this.profile_pic.TabStop = false;
            // 
            // logout_btn
            // 
            this.logout_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logout_btn.Location = new System.Drawing.Point(37, 573);
            this.logout_btn.Name = "logout_btn";
            this.logout_btn.Size = new System.Drawing.Size(228, 37);
            this.logout_btn.TabIndex = 36;
            this.logout_btn.Text = "Logout";
            this.logout_btn.UseVisualStyleBackColor = true;
            this.logout_btn.Click += new System.EventHandler(this.Logout_btn_Click);
            // 
            // change_password_btn
            // 
            this.change_password_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.change_password_btn.Location = new System.Drawing.Point(37, 422);
            this.change_password_btn.Name = "change_password_btn";
            this.change_password_btn.Size = new System.Drawing.Size(228, 37);
            this.change_password_btn.TabIndex = 35;
            this.change_password_btn.Text = "Change Password";
            this.change_password_btn.UseVisualStyleBackColor = true;
            this.change_password_btn.Click += new System.EventHandler(this.Change_password_btn_Click);
            // 
            // profile_btn
            // 
            this.profile_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.profile_btn.Location = new System.Drawing.Point(37, 359);
            this.profile_btn.Name = "profile_btn";
            this.profile_btn.Size = new System.Drawing.Size(228, 38);
            this.profile_btn.TabIndex = 34;
            this.profile_btn.Text = "Profile";
            this.profile_btn.UseVisualStyleBackColor = true;
            this.profile_btn.Click += new System.EventHandler(this.Profile_btn_Click);
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(304, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(372, 642);
            this.panel2.TabIndex = 33;
            // 
            // pc_gc_panel
            // 
            this.pc_gc_panel.Controls.Add(this.search_btn);
            this.pc_gc_panel.Controls.Add(this.search_input);
            this.pc_gc_panel.Controls.Add(this.chat_list);
            this.pc_gc_panel.Controls.Add(this.label2);
            this.pc_gc_panel.Controls.Add(this.group_chat_btn);
            this.pc_gc_panel.Location = new System.Drawing.Point(306, 35);
            this.pc_gc_panel.Name = "pc_gc_panel";
            this.pc_gc_panel.Size = new System.Drawing.Size(354, 642);
            this.pc_gc_panel.TabIndex = 33;
            // 
            // search_btn
            // 
            this.search_btn.Location = new System.Drawing.Point(233, 196);
            this.search_btn.Name = "search_btn";
            this.search_btn.Size = new System.Drawing.Size(118, 27);
            this.search_btn.TabIndex = 4;
            this.search_btn.Text = "Search";
            this.search_btn.UseVisualStyleBackColor = true;
            this.search_btn.Click += new System.EventHandler(this.Search_btn_Click);
            // 
            // search_input
            // 
            this.search_input.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.search_input.Location = new System.Drawing.Point(4, 196);
            this.search_input.Name = "search_input";
            this.search_input.Size = new System.Drawing.Size(222, 27);
            this.search_input.TabIndex = 3;
            // 
            // chat_list
            // 
            this.chat_list.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chat_list.FormattingEnabled = true;
            this.chat_list.ItemHeight = 25;
            this.chat_list.Location = new System.Drawing.Point(3, 257);
            this.chat_list.Name = "chat_list";
            this.chat_list.Size = new System.Drawing.Size(348, 379);
            this.chat_list.TabIndex = 2;
            this.chat_list.SelectedIndexChanged += new System.EventHandler(this.Chat_list_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Blue;
            this.label2.Location = new System.Drawing.Point(3, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(348, 63);
            this.label2.TabIndex = 1;
            this.label2.Text = "Private Chats";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // group_chat_btn
            // 
            this.group_chat_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.group_chat_btn.Location = new System.Drawing.Point(3, 35);
            this.group_chat_btn.Name = "group_chat_btn";
            this.group_chat_btn.Size = new System.Drawing.Size(348, 84);
            this.group_chat_btn.TabIndex = 0;
            this.group_chat_btn.Text = "Group Chat";
            this.group_chat_btn.UseVisualStyleBackColor = true;
            this.group_chat_btn.Click += new System.EventHandler(this.Group_chat_btn_Click);
            // 
            // chat_panel
            // 
            this.chat_panel.Controls.Add(this.chat_box);
            this.chat_panel.Controls.Add(this.chat_logo);
            this.chat_panel.Controls.Add(this.send_btn);
            this.chat_panel.Controls.Add(this.friend_group_name);
            this.chat_panel.Controls.Add(this.message_box);
            this.chat_panel.Controls.Add(this.chatting_box);
            this.chat_panel.Location = new System.Drawing.Point(667, 35);
            this.chat_panel.Name = "chat_panel";
            this.chat_panel.Size = new System.Drawing.Size(577, 642);
            this.chat_panel.TabIndex = 34;
            // 
            // chat_box
            // 
            this.chat_box.BackgroundColor = System.Drawing.SystemColors.Control;
            this.chat_box.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.chat_box.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.chat_box.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.chat_box.ColumnHeadersHeight = 29;
            this.chat_box.ColumnHeadersVisible = false;
            this.chat_box.Enabled = false;
            this.chat_box.Location = new System.Drawing.Point(6, 37);
            this.chat_box.MultiSelect = false;
            this.chat_box.Name = "chat_box";
            this.chat_box.ReadOnly = true;
            this.chat_box.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.chat_box.RowHeadersVisible = false;
            this.chat_box.RowHeadersWidth = 51;
            this.chat_box.RowTemplate.Height = 24;
            this.chat_box.Size = new System.Drawing.Size(570, 518);
            this.chat_box.TabIndex = 5;
            // 
            // send_btn
            // 
            this.send_btn.BackgroundImage = global::ChatApp.Properties.Resources.send_btn;
            this.send_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.send_btn.Location = new System.Drawing.Point(497, 559);
            this.send_btn.Name = "send_btn";
            this.send_btn.Size = new System.Drawing.Size(77, 75);
            this.send_btn.TabIndex = 4;
            this.send_btn.TabStop = false;
            this.send_btn.Click += new System.EventHandler(this.Send_btn_Click);
            this.send_btn.MouseLeave += new System.EventHandler(this.Send_btn_MouseLeave);
            this.send_btn.MouseHover += new System.EventHandler(this.Send_btn_MouseHover);
            // 
            // friend_group_name
            // 
            this.friend_group_name.Location = new System.Drawing.Point(181, 3);
            this.friend_group_name.Name = "friend_group_name";
            this.friend_group_name.Size = new System.Drawing.Size(167, 29);
            this.friend_group_name.TabIndex = 3;
            this.friend_group_name.Text = "UOK Chat";
            this.friend_group_name.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // message_box
            // 
            this.message_box.Location = new System.Drawing.Point(4, 559);
            this.message_box.Name = "message_box";
            this.message_box.Size = new System.Drawing.Size(487, 75);
            this.message_box.TabIndex = 1;
            this.message_box.Text = "";
            // 
            // chatting_box
            // 
            this.chatting_box.Location = new System.Drawing.Point(4, 35);
            this.chatting_box.Name = "chatting_box";
            this.chatting_box.Size = new System.Drawing.Size(570, 504);
            this.chatting_box.TabIndex = 0;
            this.chatting_box.Text = "";
            this.chatting_box.Visible = false;
            // 
            // minimize_btn
            // 
            this.minimize_btn.BackColor = System.Drawing.Color.Transparent;
            this.minimize_btn.BackgroundImage = global::ChatApp.Properties.Resources.minimize_btn;
            this.minimize_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.minimize_btn.Location = new System.Drawing.Point(1212, 0);
            this.minimize_btn.Name = "minimize_btn";
            this.minimize_btn.Size = new System.Drawing.Size(32, 32);
            this.minimize_btn.TabIndex = 31;
            this.minimize_btn.TabStop = false;
            this.minimize_btn.Click += new System.EventHandler(this.Minimize_btn_Click);
            this.minimize_btn.MouseLeave += new System.EventHandler(this.Minimize_btn_MouseLeave);
            this.minimize_btn.MouseHover += new System.EventHandler(this.Minimize_btn_MouseHover);
            // 
            // min_btn
            // 
            this.min_btn.BackColor = System.Drawing.Color.Transparent;
            this.min_btn.BackgroundImage = global::ChatApp.Properties.Resources.minimize_btn;
            this.min_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.min_btn.Location = new System.Drawing.Point(1910, 0);
            this.min_btn.Name = "min_btn";
            this.min_btn.Size = new System.Drawing.Size(32, 32);
            this.min_btn.TabIndex = 27;
            this.min_btn.TabStop = false;
            // 
            // chat_logo
            // 
            this.chat_logo.BackgroundImage = global::ChatApp.Properties.Resources.icon;
            this.chat_logo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.chat_logo.Location = new System.Drawing.Point(4, 37);
            this.chat_logo.Name = "chat_logo";
            this.chat_logo.Size = new System.Drawing.Size(589, 502);
            this.chat_logo.TabIndex = 5;
            this.chat_logo.TabStop = false;
            // 
            // home_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1244, 681);
            this.Controls.Add(this.chat_panel);
            this.Controls.Add(this.pc_gc_panel);
            this.Controls.Add(this.profie_panel);
            this.Controls.Add(this.minimize_btn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.min_btn);
            this.Controls.Add(this.top_lbl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "home_form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "home_form";
            this.Load += new System.EventHandler(this.Home_form_Load);
            this.profie_panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.profile_pic)).EndInit();
            this.pc_gc_panel.ResumeLayout(false);
            this.pc_gc_panel.PerformLayout();
            this.chat_panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chat_box)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.send_btn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minimize_btn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.min_btn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chat_logo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox min_btn;
        private System.Windows.Forms.Label top_lbl;
        private System.Windows.Forms.PictureBox minimize_btn;
        private System.Windows.Forms.Panel profie_panel;
        private System.Windows.Forms.PictureBox profile_pic;
        private System.Windows.Forms.Button logout_btn;
        private System.Windows.Forms.Button change_password_btn;
        private System.Windows.Forms.Button profile_btn;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel pc_gc_panel;
        private System.Windows.Forms.Panel chat_panel;
        private System.Windows.Forms.Label which_user;
        private System.Windows.Forms.Label Name_lbl;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button group_chat_btn;
        private System.Windows.Forms.ListBox chat_list;
        private System.Windows.Forms.Button search_btn;
        private System.Windows.Forms.TextBox search_input;
        private System.Windows.Forms.RichTextBox message_box;
        private System.Windows.Forms.RichTextBox chatting_box;
        private System.Windows.Forms.Label friend_group_name;
        private System.Windows.Forms.PictureBox send_btn;
        private System.Windows.Forms.DataGridView chat_box;
        private System.Windows.Forms.PictureBox chat_logo;
    }
}