
namespace Hotel_Management_System
{
    partial class GuestForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GuestForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel_button = new System.Windows.Forms.Panel();
            this.Button_add = new Guna.UI2.WinForms.Guna2Button();
            this.Button_edit = new Guna.UI2.WinForms.Guna2Button();
            this.Button_delete = new Guna.UI2.WinForms.Guna2Button();
            this.Button_clean = new Guna.UI2.WinForms.Guna2Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_phone = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox_city = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Label_exit = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.label6 = new System.Windows.Forms.Label();
            this.panel_guest = new System.Windows.Forms.Panel();
            this.textBox_sorting = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dgvguest = new Guna.UI2.WinForms.Guna2DataGridView();
            this.comboBox_uname = new System.Windows.Forms.ComboBox();
            this.textBox_gid = new System.Windows.Forms.TextBox();
            this.textBox_fio = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.panel_button.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel_guest.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvguest)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_button
            // 
            this.panel_button.Controls.Add(this.Button_add);
            this.panel_button.Controls.Add(this.Button_edit);
            this.panel_button.Controls.Add(this.Button_delete);
            this.panel_button.Controls.Add(this.Button_clean);
            this.panel_button.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel_button.Location = new System.Drawing.Point(0, 640);
            this.panel_button.Name = "panel_button";
            this.panel_button.Size = new System.Drawing.Size(930, 110);
            this.panel_button.TabIndex = 0;
            // 
            // Button_add
            // 
            this.Button_add.CheckedState.Parent = this.Button_add;
            this.Button_add.CustomImages.Parent = this.Button_add;
            this.Button_add.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Button_add.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Button_add.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Button_add.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Button_add.DisabledState.Parent = this.Button_add;
            this.Button_add.Dock = System.Windows.Forms.DockStyle.Right;
            this.Button_add.FillColor = System.Drawing.Color.Black;
            this.Button_add.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Button_add.ForeColor = System.Drawing.Color.White;
            this.Button_add.HoverState.Parent = this.Button_add;
            this.Button_add.Image = ((System.Drawing.Image)(resources.GetObject("Button_add.Image")));
            this.Button_add.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Button_add.ImageSize = new System.Drawing.Size(40, 40);
            this.Button_add.Location = new System.Drawing.Point(246, 0);
            this.Button_add.Name = "Button_add";
            this.Button_add.ShadowDecoration.Parent = this.Button_add;
            this.Button_add.Size = new System.Drawing.Size(171, 110);
            this.Button_add.TabIndex = 6;
            this.Button_add.Text = "Добавить";
            this.Button_add.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Button_add.Click += new System.EventHandler(this.Button_add_Click);
            // 
            // Button_edit
            // 
            this.Button_edit.CheckedState.Parent = this.Button_edit;
            this.Button_edit.CustomImages.Parent = this.Button_edit;
            this.Button_edit.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Button_edit.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Button_edit.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Button_edit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Button_edit.DisabledState.Parent = this.Button_edit;
            this.Button_edit.Dock = System.Windows.Forms.DockStyle.Right;
            this.Button_edit.FillColor = System.Drawing.Color.Black;
            this.Button_edit.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Button_edit.ForeColor = System.Drawing.Color.White;
            this.Button_edit.HoverState.Parent = this.Button_edit;
            this.Button_edit.Image = ((System.Drawing.Image)(resources.GetObject("Button_edit.Image")));
            this.Button_edit.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Button_edit.ImageSize = new System.Drawing.Size(40, 40);
            this.Button_edit.Location = new System.Drawing.Point(417, 0);
            this.Button_edit.Name = "Button_edit";
            this.Button_edit.ShadowDecoration.Parent = this.Button_edit;
            this.Button_edit.Size = new System.Drawing.Size(171, 110);
            this.Button_edit.TabIndex = 5;
            this.Button_edit.Text = "Изменить";
            this.Button_edit.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Button_edit.Click += new System.EventHandler(this.Button_edit_Click);
            // 
            // Button_delete
            // 
            this.Button_delete.CheckedState.Parent = this.Button_delete;
            this.Button_delete.CustomImages.Parent = this.Button_delete;
            this.Button_delete.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Button_delete.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Button_delete.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Button_delete.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Button_delete.DisabledState.Parent = this.Button_delete;
            this.Button_delete.Dock = System.Windows.Forms.DockStyle.Right;
            this.Button_delete.FillColor = System.Drawing.Color.Black;
            this.Button_delete.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Button_delete.ForeColor = System.Drawing.Color.White;
            this.Button_delete.HoverState.Parent = this.Button_delete;
            this.Button_delete.Image = ((System.Drawing.Image)(resources.GetObject("Button_delete.Image")));
            this.Button_delete.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Button_delete.ImageSize = new System.Drawing.Size(40, 40);
            this.Button_delete.Location = new System.Drawing.Point(588, 0);
            this.Button_delete.Name = "Button_delete";
            this.Button_delete.ShadowDecoration.Parent = this.Button_delete;
            this.Button_delete.Size = new System.Drawing.Size(171, 110);
            this.Button_delete.TabIndex = 4;
            this.Button_delete.Text = "Удалить";
            this.Button_delete.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Button_delete.Click += new System.EventHandler(this.Button_delete_Click_1);
            // 
            // Button_clean
            // 
            this.Button_clean.CheckedState.Parent = this.Button_clean;
            this.Button_clean.CustomImages.Parent = this.Button_clean;
            this.Button_clean.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Button_clean.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Button_clean.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Button_clean.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Button_clean.DisabledState.Parent = this.Button_clean;
            this.Button_clean.Dock = System.Windows.Forms.DockStyle.Right;
            this.Button_clean.FillColor = System.Drawing.Color.Black;
            this.Button_clean.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Button_clean.ForeColor = System.Drawing.Color.White;
            this.Button_clean.HoverState.Parent = this.Button_clean;
            this.Button_clean.Image = ((System.Drawing.Image)(resources.GetObject("Button_clean.Image")));
            this.Button_clean.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Button_clean.ImageSize = new System.Drawing.Size(40, 40);
            this.Button_clean.Location = new System.Drawing.Point(759, 0);
            this.Button_clean.Name = "Button_clean";
            this.Button_clean.ShadowDecoration.Parent = this.Button_clean;
            this.Button_clean.Size = new System.Drawing.Size(171, 110);
            this.Button_clean.TabIndex = 3;
            this.Button_clean.Text = "Стереть";
            this.Button_clean.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Button_clean.Click += new System.EventHandler(this.Button_clean_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(20, 460);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "ID гостя";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(20, 498);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(153, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Имя пользователя";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(20, 535);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "ФИО гостя";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(20, 571);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(125, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Телефон гостя";
            // 
            // textBox_phone
            // 
            this.textBox_phone.Location = new System.Drawing.Point(200, 571);
            this.textBox_phone.Name = "textBox_phone";
            this.textBox_phone.Size = new System.Drawing.Size(231, 20);
            this.textBox_phone.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(20, 606);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "Город гостя";
            // 
            // textBox_city
            // 
            this.textBox_city.Location = new System.Drawing.Point(200, 606);
            this.textBox_city.Name = "textBox_city";
            this.textBox_city.Size = new System.Drawing.Size(231, 20);
            this.textBox_city.TabIndex = 9;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Label_exit);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.panel_guest);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(930, 74);
            this.panel1.TabIndex = 11;
            // 
            // Label_exit
            // 
            this.Label_exit.BackColor = System.Drawing.Color.Transparent;
            this.Label_exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Label_exit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Label_exit.Location = new System.Drawing.Point(906, 3);
            this.Label_exit.Name = "Label_exit";
            this.Label_exit.Size = new System.Drawing.Size(17, 27);
            this.Label_exit.TabIndex = 13;
            this.Label_exit.Text = "Х";
            this.Label_exit.Click += new System.EventHandler(this.Label_exit_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.ForeColor = System.Drawing.SystemColors.Control;
            this.label6.Location = new System.Drawing.Point(374, 17);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(182, 29);
            this.label6.TabIndex = 11;
            this.label6.Text = "Список гостей";
            // 
            // panel_guest
            // 
            this.panel_guest.Controls.Add(this.button1);
            this.panel_guest.Controls.Add(this.textBox_sorting);
            this.panel_guest.Controls.Add(this.label7);
            this.panel_guest.Location = new System.Drawing.Point(0, 0);
            this.panel_guest.Name = "panel_guest";
            this.panel_guest.Size = new System.Drawing.Size(930, 750);
            this.panel_guest.TabIndex = 12;
            // 
            // textBox_sorting
            // 
            this.textBox_sorting.Location = new System.Drawing.Point(126, 51);
            this.textBox_sorting.Name = "textBox_sorting";
            this.textBox_sorting.Size = new System.Drawing.Size(231, 20);
            this.textBox_sorting.TabIndex = 35;
            this.textBox_sorting.TextChanged += new System.EventHandler(this.textBox_sorting_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(20, 51);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 20);
            this.label7.TabIndex = 34;
            this.label7.Text = "Сортировка";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dgvguest);
            this.panel3.Location = new System.Drawing.Point(24, 73);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(894, 381);
            this.panel3.TabIndex = 12;
            // 
            // dgvguest
            // 
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            this.dgvguest.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvguest.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvguest.BackgroundColor = System.Drawing.Color.White;
            this.dgvguest.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvguest.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvguest.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvguest.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvguest.ColumnHeadersHeight = 4;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvguest.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvguest.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvguest.EnableHeadersVisualStyles = false;
            this.dgvguest.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvguest.Location = new System.Drawing.Point(0, 0);
            this.dgvguest.Name = "dgvguest";
            this.dgvguest.RowHeadersVisible = false;
            this.dgvguest.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvguest.Size = new System.Drawing.Size(894, 381);
            this.dgvguest.TabIndex = 0;
            this.dgvguest.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvguest.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvguest.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvguest.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvguest.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvguest.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvguest.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvguest.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgvguest.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvguest.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgvguest.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvguest.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvguest.ThemeStyle.HeaderStyle.Height = 4;
            this.dgvguest.ThemeStyle.ReadOnly = false;
            this.dgvguest.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvguest.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvguest.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgvguest.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.White;
            this.dgvguest.ThemeStyle.RowsStyle.Height = 22;
            this.dgvguest.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvguest.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvguest.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvguest_CellClick);
            // 
            // comboBox_uname
            // 
            this.comboBox_uname.FormattingEnabled = true;
            this.comboBox_uname.Location = new System.Drawing.Point(200, 497);
            this.comboBox_uname.Name = "comboBox_uname";
            this.comboBox_uname.Size = new System.Drawing.Size(231, 21);
            this.comboBox_uname.TabIndex = 30;
            // 
            // textBox_gid
            // 
            this.textBox_gid.Location = new System.Drawing.Point(200, 460);
            this.textBox_gid.Name = "textBox_gid";
            this.textBox_gid.Size = new System.Drawing.Size(231, 20);
            this.textBox_gid.TabIndex = 32;
            // 
            // textBox_fio
            // 
            this.textBox_fio.Location = new System.Drawing.Point(200, 535);
            this.textBox_fio.Name = "textBox_fio";
            this.textBox_fio.Size = new System.Drawing.Size(231, 20);
            this.textBox_fio.TabIndex = 33;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(363, 51);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 20);
            this.button1.TabIndex = 36;
            this.button1.Text = "сортировка";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // GuestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(930, 750);
            this.Controls.Add(this.textBox_fio);
            this.Controls.Add(this.textBox_gid);
            this.Controls.Add(this.comboBox_uname);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox_city);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox_phone);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel_button);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "GuestForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.GuestForm_Load);
            this.panel_button.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel_guest.ResumeLayout(false);
            this.panel_guest.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvguest)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel_button;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_phone;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox_city;
        private Guna.UI2.WinForms.Guna2Button Button_clean;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label6;
        private Guna.UI2.WinForms.Guna2Button Button_add;
        private Guna.UI2.WinForms.Guna2Button Button_edit;
        private Guna.UI2.WinForms.Guna2Button Button_delete;
        private System.Windows.Forms.Panel panel_guest;
        private System.Windows.Forms.Panel panel3;
        private Guna.UI2.WinForms.Guna2DataGridView dgvguest;
        private Guna.UI2.WinForms.Guna2HtmlLabel Label_exit;
        private System.Windows.Forms.ComboBox comboBox_uname;
        private System.Windows.Forms.TextBox textBox_gid;
        private System.Windows.Forms.TextBox textBox_fio;
        private System.Windows.Forms.TextBox textBox_sorting;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button1;
    }
}