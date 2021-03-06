
namespace Hotel_Management_System
{
    partial class ManagerForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManagerForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.Button_logout = new Guna.UI2.WinForms.Guna2Button();
            this.Button_cleaning = new Guna.UI2.WinForms.Guna2Button();
            this.Button_room = new Guna.UI2.WinForms.Guna2Button();
            this.Button_reception = new Guna.UI2.WinForms.Guna2Button();
            this.Button_guest = new Guna.UI2.WinForms.Guna2Button();
            this.Button_dashboard = new Guna.UI2.WinForms.Guna2Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Panel_cover = new System.Windows.Forms.Panel();
            this.checkBox5 = new System.Windows.Forms.CheckBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Label_exit = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel_slide = new System.Windows.Forms.Panel();
            this.Panel_admin = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.Panel_cover.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel3.SuspendLayout();
            this.Panel_admin.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Button_logout);
            this.panel1.Controls.Add(this.Button_cleaning);
            this.panel1.Controls.Add(this.Button_room);
            this.panel1.Controls.Add(this.Button_reception);
            this.panel1.Controls.Add(this.Button_guest);
            this.panel1.Controls.Add(this.Button_dashboard);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(170, 750);
            this.panel1.TabIndex = 0;
            // 
            // Button_logout
            // 
            this.Button_logout.CheckedState.Parent = this.Button_logout;
            this.Button_logout.CustomImages.Parent = this.Button_logout;
            this.Button_logout.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Button_logout.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Button_logout.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Button_logout.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Button_logout.DisabledState.Parent = this.Button_logout;
            this.Button_logout.Dock = System.Windows.Forms.DockStyle.Top;
            this.Button_logout.FillColor = System.Drawing.Color.Black;
            this.Button_logout.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Button_logout.ForeColor = System.Drawing.Color.White;
            this.Button_logout.HoverState.Parent = this.Button_logout;
            this.Button_logout.Image = ((System.Drawing.Image)(resources.GetObject("Button_logout.Image")));
            this.Button_logout.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Button_logout.ImageSize = new System.Drawing.Size(40, 40);
            this.Button_logout.Location = new System.Drawing.Point(0, 640);
            this.Button_logout.Name = "Button_logout";
            this.Button_logout.ShadowDecoration.Parent = this.Button_logout;
            this.Button_logout.Size = new System.Drawing.Size(170, 108);
            this.Button_logout.TabIndex = 7;
            this.Button_logout.Text = "Выход из системы";
            this.Button_logout.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Button_logout.Click += new System.EventHandler(this.Button_exit_Click);
            // 
            // Button_cleaning
            // 
            this.Button_cleaning.CheckedState.Parent = this.Button_cleaning;
            this.Button_cleaning.CustomImages.Parent = this.Button_cleaning;
            this.Button_cleaning.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Button_cleaning.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Button_cleaning.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Button_cleaning.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Button_cleaning.DisabledState.Parent = this.Button_cleaning;
            this.Button_cleaning.Dock = System.Windows.Forms.DockStyle.Top;
            this.Button_cleaning.FillColor = System.Drawing.Color.Black;
            this.Button_cleaning.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Button_cleaning.ForeColor = System.Drawing.Color.White;
            this.Button_cleaning.HoverState.Parent = this.Button_cleaning;
            this.Button_cleaning.Image = ((System.Drawing.Image)(resources.GetObject("Button_cleaning.Image")));
            this.Button_cleaning.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Button_cleaning.ImageSize = new System.Drawing.Size(40, 40);
            this.Button_cleaning.Location = new System.Drawing.Point(0, 532);
            this.Button_cleaning.Name = "Button_cleaning";
            this.Button_cleaning.ShadowDecoration.Parent = this.Button_cleaning;
            this.Button_cleaning.Size = new System.Drawing.Size(170, 108);
            this.Button_cleaning.TabIndex = 6;
            this.Button_cleaning.Text = "Уборка";
            this.Button_cleaning.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Button_cleaning.Click += new System.EventHandler(this.Button_cleaning_Click);
            // 
            // Button_room
            // 
            this.Button_room.CheckedState.Parent = this.Button_room;
            this.Button_room.CustomImages.Parent = this.Button_room;
            this.Button_room.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Button_room.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Button_room.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Button_room.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Button_room.DisabledState.Parent = this.Button_room;
            this.Button_room.Dock = System.Windows.Forms.DockStyle.Top;
            this.Button_room.FillColor = System.Drawing.Color.Black;
            this.Button_room.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Button_room.ForeColor = System.Drawing.Color.White;
            this.Button_room.HoverState.Parent = this.Button_room;
            this.Button_room.Image = ((System.Drawing.Image)(resources.GetObject("Button_room.Image")));
            this.Button_room.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Button_room.ImageSize = new System.Drawing.Size(40, 40);
            this.Button_room.Location = new System.Drawing.Point(0, 424);
            this.Button_room.Name = "Button_room";
            this.Button_room.ShadowDecoration.Parent = this.Button_room;
            this.Button_room.Size = new System.Drawing.Size(170, 108);
            this.Button_room.TabIndex = 5;
            this.Button_room.Text = "Комнаты";
            this.Button_room.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Button_room.Click += new System.EventHandler(this.Button_room_Click);
            // 
            // Button_reception
            // 
            this.Button_reception.CheckedState.Parent = this.Button_reception;
            this.Button_reception.CustomImages.Parent = this.Button_reception;
            this.Button_reception.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Button_reception.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Button_reception.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Button_reception.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Button_reception.DisabledState.Parent = this.Button_reception;
            this.Button_reception.Dock = System.Windows.Forms.DockStyle.Top;
            this.Button_reception.FillColor = System.Drawing.Color.Black;
            this.Button_reception.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Button_reception.ForeColor = System.Drawing.Color.White;
            this.Button_reception.HoverState.Parent = this.Button_reception;
            this.Button_reception.Image = ((System.Drawing.Image)(resources.GetObject("Button_reception.Image")));
            this.Button_reception.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Button_reception.ImageSize = new System.Drawing.Size(40, 40);
            this.Button_reception.Location = new System.Drawing.Point(0, 316);
            this.Button_reception.Name = "Button_reception";
            this.Button_reception.ShadowDecoration.Parent = this.Button_reception;
            this.Button_reception.Size = new System.Drawing.Size(170, 108);
            this.Button_reception.TabIndex = 4;
            this.Button_reception.Text = "Ресепшен";
            this.Button_reception.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Button_reception.Click += new System.EventHandler(this.Button_reception_Click);
            // 
            // Button_guest
            // 
            this.Button_guest.CheckedState.Parent = this.Button_guest;
            this.Button_guest.CustomImages.Parent = this.Button_guest;
            this.Button_guest.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Button_guest.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Button_guest.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Button_guest.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Button_guest.DisabledState.Parent = this.Button_guest;
            this.Button_guest.Dock = System.Windows.Forms.DockStyle.Top;
            this.Button_guest.FillColor = System.Drawing.Color.Black;
            this.Button_guest.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Button_guest.ForeColor = System.Drawing.Color.White;
            this.Button_guest.HoverState.Parent = this.Button_guest;
            this.Button_guest.Image = ((System.Drawing.Image)(resources.GetObject("Button_guest.Image")));
            this.Button_guest.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Button_guest.ImageSize = new System.Drawing.Size(40, 40);
            this.Button_guest.Location = new System.Drawing.Point(0, 208);
            this.Button_guest.Name = "Button_guest";
            this.Button_guest.ShadowDecoration.Parent = this.Button_guest;
            this.Button_guest.Size = new System.Drawing.Size(170, 108);
            this.Button_guest.TabIndex = 3;
            this.Button_guest.Text = "Гости";
            this.Button_guest.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Button_guest.Click += new System.EventHandler(this.Button_guest_Click);
            // 
            // Button_dashboard
            // 
            this.Button_dashboard.CheckedState.Parent = this.Button_dashboard;
            this.Button_dashboard.CustomImages.Parent = this.Button_dashboard;
            this.Button_dashboard.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Button_dashboard.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Button_dashboard.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Button_dashboard.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Button_dashboard.DisabledState.Parent = this.Button_dashboard;
            this.Button_dashboard.Dock = System.Windows.Forms.DockStyle.Top;
            this.Button_dashboard.FillColor = System.Drawing.Color.Black;
            this.Button_dashboard.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Button_dashboard.ForeColor = System.Drawing.Color.White;
            this.Button_dashboard.HoverState.Parent = this.Button_dashboard;
            this.Button_dashboard.Image = ((System.Drawing.Image)(resources.GetObject("Button_dashboard.Image")));
            this.Button_dashboard.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Button_dashboard.ImageSize = new System.Drawing.Size(40, 40);
            this.Button_dashboard.Location = new System.Drawing.Point(0, 100);
            this.Button_dashboard.Name = "Button_dashboard";
            this.Button_dashboard.ShadowDecoration.Parent = this.Button_dashboard;
            this.Button_dashboard.Size = new System.Drawing.Size(170, 108);
            this.Button_dashboard.TabIndex = 2;
            this.Button_dashboard.Text = "Приборная панель";
            this.Button_dashboard.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Button_dashboard.Click += new System.EventHandler(this.Button_dashboard_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(170, 100);
            this.panel2.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(170, 100);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Panel_cover
            // 
            this.Panel_cover.Controls.Add(this.checkBox5);
            this.Panel_cover.Controls.Add(this.checkBox4);
            this.Panel_cover.Controls.Add(this.checkBox3);
            this.Panel_cover.Controls.Add(this.checkBox2);
            this.Panel_cover.Controls.Add(this.label3);
            this.Panel_cover.Controls.Add(this.checkBox1);
            this.Panel_cover.Controls.Add(this.pictureBox2);
            this.Panel_cover.Controls.Add(this.label1);
            this.Panel_cover.Controls.Add(this.Label_exit);
            this.Panel_cover.Location = new System.Drawing.Point(3, 0);
            this.Panel_cover.Name = "Panel_cover";
            this.Panel_cover.Size = new System.Drawing.Size(921, 750);
            this.Panel_cover.TabIndex = 1;
            // 
            // checkBox5
            // 
            this.checkBox5.AutoSize = true;
            this.checkBox5.BackColor = System.Drawing.Color.Black;
            this.checkBox5.Checked = true;
            this.checkBox5.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox5.ForeColor = System.Drawing.Color.White;
            this.checkBox5.Location = new System.Drawing.Point(22, 561);
            this.checkBox5.Name = "checkBox5";
            this.checkBox5.Size = new System.Drawing.Size(266, 17);
            this.checkBox5.TabIndex = 18;
            this.checkBox5.Text = "Возглавлять работу подразделений гостиницы";
            this.checkBox5.UseVisualStyleBackColor = false;
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.BackColor = System.Drawing.Color.Black;
            this.checkBox4.Checked = true;
            this.checkBox4.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox4.ForeColor = System.Drawing.Color.White;
            this.checkBox4.Location = new System.Drawing.Point(22, 538);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(319, 17);
            this.checkBox4.TabIndex = 17;
            this.checkBox4.Text = "Проявить творческий подход к затерянным и найденным";
            this.checkBox4.UseVisualStyleBackColor = false;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.BackColor = System.Drawing.Color.Black;
            this.checkBox3.Checked = true;
            this.checkBox3.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox3.ForeColor = System.Drawing.Color.White;
            this.checkBox3.Location = new System.Drawing.Point(22, 515);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(278, 17);
            this.checkBox3.TabIndex = 16;
            this.checkBox3.Text = "Осуществлять контроль предоставляемых услуг ";
            this.checkBox3.UseVisualStyleBackColor = false;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.BackColor = System.Drawing.Color.Black;
            this.checkBox2.Checked = true;
            this.checkBox2.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox2.ForeColor = System.Drawing.Color.White;
            this.checkBox2.Location = new System.Drawing.Point(22, 492);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(188, 17);
            this.checkBox2.TabIndex = 15;
            this.checkBox2.Text = "Контроль за работой горничной";
            this.checkBox2.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(18, 442);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 24);
            this.label3.TabIndex = 14;
            this.label3.Text = "Задачи:";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.BackColor = System.Drawing.Color.Black;
            this.checkBox1.Checked = true;
            this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox1.ForeColor = System.Drawing.Color.White;
            this.checkBox1.Location = new System.Drawing.Point(22, 469);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(220, 17);
            this.checkBox1.TabIndex = 13;
            this.checkBox1.Text = "Контроль за работой администратора";
            this.checkBox1.UseVisualStyleBackColor = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(22, 41);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(887, 398);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 12;
            this.pictureBox2.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(251, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(412, 29);
            this.label1.TabIndex = 10;
            this.label1.Text = "Система Управления Гостиницей";
            // 
            // Label_exit
            // 
            this.Label_exit.BackColor = System.Drawing.Color.Transparent;
            this.Label_exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Label_exit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Label_exit.Location = new System.Drawing.Point(900, 3);
            this.Label_exit.Name = "Label_exit";
            this.Label_exit.Size = new System.Drawing.Size(17, 27);
            this.Label_exit.TabIndex = 9;
            this.Label_exit.Text = "Х";
            this.Label_exit.Click += new System.EventHandler(this.Label_exit_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.panel_slide);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(170, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(10, 750);
            this.panel3.TabIndex = 2;
            // 
            // panel_slide
            // 
            this.panel_slide.BackColor = System.Drawing.Color.White;
            this.panel_slide.Location = new System.Drawing.Point(0, 100);
            this.panel_slide.Name = "panel_slide";
            this.panel_slide.Size = new System.Drawing.Size(10, 108);
            this.panel_slide.TabIndex = 22;
            // 
            // Panel_admin
            // 
            this.Panel_admin.Controls.Add(this.Panel_cover);
            this.Panel_admin.Location = new System.Drawing.Point(176, 0);
            this.Panel_admin.Name = "Panel_admin";
            this.Panel_admin.Size = new System.Drawing.Size(921, 750);
            this.Panel_admin.TabIndex = 3;
            // 
            // ManagerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1100, 750);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.Panel_admin);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ManagerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminForm";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.Panel_cover.ResumeLayout(false);
            this.Panel_cover.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel3.ResumeLayout(false);
            this.Panel_admin.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel Panel_cover;
        private Guna.UI2.WinForms.Guna2Button Button_logout;
        private Guna.UI2.WinForms.Guna2Button Button_cleaning;
        private Guna.UI2.WinForms.Guna2Button Button_room;
        private Guna.UI2.WinForms.Guna2Button Button_reception;
        private Guna.UI2.WinForms.Guna2Button Button_guest;
        private Guna.UI2.WinForms.Guna2Button Button_dashboard;
        private Guna.UI2.WinForms.Guna2HtmlLabel Label_exit;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel_slide;
        private System.Windows.Forms.Panel Panel_admin;
        private System.Windows.Forms.CheckBox checkBox5;
    }
}