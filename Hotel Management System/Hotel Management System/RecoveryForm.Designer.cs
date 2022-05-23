
namespace Hotel_Management_System
{
    partial class RecoveryForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RecoveryForm));
            this.label1 = new System.Windows.Forms.Label();
            this.Label_exit = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.Label_entrance = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.Button_recovery = new Guna.UI2.WinForms.Guna2Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.TextBox_checkpassword = new Guna.UI2.WinForms.Guna2TextBox();
            this.TextBox_password = new Guna.UI2.WinForms.Guna2TextBox();
            this.TextBox_username = new Guna.UI2.WinForms.Guna2TextBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.label_checkpassword = new System.Windows.Forms.Label();
            this.label_password = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(55, 164);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(254, 25);
            this.label1.TabIndex = 27;
            this.label1.Text = "Восстановление пароля";
            // 
            // Label_exit
            // 
            this.Label_exit.BackColor = System.Drawing.Color.Transparent;
            this.Label_exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Label_exit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Label_exit.Location = new System.Drawing.Point(330, 0);
            this.Label_exit.Name = "Label_exit";
            this.Label_exit.Size = new System.Drawing.Size(17, 27);
            this.Label_exit.TabIndex = 26;
            this.Label_exit.Text = "Х";
            this.Label_exit.Click += new System.EventHandler(this.Label_exit_Click);
            // 
            // Label_entrance
            // 
            this.Label_entrance.BackColor = System.Drawing.Color.Transparent;
            this.Label_entrance.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Label_entrance.ForeColor = System.Drawing.Color.White;
            this.Label_entrance.Location = new System.Drawing.Point(43, 533);
            this.Label_entrance.Name = "Label_entrance";
            this.Label_entrance.Size = new System.Drawing.Size(258, 27);
            this.Label_entrance.TabIndex = 25;
            this.Label_entrance.Text = "Вернуться к авторизации";
            this.Label_entrance.Click += new System.EventHandler(this.Label_entrance_Click);
            // 
            // Button_recovery
            // 
            this.Button_recovery.CheckedState.Parent = this.Button_recovery;
            this.Button_recovery.CustomImages.Parent = this.Button_recovery;
            this.Button_recovery.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Button_recovery.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Button_recovery.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Button_recovery.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Button_recovery.DisabledState.Parent = this.Button_recovery;
            this.Button_recovery.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Button_recovery.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Button_recovery.ForeColor = System.Drawing.Color.White;
            this.Button_recovery.HoverState.Parent = this.Button_recovery;
            this.Button_recovery.Image = ((System.Drawing.Image)(resources.GetObject("Button_recovery.Image")));
            this.Button_recovery.ImageSize = new System.Drawing.Size(40, 40);
            this.Button_recovery.Location = new System.Drawing.Point(25, 460);
            this.Button_recovery.Name = "Button_recovery";
            this.Button_recovery.ShadowDecoration.Parent = this.Button_recovery;
            this.Button_recovery.Size = new System.Drawing.Size(300, 55);
            this.Button_recovery.TabIndex = 24;
            this.Button_recovery.Text = "Восстановить";
            this.Button_recovery.Click += new System.EventHandler(this.Button_recovery_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.ErrorImage = null;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.InitialImage = null;
            this.pictureBox3.Location = new System.Drawing.Point(25, 368);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(48, 36);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 23;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.ErrorImage = null;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.InitialImage = null;
            this.pictureBox2.Location = new System.Drawing.Point(25, 287);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(48, 36);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 22;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.ErrorImage = null;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(114, 34);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(123, 120);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 21;
            this.pictureBox1.TabStop = false;
            // 
            // TextBox_checkpassword
            // 
            this.TextBox_checkpassword.BorderColor = System.Drawing.Color.Black;
            this.TextBox_checkpassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBox_checkpassword.DefaultText = "";
            this.TextBox_checkpassword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TextBox_checkpassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TextBox_checkpassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBox_checkpassword.DisabledState.Parent = this.TextBox_checkpassword;
            this.TextBox_checkpassword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBox_checkpassword.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBox_checkpassword.FocusedState.Parent = this.TextBox_checkpassword;
            this.TextBox_checkpassword.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TextBox_checkpassword.ForeColor = System.Drawing.Color.Black;
            this.TextBox_checkpassword.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBox_checkpassword.HoverState.Parent = this.TextBox_checkpassword;
            this.TextBox_checkpassword.Location = new System.Drawing.Point(89, 287);
            this.TextBox_checkpassword.Name = "TextBox_checkpassword";
            this.TextBox_checkpassword.PasswordChar = '\0';
            this.TextBox_checkpassword.PlaceholderText = "";
            this.TextBox_checkpassword.SelectedText = "";
            this.TextBox_checkpassword.ShadowDecoration.Parent = this.TextBox_checkpassword;
            this.TextBox_checkpassword.Size = new System.Drawing.Size(236, 36);
            this.TextBox_checkpassword.TabIndex = 20;
            this.TextBox_checkpassword.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBox_checkpassword_KeyPress);
            // 
            // TextBox_password
            // 
            this.TextBox_password.BorderColor = System.Drawing.Color.Black;
            this.TextBox_password.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBox_password.DefaultText = "";
            this.TextBox_password.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TextBox_password.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TextBox_password.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBox_password.DisabledState.Parent = this.TextBox_password;
            this.TextBox_password.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBox_password.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBox_password.FocusedState.Parent = this.TextBox_password;
            this.TextBox_password.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TextBox_password.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBox_password.HoverState.Parent = this.TextBox_password;
            this.TextBox_password.Location = new System.Drawing.Point(89, 368);
            this.TextBox_password.Name = "TextBox_password";
            this.TextBox_password.PasswordChar = '\0';
            this.TextBox_password.PlaceholderForeColor = System.Drawing.Color.Black;
            this.TextBox_password.PlaceholderText = "";
            this.TextBox_password.SelectedText = "";
            this.TextBox_password.ShadowDecoration.Parent = this.TextBox_password;
            this.TextBox_password.Size = new System.Drawing.Size(236, 36);
            this.TextBox_password.TabIndex = 19;
            // 
            // TextBox_username
            // 
            this.TextBox_username.BorderColor = System.Drawing.Color.Black;
            this.TextBox_username.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBox_username.DefaultText = "";
            this.TextBox_username.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TextBox_username.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TextBox_username.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBox_username.DisabledState.Parent = this.TextBox_username;
            this.TextBox_username.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBox_username.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBox_username.FocusedState.Parent = this.TextBox_username;
            this.TextBox_username.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TextBox_username.ForeColor = System.Drawing.Color.Black;
            this.TextBox_username.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBox_username.HoverState.Parent = this.TextBox_username;
            this.TextBox_username.Location = new System.Drawing.Point(89, 208);
            this.TextBox_username.Name = "TextBox_username";
            this.TextBox_username.PasswordChar = '\0';
            this.TextBox_username.PlaceholderText = "";
            this.TextBox_username.SelectedText = "";
            this.TextBox_username.ShadowDecoration.Parent = this.TextBox_username;
            this.TextBox_username.Size = new System.Drawing.Size(236, 36);
            this.TextBox_username.TabIndex = 28;
            // 
            // pictureBox4
            // 
            this.pictureBox4.ErrorImage = null;
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.InitialImage = null;
            this.pictureBox4.Location = new System.Drawing.Point(25, 208);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(48, 36);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 29;
            this.pictureBox4.TabStop = false;
            // 
            // label_checkpassword
            // 
            this.label_checkpassword.AutoSize = true;
            this.label_checkpassword.ForeColor = System.Drawing.Color.White;
            this.label_checkpassword.Location = new System.Drawing.Point(90, 335);
            this.label_checkpassword.Name = "label_checkpassword";
            this.label_checkpassword.Size = new System.Drawing.Size(0, 13);
            this.label_checkpassword.TabIndex = 42;
            // 
            // label_password
            // 
            this.label_password.AutoSize = true;
            this.label_password.ForeColor = System.Drawing.Color.White;
            this.label_password.Location = new System.Drawing.Point(90, 417);
            this.label_password.Name = "label_password";
            this.label_password.Size = new System.Drawing.Size(0, 13);
            this.label_password.TabIndex = 43;
            // 
            // RecoveryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(350, 571);
            this.Controls.Add(this.label_password);
            this.Controls.Add(this.label_checkpassword);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.TextBox_username);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Label_exit);
            this.Controls.Add(this.Label_entrance);
            this.Controls.Add(this.Button_recovery);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.TextBox_checkpassword);
            this.Controls.Add(this.TextBox_password);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RecoveryForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RecoveryForm";
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.RecoveryForm_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2HtmlLabel Label_exit;
        private Guna.UI2.WinForms.Guna2HtmlLabel Label_entrance;
        private Guna.UI2.WinForms.Guna2Button Button_recovery;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Guna.UI2.WinForms.Guna2TextBox TextBox_checkpassword;
        private Guna.UI2.WinForms.Guna2TextBox TextBox_password;
        private Guna.UI2.WinForms.Guna2TextBox TextBox_username;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label label_checkpassword;
        private System.Windows.Forms.Label label_password;
    }
}