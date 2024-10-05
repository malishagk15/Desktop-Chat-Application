namespace ChatApp
{
    partial class login_form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(login_form));
            this.top_lbl = new System.Windows.Forms.Label();
            this.login_btn = new System.Windows.Forms.Button();
            this.email_id = new System.Windows.Forms.TextBox();
            this.password = new System.Windows.Forms.TextBox();
            this.forget_password = new System.Windows.Forms.LinkLabel();
            this.register_btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.min_btn = new System.Windows.Forms.PictureBox();
            this.close_btn = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.user_name = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.min_btn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.close_btn)).BeginInit();
            this.SuspendLayout();
            // 
            // top_lbl
            // 
            this.top_lbl.BackColor = System.Drawing.Color.DimGray;
            this.top_lbl.Location = new System.Drawing.Point(0, 0);
            this.top_lbl.Name = "top_lbl";
            this.top_lbl.Size = new System.Drawing.Size(900, 32);
            this.top_lbl.TabIndex = 5;
            // 
            // login_btn
            // 
            this.login_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login_btn.Location = new System.Drawing.Point(403, 441);
            this.login_btn.Name = "login_btn";
            this.login_btn.Size = new System.Drawing.Size(96, 31);
            this.login_btn.TabIndex = 6;
            this.login_btn.Text = "Login";
            this.login_btn.UseVisualStyleBackColor = true;
            this.login_btn.Click += new System.EventHandler(this.Login_Click);
            this.login_btn.MouseLeave += new System.EventHandler(this.Login_btn_MouseLeave);
            this.login_btn.MouseHover += new System.EventHandler(this.Login_btn_MouseHover);
            // 
            // email_id
            // 
            this.email_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.email_id.Location = new System.Drawing.Point(403, 347);
            this.email_id.Name = "email_id";
            this.email_id.Size = new System.Drawing.Size(282, 27);
            this.email_id.TabIndex = 7;
            this.email_id.Visible = false;
            this.email_id.TextChanged += new System.EventHandler(this.Email_id_TextChanged);
            this.email_id.Enter += new System.EventHandler(this.Email_id_Enter);
            this.email_id.Leave += new System.EventHandler(this.Email_id_Leave);
            // 
            // password
            // 
            this.password.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password.Location = new System.Drawing.Point(403, 390);
            this.password.Name = "password";
            this.password.PasswordChar = '*';
            this.password.Size = new System.Drawing.Size(282, 27);
            this.password.TabIndex = 8;
            this.password.Enter += new System.EventHandler(this.Password_Enter);
            this.password.Leave += new System.EventHandler(this.Password_Leave);
            // 
            // forget_password
            // 
            this.forget_password.AutoSize = true;
            this.forget_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.forget_password.Location = new System.Drawing.Point(488, 486);
            this.forget_password.Name = "forget_password";
            this.forget_password.Size = new System.Drawing.Size(129, 20);
            this.forget_password.TabIndex = 9;
            this.forget_password.TabStop = true;
            this.forget_password.Text = "forget password";
            this.forget_password.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Forget_password_LinkClicked);
            // 
            // register_btn
            // 
            this.register_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.register_btn.Location = new System.Drawing.Point(370, 519);
            this.register_btn.Name = "register_btn";
            this.register_btn.Size = new System.Drawing.Size(169, 32);
            this.register_btn.TabIndex = 10;
            this.register_btn.Text = "Register";
            this.register_btn.UseVisualStyleBackColor = true;
            this.register_btn.Click += new System.EventHandler(this.Register_btn_Click);
            this.register_btn.MouseLeave += new System.EventHandler(this.Register_btn_MouseLeave);
            this.register_btn.MouseHover += new System.EventHandler(this.Register_btn_MouseHover);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(399, 274);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 25);
            this.label1.TabIndex = 12;
            this.label1.Text = "UOK Chat";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::ChatApp.Properties.Resources.icon;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(315, 65);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(282, 224);
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // min_btn
            // 
            this.min_btn.BackColor = System.Drawing.Color.Transparent;
            this.min_btn.BackgroundImage = global::ChatApp.Properties.Resources.minimize_btn;
            this.min_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.min_btn.Location = new System.Drawing.Point(837, 1);
            this.min_btn.Name = "min_btn";
            this.min_btn.Size = new System.Drawing.Size(32, 32);
            this.min_btn.TabIndex = 4;
            this.min_btn.TabStop = false;
            this.min_btn.Click += new System.EventHandler(this.Min_btn_Click);
            this.min_btn.MouseLeave += new System.EventHandler(this.Min_btn_MouseLeave);
            this.min_btn.MouseHover += new System.EventHandler(this.Min_btn_MouseHover);
            // 
            // close_btn
            // 
            this.close_btn.BackColor = System.Drawing.Color.Transparent;
            this.close_btn.BackgroundImage = global::ChatApp.Properties.Resources.close_btn;
            this.close_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.close_btn.Location = new System.Drawing.Point(869, 1);
            this.close_btn.Name = "close_btn";
            this.close_btn.Size = new System.Drawing.Size(32, 32);
            this.close_btn.TabIndex = 3;
            this.close_btn.TabStop = false;
            this.close_btn.Click += new System.EventHandler(this.Close_btn_Click);
            this.close_btn.MouseLeave += new System.EventHandler(this.Close_btn_MouseLeave);
            this.close_btn.MouseHover += new System.EventHandler(this.Close_btn_MouseHover);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(232, 349);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 24);
            this.label2.TabIndex = 13;
            this.label2.Text = "User Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(232, 392);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 24);
            this.label3.TabIndex = 14;
            this.label3.Text = "Password";
            // 
            // user_name
            // 
            this.user_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.user_name.Location = new System.Drawing.Point(403, 346);
            this.user_name.Name = "user_name";
            this.user_name.Size = new System.Drawing.Size(282, 27);
            this.user_name.TabIndex = 15;
            this.user_name.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.User_name_KeyPress);
            // 
            // login_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(900, 620);
            this.Controls.Add(this.user_name);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.register_btn);
            this.Controls.Add(this.forget_password);
            this.Controls.Add(this.password);
            this.Controls.Add(this.email_id);
            this.Controls.Add(this.login_btn);
            this.Controls.Add(this.min_btn);
            this.Controls.Add(this.close_btn);
            this.Controls.Add(this.top_lbl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "login_form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "login_form";
            this.Load += new System.EventHandler(this.Login_form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.min_btn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.close_btn)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox min_btn;
        private System.Windows.Forms.PictureBox close_btn;
        private System.Windows.Forms.Label top_lbl;
        private System.Windows.Forms.Button login_btn;
        private System.Windows.Forms.TextBox email_id;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.LinkLabel forget_password;
        private System.Windows.Forms.Button register_btn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox user_name;
    }
}