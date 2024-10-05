namespace ChatApp
{
    partial class forget_pass_form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(forget_pass_form));
            this.label1 = new System.Windows.Forms.Label();
            this.top_lbl = new System.Windows.Forms.Label();
            this.email_id = new System.Windows.Forms.TextBox();
            this.search_btn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.back_btn = new System.Windows.Forms.PictureBox();
            this.min_btn = new System.Windows.Forms.PictureBox();
            this.close_btn = new System.Windows.Forms.PictureBox();
            this.user_name = new System.Windows.Forms.TextBox();
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
            this.label1.TabIndex = 15;
            this.label1.Text = "Forget Password";
            // 
            // top_lbl
            // 
            this.top_lbl.BackColor = System.Drawing.Color.DimGray;
            this.top_lbl.Location = new System.Drawing.Point(0, 0);
            this.top_lbl.Name = "top_lbl";
            this.top_lbl.Size = new System.Drawing.Size(900, 32);
            this.top_lbl.TabIndex = 13;
            // 
            // email_id
            // 
            this.email_id.Enabled = false;
            this.email_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.email_id.Location = new System.Drawing.Point(307, 309);
            this.email_id.Name = "email_id";
            this.email_id.Size = new System.Drawing.Size(313, 30);
            this.email_id.TabIndex = 17;
            this.email_id.Visible = false;
            this.email_id.TextChanged += new System.EventHandler(this.Email_id_TextChanged);
            this.email_id.Enter += new System.EventHandler(this.Email_id_Enter);
            this.email_id.Leave += new System.EventHandler(this.Email_id_Leave);
            // 
            // search_btn
            // 
            this.search_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.search_btn.Location = new System.Drawing.Point(401, 352);
            this.search_btn.Name = "search_btn";
            this.search_btn.Size = new System.Drawing.Size(117, 37);
            this.search_btn.TabIndex = 18;
            this.search_btn.Text = "Search";
            this.search_btn.UseVisualStyleBackColor = true;
            this.search_btn.Click += new System.EventHandler(this.Search_btn_Click);
            this.search_btn.MouseLeave += new System.EventHandler(this.Search_btn_MouseLeave);
            this.search_btn.MouseHover += new System.EventHandler(this.Search_btn_MouseHover);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(385, 272);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 24);
            this.label2.TabIndex = 19;
            this.label2.Text = "Enter Username";
            // 
            // back_btn
            // 
            this.back_btn.BackColor = System.Drawing.Color.Transparent;
            this.back_btn.BackgroundImage = global::ChatApp.Properties.Resources.back_btn2;
            this.back_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.back_btn.Location = new System.Drawing.Point(0, 0);
            this.back_btn.Name = "back_btn";
            this.back_btn.Size = new System.Drawing.Size(32, 32);
            this.back_btn.TabIndex = 14;
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
            this.min_btn.TabIndex = 12;
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
            this.close_btn.TabIndex = 11;
            this.close_btn.TabStop = false;
            this.close_btn.Click += new System.EventHandler(this.Close_btn_Click);
            this.close_btn.MouseLeave += new System.EventHandler(this.Close_btn_MouseLeave);
            this.close_btn.MouseHover += new System.EventHandler(this.Close_btn_MouseHover);
            // 
            // user_name
            // 
            this.user_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.user_name.Location = new System.Drawing.Point(307, 309);
            this.user_name.Name = "user_name";
            this.user_name.Size = new System.Drawing.Size(313, 30);
            this.user_name.TabIndex = 20;
            // 
            // forget_pass_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(900, 620);
            this.Controls.Add(this.user_name);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.search_btn);
            this.Controls.Add(this.email_id);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.back_btn);
            this.Controls.Add(this.min_btn);
            this.Controls.Add(this.close_btn);
            this.Controls.Add(this.top_lbl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "forget_pass_form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "forget_pass_form";
            this.Load += new System.EventHandler(this.Forget_pass_form_Load);
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
        private System.Windows.Forms.TextBox email_id;
        private System.Windows.Forms.Button search_btn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox user_name;
    }
}