
namespace Hotel_Management_System
{
    partial class ReceptionForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReceptionForm));
            this.comboBox_recervro = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_recervid = new System.Windows.Forms.TextBox();
            this.dgv_reservation = new Guna.UI2.WinForms.Guna2DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Label_exit = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.label6 = new System.Windows.Forms.Label();
            this.panel_button = new System.Windows.Forms.Panel();
            this.Button_add = new Guna.UI2.WinForms.Guna2Button();
            this.Button_edit = new Guna.UI2.WinForms.Guna2Button();
            this.Button_delete = new Guna.UI2.WinForms.Guna2Button();
            this.Button_clean = new Guna.UI2.WinForms.Guna2Button();
            this.comboBox_fiog = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dateTimePicker_in = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dateTimePicker_out = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_reservation)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel_button.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboBox_recervro
            // 
            this.comboBox_recervro.FormattingEnabled = true;
            this.comboBox_recervro.Location = new System.Drawing.Point(171, 529);
            this.comboBox_recervro.Name = "comboBox_recervro";
            this.comboBox_recervro.Size = new System.Drawing.Size(231, 21);
            this.comboBox_recervro.TabIndex = 45;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(12, 529);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 20);
            this.label2.TabIndex = 36;
            this.label2.Text = "Номер комнаты";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 467);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 20);
            this.label1.TabIndex = 35;
            this.label1.Text = "ID резерва";
            // 
            // textBox_recervid
            // 
            this.textBox_recervid.Location = new System.Drawing.Point(171, 467);
            this.textBox_recervid.Name = "textBox_recervid";
            this.textBox_recervid.Size = new System.Drawing.Size(231, 20);
            this.textBox_recervid.TabIndex = 34;
            // 
            // dgv_reservation
            // 
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle13.ForeColor = System.Drawing.Color.Black;
            this.dgv_reservation.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle13;
            this.dgv_reservation.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_reservation.BackgroundColor = System.Drawing.Color.White;
            this.dgv_reservation.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_reservation.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgv_reservation.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle14.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_reservation.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle14;
            this.dgv_reservation.ColumnHeadersHeight = 4;
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle15.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle15.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_reservation.DefaultCellStyle = dataGridViewCellStyle15;
            this.dgv_reservation.EnableHeadersVisualStyles = false;
            this.dgv_reservation.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgv_reservation.Location = new System.Drawing.Point(16, 80);
            this.dgv_reservation.Name = "dgv_reservation";
            this.dgv_reservation.RowHeadersVisible = false;
            this.dgv_reservation.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_reservation.Size = new System.Drawing.Size(902, 381);
            this.dgv_reservation.TabIndex = 33;
            this.dgv_reservation.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgv_reservation.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgv_reservation.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgv_reservation.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgv_reservation.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgv_reservation.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgv_reservation.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgv_reservation.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgv_reservation.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgv_reservation.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgv_reservation.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgv_reservation.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgv_reservation.ThemeStyle.HeaderStyle.Height = 4;
            this.dgv_reservation.ThemeStyle.ReadOnly = false;
            this.dgv_reservation.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgv_reservation.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgv_reservation.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgv_reservation.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.White;
            this.dgv_reservation.ThemeStyle.RowsStyle.Height = 22;
            this.dgv_reservation.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgv_reservation.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgv_reservation.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_reservation_CellClick);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Label_exit);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(930, 74);
            this.panel1.TabIndex = 32;
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
            this.Label_exit.Click += new System.EventHandler(this.Label_exit_Click_1);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.ForeColor = System.Drawing.SystemColors.Control;
            this.label6.Location = new System.Drawing.Point(278, 22);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(352, 29);
            this.label6.TabIndex = 11;
            this.label6.Text = "Управление бронированием";
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
            this.panel_button.TabIndex = 46;
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
            this.Button_delete.Click += new System.EventHandler(this.Button_delete_Click);
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
            // comboBox_fiog
            // 
            this.comboBox_fiog.FormattingEnabled = true;
            this.comboBox_fiog.Location = new System.Drawing.Point(171, 497);
            this.comboBox_fiog.Name = "comboBox_fiog";
            this.comboBox_fiog.Size = new System.Drawing.Size(231, 21);
            this.comboBox_fiog.TabIndex = 50;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(12, 498);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 20);
            this.label5.TabIndex = 47;
            this.label5.Text = "ФИО гостя ";
            // 
            // dateTimePicker_in
            // 
            this.dateTimePicker_in.Checked = false;
            this.dateTimePicker_in.CustomFormat = "";
            this.dateTimePicker_in.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker_in.Location = new System.Drawing.Point(171, 562);
            this.dateTimePicker_in.Name = "dateTimePicker_in";
            this.dateTimePicker_in.Size = new System.Drawing.Size(231, 20);
            this.dateTimePicker_in.TabIndex = 51;
            this.dateTimePicker_in.Value = new System.DateTime(2021, 9, 4, 0, 0, 0, 0);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(12, 562);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 20);
            this.label3.TabIndex = 52;
            this.label3.Text = "Дата въезда";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(12, 595);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 20);
            this.label4.TabIndex = 53;
            this.label4.Text = "Дата выезда";
            // 
            // dateTimePicker_out
            // 
            this.dateTimePicker_out.Checked = false;
            this.dateTimePicker_out.CustomFormat = "dd.MM.yyyy";
            this.dateTimePicker_out.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker_out.Location = new System.Drawing.Point(171, 594);
            this.dateTimePicker_out.Name = "dateTimePicker_out";
            this.dateTimePicker_out.Size = new System.Drawing.Size(231, 20);
            this.dateTimePicker_out.TabIndex = 54;
            this.dateTimePicker_out.Value = new System.DateTime(2021, 9, 4, 0, 0, 0, 0);
            // 
            // ReceptionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(930, 750);
            this.Controls.Add(this.dateTimePicker_out);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dateTimePicker_in);
            this.Controls.Add(this.comboBox_fiog);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.panel_button);
            this.Controls.Add(this.comboBox_recervro);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_recervid);
            this.Controls.Add(this.dgv_reservation);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ReceptionForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.ReceptionForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_reservation)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel_button.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox_recervro;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_recervid;
        private Guna.UI2.WinForms.Guna2DataGridView dgv_reservation;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2HtmlLabel Label_exit;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel_button;
        private Guna.UI2.WinForms.Guna2Button Button_add;
        private Guna.UI2.WinForms.Guna2Button Button_edit;
        private Guna.UI2.WinForms.Guna2Button Button_delete;
        private Guna.UI2.WinForms.Guna2Button Button_clean;
        private System.Windows.Forms.ComboBox comboBox_fiog;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dateTimePicker_in;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dateTimePicker_out;
    }
}