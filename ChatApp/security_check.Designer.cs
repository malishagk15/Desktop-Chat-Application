namespace ChatApp
{
    partial class security_check
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
            this.label1 = new System.Windows.Forms.Label();
            this.top_lbl = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.next_btn = new System.Windows.Forms.Button();
            this.ques_selection = new System.Windows.Forms.ComboBox();
            this.answer = new System.Windows.Forms.TextBox();
            this.back_btn = new System.Windows.Forms.PictureBox();
            this.min_btn = new System.Windows.Forms.PictureBox();
            this.close_btn = new System.Windows.Forms.PictureBox();
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
            this.label1.TabIndex = 20;
            this.label1.Text = "Security Check";
            // 
            // top_lbl
            // 
            this.top_lbl.BackColor = System.Drawing.Color.DimGray;
            this.top_lbl.Location = new System.Drawing.Point(0, 0);
            this.top_lbl.Name = "top_lbl";
            this.top_lbl.Size = new System.Drawing.Size(900, 32);
            this.top_lbl.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkRed;
            this.label2.Location = new System.Drawing.Point(94, 171);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(630, 20);
            this.label2.TabIndex = 21;
            this.label2.Text = "* Select Question and put the answer for the question when you create the account" +
    ".";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(193, 261);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 20);
            this.label3.TabIndex = 22;
            this.label3.Text = "Question";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(193, 340);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 20);
            this.label4.TabIndex = 23;
            this.label4.Text = "Answer";
            // 
            // next_btn
            // 
            this.next_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.next_btn.Location = new System.Drawing.Point(398, 423);
            this.next_btn.Name = "next_btn";
            this.next_btn.Size = new System.Drawing.Size(91, 34);
            this.next_btn.TabIndex = 24;
            this.next_btn.Text = "Next";
            this.next_btn.UseVisualStyleBackColor = true;
            this.next_btn.Click += new System.EventHandler(this.Next_btn_Click);
            this.next_btn.MouseLeave += new System.EventHandler(this.Next_btn_MouseLeave);
            this.next_btn.MouseHover += new System.EventHandler(this.Next_btn_MouseHover);
            // 
            // ques_selection
            // 
            this.ques_selection.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ques_selection.FormattingEnabled = true;
            this.ques_selection.Items.AddRange(new object[] {
            "What is your girlfriend name?",
            "What is your favourite movie name?",
            "What is your childhood nickname?",
            "What is your favourite place name?",
            "What is your first class teacher name?"});
            this.ques_selection.Location = new System.Drawing.Point(374, 257);
            this.ques_selection.Name = "ques_selection";
            this.ques_selection.Size = new System.Drawing.Size(301, 24);
            this.ques_selection.TabIndex = 25;
            // 
            // answer
            // 
            this.answer.Location = new System.Drawing.Point(374, 337);
            this.answer.Name = "answer";
            this.answer.Size = new System.Drawing.Size(301, 22);
            this.answer.TabIndex = 26;
            // 
            // back_btn
            // 
            this.back_btn.BackColor = System.Drawing.Color.Transparent;
            this.back_btn.BackgroundImage = global::ChatApp.Properties.Resources.back_btn2;
            this.back_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.back_btn.Location = new System.Drawing.Point(0, 0);
            this.back_btn.Name = "back_btn";
            this.back_btn.Size = new System.Drawing.Size(32, 32);
            this.back_btn.TabIndex = 19;
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
            this.min_btn.TabIndex = 17;
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
            this.close_btn.TabIndex = 16;
            this.close_btn.TabStop = false;
            this.close_btn.Click += new System.EventHandler(this.Close_btn_Click);
            this.close_btn.MouseLeave += new System.EventHandler(this.Close_btn_MouseLeave);
            this.close_btn.MouseHover += new System.EventHandler(this.Close_btn_MouseHover);
            // 
            // username
            // 
            this.username.Location = new System.Drawing.Point(374, 208);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(301, 22);
            this.username.TabIndex = 27;
            this.username.Visible = false;
            // 
            // security_check
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(900, 620);
            this.Controls.Add(this.username);
            this.Controls.Add(this.answer);
            this.Controls.Add(this.ques_selection);
            this.Controls.Add(this.next_btn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.back_btn);
            this.Controls.Add(this.min_btn);
            this.Controls.Add(this.close_btn);
            this.Controls.Add(this.top_lbl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "security_check";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "security_check";
            this.Load += new System.EventHandler(this.Security_check_Load);
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
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button next_btn;
        private System.Windows.Forms.ComboBox ques_selection;
        private System.Windows.Forms.TextBox answer;
        private System.Windows.Forms.TextBox username;
    }
}