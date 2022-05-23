
namespace Hotel_Management_System
{
    partial class CleaningForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CleaningForm));
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimePicker_dlc = new System.Windows.Forms.DateTimePicker();
            this.comboBox_roomn = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_cleaningrid = new System.Windows.Forms.TextBox();
            this.dgv_cleaning = new Guna.UI2.WinForms.Guna2DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Label_exit = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.label6 = new System.Windows.Forms.Label();
            this.panel_button = new System.Windows.Forms.Panel();
            this.Button_add = new Guna.UI2.WinForms.Guna2Button();
            this.Button_edit = new Guna.UI2.WinForms.Guna2Button();
            this.Button_delete = new Guna.UI2.WinForms.Guna2Button();
            this.Button_clean = new Guna.UI2.WinForms.Guna2Button();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox_cleaningc = new System.Windows.Forms.ComboBox();
            this.comboBox_typesc = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_cleaning)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel_button.SuspendLayout();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(8, 596);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(190, 20);
            this.label3.TabIndex = 64;
            this.label3.Text = "Дата последней уборки";
            // 
            // dateTimePicker_dlc
            // 
            this.dateTimePicker_dlc.Checked = false;
            this.dateTimePicker_dlc.CustomFormat = "dd.MM.yyyy";
            this.dateTimePicker_dlc.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker_dlc.Location = new System.Drawing.Point(204, 596);
            this.dateTimePicker_dlc.Name = "dateTimePicker_dlc";
            this.dateTimePicker_dlc.Size = new System.Drawing.Size(231, 20);
            this.dateTimePicker_dlc.TabIndex = 63;
            // 
            // comboBox_roomn
            // 
            this.comboBox_roomn.FormattingEnabled = true;
            this.comboBox_roomn.Location = new System.Drawing.Point(204, 498);
            this.comboBox_roomn.Name = "comboBox_roomn";
            this.comboBox_roomn.Size = new System.Drawing.Size(231, 21);
            this.comboBox_roomn.TabIndex = 62;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(8, 498);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(133, 20);
            this.label5.TabIndex = 61;
            this.label5.Text = "Номер комнаты ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(8, 467);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 20);
            this.label1.TabIndex = 58;
            this.label1.Text = "ID уборки ";
            // 
            // textBox_cleaningrid
            // 
            this.textBox_cleaningrid.Location = new System.Drawing.Point(204, 467);
            this.textBox_cleaningrid.Name = "textBox_cleaningrid";
            this.textBox_cleaningrid.Size = new System.Drawing.Size(231, 20);
            this.textBox_cleaningrid.TabIndex = 57;
            // 
            // dgv_cleaning
            // 
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.Black;
            this.dgv_cleaning.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle10;
            this.dgv_cleaning.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_cleaning.BackgroundColor = System.Drawing.Color.White;
            this.dgv_cleaning.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_cleaning.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgv_cleaning.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_cleaning.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.dgv_cleaning.ColumnHeadersHeight = 4;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_cleaning.DefaultCellStyle = dataGridViewCellStyle12;
            this.dgv_cleaning.EnableHeadersVisualStyles = false;
            this.dgv_cleaning.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgv_cleaning.Location = new System.Drawing.Point(12, 80);
            this.dgv_cleaning.Name = "dgv_cleaning";
            this.dgv_cleaning.RowHeadersVisible = false;
            this.dgv_cleaning.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_cleaning.Size = new System.Drawing.Size(902, 381);
            this.dgv_cleaning.TabIndex = 56;
            this.dgv_cleaning.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgv_cleaning.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgv_cleaning.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgv_cleaning.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgv_cleaning.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgv_cleaning.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgv_cleaning.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgv_cleaning.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgv_cleaning.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgv_cleaning.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgv_cleaning.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgv_cleaning.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgv_cleaning.ThemeStyle.HeaderStyle.Height = 4;
            this.dgv_cleaning.ThemeStyle.ReadOnly = false;
            this.dgv_cleaning.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgv_cleaning.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgv_cleaning.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgv_cleaning.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.White;
            this.dgv_cleaning.ThemeStyle.RowsStyle.Height = 22;
            this.dgv_cleaning.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgv_cleaning.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgv_cleaning.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_cleaning_CellClick);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Label_exit);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(930, 74);
            this.panel1.TabIndex = 55;
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
            this.label6.Location = new System.Drawing.Point(350, 22);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(258, 29);
            this.label6.TabIndex = 11;
            this.label6.Text = "Управление уборкой";
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
            this.panel_button.TabIndex = 67;
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
            this.Button_edit.Click += new System.EventHandler(this.Button_edit_Click_1);
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
            this.Button_clean.Click += new System.EventHandler(this.Button_clean_Click_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(8, 531);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 20);
            this.label2.TabIndex = 68;
            this.label2.Text = "Категория уборки";
            // 
            // comboBox_cleaningc
            // 
            this.comboBox_cleaningc.FormattingEnabled = true;
            this.comboBox_cleaningc.Location = new System.Drawing.Point(204, 531);
            this.comboBox_cleaningc.Name = "comboBox_cleaningc";
            this.comboBox_cleaningc.Size = new System.Drawing.Size(231, 21);
            this.comboBox_cleaningc.TabIndex = 69;
            // 
            // comboBox_typesc
            // 
            this.comboBox_typesc.FormattingEnabled = true;
            this.comboBox_typesc.Location = new System.Drawing.Point(204, 563);
            this.comboBox_typesc.Name = "comboBox_typesc";
            this.comboBox_typesc.Size = new System.Drawing.Size(231, 21);
            this.comboBox_typesc.TabIndex = 70;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(8, 563);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 20);
            this.label4.TabIndex = 71;
            this.label4.Text = "Виды уборки";
            // 
            // CleaningForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(930, 750);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboBox_typesc);
            this.Controls.Add(this.comboBox_cleaningc);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel_button);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dateTimePicker_dlc);
            this.Controls.Add(this.comboBox_roomn);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_cleaningrid);
            this.Controls.Add(this.dgv_cleaning);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CleaningForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.CleaningForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_cleaning)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel_button.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateTimePicker_dlc;
        private System.Windows.Forms.ComboBox comboBox_roomn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_cleaningrid;
        private Guna.UI2.WinForms.Guna2DataGridView dgv_cleaning;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2HtmlLabel Label_exit;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel_button;
        private Guna.UI2.WinForms.Guna2Button Button_add;
        private Guna.UI2.WinForms.Guna2Button Button_edit;
        private Guna.UI2.WinForms.Guna2Button Button_delete;
        private Guna.UI2.WinForms.Guna2Button Button_clean;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox_cleaningc;
        private System.Windows.Forms.ComboBox comboBox_typesc;
        private System.Windows.Forms.Label label4;
    }
}