namespace ChatApp
{
    partial class profile_form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(profile_form));
            this.profie_panel = new System.Windows.Forms.Panel();
            this.which_user = new System.Windows.Forms.Label();
            this.Name_lbl = new System.Windows.Forms.Label();
            this.profile_pic = new System.Windows.Forms.PictureBox();
            this.logout_btn = new System.Windows.Forms.Button();
            this.change_password_btn = new System.Windows.Forms.Button();
            this.home_btn = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.top_lbl = new System.Windows.Forms.Label();
            this.minimize_btn = new System.Windows.Forms.PictureBox();
            this.upload_profile = new System.Windows.Forms.PictureBox();
            this.upload_profie_btn = new System.Windows.Forms.Button();
            this.user_name = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.phone_no = new System.Windows.Forms.TextBox();
            this.email_address = new System.Windows.Forms.TextBox();
            this.name = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.edit_profile_btn = new System.Windows.Forms.Button();
            this.update_btn = new System.Windows.Forms.Button();
            this.cancel_btn = new System.Windows.Forms.Button();
            this.profie_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.profile_pic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minimize_btn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.upload_profile)).BeginInit();
            this.SuspendLayout();
            // 
            // profie_panel
            // 
            this.profie_panel.Controls.Add(this.which_user);
            this.profie_panel.Controls.Add(this.Name_lbl);
            this.profie_panel.Controls.Add(this.profile_pic);
            this.profie_panel.Controls.Add(this.logout_btn);
            this.profie_panel.Controls.Add(this.change_password_btn);
            this.profie_panel.Controls.Add(this.home_btn);
            this.profie_panel.Controls.Add(this.panel2);
            this.profie_panel.Location = new System.Drawing.Point(2, 35);
            this.profie_panel.Name = "profie_panel";
            this.profie_panel.Size = new System.Drawing.Size(298, 645);
            this.profie_panel.TabIndex = 41;
            // 
            // which_user
            // 
            this.which_user.Location = new System.Drawing.Point(37, 8);
            this.which_user.Name = "which_user";
            this.which_user.Size = new System.Drawing.Size(228, 23);
            this.which_user.TabIndex = 41;
            // 
            // Name_lbl
            // 
            this.Name_lbl.Location = new System.Drawing.Point(40, 299);
            this.Name_lbl.Name = "Name_lbl";
            this.Name_lbl.Size = new System.Drawing.Size(227, 37);
            this.Name_lbl.TabIndex = 40;
            // 
            // profile_pic
            // 
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
            // home_btn
            // 
            this.home_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.home_btn.Location = new System.Drawing.Point(37, 359);
            this.home_btn.Name = "home_btn";
            this.home_btn.Size = new System.Drawing.Size(228, 38);
            this.home_btn.TabIndex = 34;
            this.home_btn.Text = "Home";
            this.home_btn.UseVisualStyleBackColor = true;
            this.home_btn.Click += new System.EventHandler(this.Home_btn_Click);
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(304, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(372, 642);
            this.panel2.TabIndex = 33;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.DimGray;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(573, 1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(180, 31);
            this.label1.TabIndex = 40;
            this.label1.Text = "Profile Name";
            // 
            // top_lbl
            // 
            this.top_lbl.BackColor = System.Drawing.Color.DimGray;
            this.top_lbl.Location = new System.Drawing.Point(-349, 0);
            this.top_lbl.Name = "top_lbl";
            this.top_lbl.Size = new System.Drawing.Size(1943, 32);
            this.top_lbl.TabIndex = 39;
            // 
            // minimize_btn
            // 
            this.minimize_btn.BackColor = System.Drawing.Color.Transparent;
            this.minimize_btn.BackgroundImage = global::ChatApp.Properties.Resources.minimize_btn;
            this.minimize_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.minimize_btn.Location = new System.Drawing.Point(1212, 0);
            this.minimize_btn.Name = "minimize_btn";
            this.minimize_btn.Size = new System.Drawing.Size(32, 32);
            this.minimize_btn.TabIndex = 42;
            this.minimize_btn.TabStop = false;
            // 
            // upload_profile
            // 
            this.upload_profile.Location = new System.Drawing.Point(334, 211);
            this.upload_profile.Name = "upload_profile";
            this.upload_profile.Size = new System.Drawing.Size(230, 230);
            this.upload_profile.TabIndex = 41;
            this.upload_profile.TabStop = false;
            // 
            // upload_profie_btn
            // 
            this.upload_profie_btn.Location = new System.Drawing.Point(334, 496);
            this.upload_profie_btn.Name = "upload_profie_btn";
            this.upload_profie_btn.Size = new System.Drawing.Size(230, 38);
            this.upload_profie_btn.TabIndex = 43;
            this.upload_profie_btn.Text = "Upload Profile";
            this.upload_profie_btn.UseVisualStyleBackColor = true;
            this.upload_profie_btn.Click += new System.EventHandler(this.Upload_profie_btn_Click);
            // 
            // user_name
            // 
            this.user_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.user_name.Location = new System.Drawing.Point(813, 294);
            this.user_name.Name = "user_name";
            this.user_name.Size = new System.Drawing.Size(346, 28);
            this.user_name.TabIndex = 59;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(634, 294);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(105, 24);
            this.label20.TabIndex = 58;
            this.label20.Text = "User Name";
            // 
            // phone_no
            // 
            this.phone_no.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phone_no.Location = new System.Drawing.Point(812, 390);
            this.phone_no.Name = "phone_no";
            this.phone_no.Size = new System.Drawing.Size(346, 28);
            this.phone_no.TabIndex = 53;
            // 
            // email_address
            // 
            this.email_address.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.email_address.Location = new System.Drawing.Point(813, 338);
            this.email_address.Name = "email_address";
            this.email_address.Size = new System.Drawing.Size(346, 28);
            this.email_address.TabIndex = 52;
            // 
            // name
            // 
            this.name.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name.Location = new System.Drawing.Point(813, 251);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(346, 28);
            this.name.TabIndex = 51;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(633, 390);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(140, 24);
            this.label4.TabIndex = 46;
            this.label4.Text = "Phone Number";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(633, 341);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 24);
            this.label3.TabIndex = 45;
            this.label3.Text = "Email Address";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(633, 251);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 24);
            this.label2.TabIndex = 44;
            this.label2.Text = "Name";
            // 
            // edit_profile_btn
            // 
            this.edit_profile_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edit_profile_btn.Location = new System.Drawing.Point(822, 495);
            this.edit_profile_btn.Name = "edit_profile_btn";
            this.edit_profile_btn.Size = new System.Drawing.Size(152, 38);
            this.edit_profile_btn.TabIndex = 60;
            this.edit_profile_btn.Text = "Edit Profile";
            this.edit_profile_btn.UseVisualStyleBackColor = true;
            this.edit_profile_btn.Click += new System.EventHandler(this.Edit_profile_btn_Click);
            // 
            // update_btn
            // 
            this.update_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.update_btn.Location = new System.Drawing.Point(1006, 496);
            this.update_btn.Name = "update_btn";
            this.update_btn.Size = new System.Drawing.Size(152, 38);
            this.update_btn.TabIndex = 61;
            this.update_btn.Text = "Update";
            this.update_btn.UseVisualStyleBackColor = true;
            this.update_btn.Click += new System.EventHandler(this.Update_btn_Click);
            // 
            // cancel_btn
            // 
            this.cancel_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancel_btn.Location = new System.Drawing.Point(637, 495);
            this.cancel_btn.Name = "cancel_btn";
            this.cancel_btn.Size = new System.Drawing.Size(152, 38);
            this.cancel_btn.TabIndex = 62;
            this.cancel_btn.Text = "Cancel";
            this.cancel_btn.UseVisualStyleBackColor = true;
            this.cancel_btn.Click += new System.EventHandler(this.Cancel_btn_Click);
            // 
            // profile_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1244, 681);
            this.Controls.Add(this.cancel_btn);
            this.Controls.Add(this.update_btn);
            this.Controls.Add(this.edit_profile_btn);
            this.Controls.Add(this.user_name);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.phone_no);
            this.Controls.Add(this.email_address);
            this.Controls.Add(this.name);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.upload_profie_btn);
            this.Controls.Add(this.upload_profile);
            this.Controls.Add(this.minimize_btn);
            this.Controls.Add(this.profie_panel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.top_lbl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "profile_form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "profile_form";
            this.Load += new System.EventHandler(this.Profile_form_Load);
            this.profie_panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.profile_pic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minimize_btn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.upload_profile)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel profie_panel;
        private System.Windows.Forms.PictureBox profile_pic;
        private System.Windows.Forms.Button logout_btn;
        private System.Windows.Forms.Button change_password_btn;
        private System.Windows.Forms.Button home_btn;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label top_lbl;
        private System.Windows.Forms.PictureBox minimize_btn;
        private System.Windows.Forms.Label Name_lbl;
        private System.Windows.Forms.PictureBox upload_profile;
        private System.Windows.Forms.Button upload_profie_btn;
        private System.Windows.Forms.TextBox user_name;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox phone_no;
        private System.Windows.Forms.TextBox email_address;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button edit_profile_btn;
        private System.Windows.Forms.Button update_btn;
        private System.Windows.Forms.Label which_user;
        private System.Windows.Forms.Button cancel_btn;
    }
}