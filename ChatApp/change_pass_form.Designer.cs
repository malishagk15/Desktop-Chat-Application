namespace ChatApp
{
    partial class change_pass_form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(change_pass_form));
            this.label1 = new System.Windows.Forms.Label();
            this.back_btn = new System.Windows.Forms.PictureBox();
            this.min_btn = new System.Windows.Forms.PictureBox();
            this.close_btn = new System.Windows.Forms.PictureBox();
            this.top_lbl = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.password = new System.Windows.Forms.TextBox();
            this.c_password = new System.Windows.Forms.TextBox();
            this.change_pass_btn = new System.Windows.Forms.Button();
            this.username = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.back_btn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.min_btn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.close_btn)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.DimGray;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(369, 1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(180, 31);
            this.label1.TabIndex = 25;
            this.label1.Text = "Change Password";
            // 
            // back_btn
            // 
            this.back_btn.BackColor = System.Drawing.Color.Transparent;
            this.back_btn.BackgroundImage = global::ChatApp.Properties.Resources.back_btn2;
            this.back_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.back_btn.Location = new System.Drawing.Point(0, 0);
            this.back_btn.Name = "back_btn";
            this.back_btn.Size = new System.Drawing.Size(32, 32);
            this.back_btn.TabIndex = 24;
            this.back_btn.TabStop = false;
            this.back_btn.Click += new System.EventHandler(this.Back_btn_Click);
            this.back_btn.MouseLeave += new System.EventHandler(this.Back_btn_MouseLeave);
            this.back_btn.MouseHover += new System.EventHandler(this.Back_btn_MouseHover);
            // 
            // min_btn
            // 
            this.min_btn.BackColor = System.Drawing.Color.Transparent;
            this.min_btn.BackgroundImage = global::ChatApp.Properties.Resources.minimize_btn;
            this.min_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.min_btn.Location = new System.Drawing.Point(837, 0);
            this.min_btn.Name = "min_btn";
            this.min_btn.Size = new System.Drawing.Size(32, 32);
            this.min_btn.TabIndex = 22;
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
            this.close_btn.Location = new System.Drawing.Point(869, 0);
            this.close_btn.Name = "close_btn";
            this.close_btn.Size = new System.Drawing.Size(32, 32);
            this.close_btn.TabIndex = 21;
            this.close_btn.TabStop = false;
            this.close_btn.Click += new System.EventHandler(this.Close_btn_Click);
            this.close_btn.MouseLeave += new System.EventHandler(this.Close_btn_MouseLeave);
            this.close_btn.MouseHover += new System.EventHandler(this.Close_btn_MouseHover);
            // 
            // top_lbl
            // 
            this.top_lbl.BackColor = System.Drawing.Color.DimGray;
            this.top_lbl.Location = new System.Drawing.Point(0, 0);
            this.top_lbl.Name = "top_lbl";
            this.top_lbl.Size = new System.Drawing.Size(900, 32);
            this.top_lbl.TabIndex = 23;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(207, 247);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 20);
            this.label2.TabIndex = 26;
            this.label2.Text = "New Password";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(207, 302);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(185, 20);
            this.label3.TabIndex = 27;
            this.label3.Text = "Confirm New Password";
            // 
            // password
            // 
            this.password.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password.Location = new System.Drawing.Point(470, 247);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(236, 27);
            this.password.TabIndex = 28;
            // 
            // c_password
            // 
            this.c_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.c_password.Location = new System.Drawing.Point(470, 302);
            this.c_password.Name = "c_password";
            this.c_password.Size = new System.Drawing.Size(236, 27);
            this.c_password.TabIndex = 29;
            // 
            // change_pass_btn
            // 
            this.change_pass_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.change_pass_btn.Location = new System.Drawing.Point(362, 409);
            this.change_pass_btn.Name = "change_pass_btn";
            this.change_pass_btn.Size = new System.Drawing.Size(169, 35);
            this.change_pass_btn.TabIndex = 30;
            this.change_pass_btn.Text = "Change Password";
            this.change_pass_btn.UseVisualStyleBackColor = true;
            this.change_pass_btn.Click += new System.EventHandler(this.Change_pass_btn_Click);
            this.change_pass_btn.MouseLeave += new System.EventHandler(this.Change_pass_btn_MouseLeave);
            this.change_pass_btn.MouseHover += new System.EventHandler(this.Change_pass_btn_MouseHover);
            // 
            // username
            // 
            this.username.Location = new System.Drawing.Point(470, 192);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(236, 22);
            this.username.TabIndex = 31;
            this.username.Visible = false;
            // 
            // change_pass_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(900, 620);
            this.Controls.Add(this.username);
            this.Controls.Add(this.change_pass_btn);
            this.Controls.Add(this.c_password);
            this.Controls.Add(this.password);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.back_btn);
            this.Controls.Add(this.min_btn);
            this.Controls.Add(this.close_btn);
            this.Controls.Add(this.top_lbl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "change_pass_form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "change_pass_form";
            this.Load += new System.EventHandler(this.Change_pass_form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.back_btn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.min_btn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.close_btn)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox back_btn;
        private System.Windows.Forms.PictureBox min_btn;
        private System.Windows.Forms.PictureBox close_btn;
        private System.Windows.Forms.Label top_lbl;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.TextBox c_password;
        private System.Windows.Forms.Button change_pass_btn;
        private System.Windows.Forms.TextBox username;
    }
}