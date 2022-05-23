
namespace Hotel_Management_System
{
    partial class RoomForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RoomForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.Label_exit = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.label6 = new System.Windows.Forms.Label();
            this.dgv_room = new Guna.UI2.WinForms.Guna2DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_rph = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_rid = new System.Windows.Forms.TextBox();
            this.panel_button = new System.Windows.Forms.Panel();
            this.Button_add = new Guna.UI2.WinForms.Guna2Button();
            this.Button_edit = new Guna.UI2.WinForms.Guna2Button();
            this.Button_delete = new Guna.UI2.WinForms.Guna2Button();
            this.Button_clean = new Guna.UI2.WinForms.Guna2Button();
            this.label7 = new System.Windows.Forms.Label();
            this.comboBox_rtype = new System.Windows.Forms.ComboBox();
            this.comboBox_rstatus = new System.Windows.Forms.ComboBox();
            this.comboBox_rhn = new System.Windows.Forms.ComboBox();
            this.comboBox_rno = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_room)).BeginInit();
            this.panel_button.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Label_exit);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(930, 74);
            this.panel1.TabIndex = 12;
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
            this.label6.Location = new System.Drawing.Point(374, 22);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(188, 29);
            this.label6.TabIndex = 11;
            this.label6.Text = "Список комнат";
            // 
            // dgv_room
            // 
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            this.dgv_room.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgv_room.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_room.BackgroundColor = System.Drawing.Color.White;
            this.dgv_room.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_room.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgv_room.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_room.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgv_room.ColumnHeadersHeight = 4;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_room.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgv_room.EnableHeadersVisualStyles = false;
            this.dgv_room.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgv_room.Location = new System.Drawing.Point(16, 77);
            this.dgv_room.Name = "dgv_room";
            this.dgv_room.RowHeadersVisible = false;
            this.dgv_room.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_room.Size = new System.Drawing.Size(902, 381);
            this.dgv_room.TabIndex = 13;
            this.dgv_room.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgv_room.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgv_room.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgv_room.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgv_room.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgv_room.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgv_room.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgv_room.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgv_room.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgv_room.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgv_room.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgv_room.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgv_room.ThemeStyle.HeaderStyle.Height = 4;
            this.dgv_room.ThemeStyle.ReadOnly = false;
            this.dgv_room.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgv_room.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgv_room.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgv_room.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.White;
            this.dgv_room.ThemeStyle.RowsStyle.Height = 22;
            this.dgv_room.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgv_room.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgv_room.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_room_CellClick);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(12, 609);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(122, 20);
            this.label5.TabIndex = 23;
            this.label5.Text = "Статус номера";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(12, 575);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(152, 20);
            this.label4.TabIndex = 21;
            this.label4.Text = "Телефон в номере";
            // 
            // textBox_rph
            // 
            this.textBox_rph.Location = new System.Drawing.Point(171, 575);
            this.textBox_rph.Name = "textBox_rph";
            this.textBox_rph.Size = new System.Drawing.Size(231, 20);
            this.textBox_rph.TabIndex = 20;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(12, 538);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 20);
            this.label3.TabIndex = 19;
            this.label3.Text = "Тип комнаты";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(12, 502);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 20);
            this.label2.TabIndex = 17;
            this.label2.Text = "Номер комнаты";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 464);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 20);
            this.label1.TabIndex = 15;
            this.label1.Text = "ID комнаты";
            // 
            // textBox_rid
            // 
            this.textBox_rid.Location = new System.Drawing.Point(171, 464);
            this.textBox_rid.Name = "textBox_rid";
            this.textBox_rid.Size = new System.Drawing.Size(231, 20);
            this.textBox_rid.TabIndex = 14;
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
            this.panel_button.TabIndex = 24;
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
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(440, 464);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(133, 20);
            this.label7.TabIndex = 26;
            this.label7.Text = "Названия отеля";
            // 
            // comboBox_rtype
            // 
            this.comboBox_rtype.FormattingEnabled = true;
            this.comboBox_rtype.Location = new System.Drawing.Point(171, 538);
            this.comboBox_rtype.Name = "comboBox_rtype";
            this.comboBox_rtype.Size = new System.Drawing.Size(231, 21);
            this.comboBox_rtype.TabIndex = 28;
            // 
            // comboBox_rstatus
            // 
            this.comboBox_rstatus.FormattingEnabled = true;
            this.comboBox_rstatus.Location = new System.Drawing.Point(171, 609);
            this.comboBox_rstatus.Name = "comboBox_rstatus";
            this.comboBox_rstatus.Size = new System.Drawing.Size(231, 21);
            this.comboBox_rstatus.TabIndex = 29;
            // 
            // comboBox_rhn
            // 
            this.comboBox_rhn.FormattingEnabled = true;
            this.comboBox_rhn.Location = new System.Drawing.Point(579, 463);
            this.comboBox_rhn.Name = "comboBox_rhn";
            this.comboBox_rhn.Size = new System.Drawing.Size(231, 21);
            this.comboBox_rhn.TabIndex = 30;
            // 
            // comboBox_rno
            // 
            this.comboBox_rno.FormattingEnabled = true;
            this.comboBox_rno.Location = new System.Drawing.Point(171, 501);
            this.comboBox_rno.Name = "comboBox_rno";
            this.comboBox_rno.Size = new System.Drawing.Size(231, 21);
            this.comboBox_rno.TabIndex = 31;
            // 
            // RoomForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(930, 750);
            this.Controls.Add(this.comboBox_rno);
            this.Controls.Add(this.comboBox_rhn);
            this.Controls.Add(this.comboBox_rstatus);
            this.Controls.Add(this.comboBox_rtype);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.panel_button);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox_rph);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_rid);
            this.Controls.Add(this.dgv_room);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RoomForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RoomForm";
            this.Load += new System.EventHandler(this.RoomForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_room)).EndInit();
            this.panel_button.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2HtmlLabel Label_exit;
        private System.Windows.Forms.Label label6;
        private Guna.UI2.WinForms.Guna2DataGridView dgv_room;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_rph;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_rid;
        private System.Windows.Forms.Panel panel_button;
        private Guna.UI2.WinForms.Guna2Button Button_add;
        private Guna.UI2.WinForms.Guna2Button Button_edit;
        private Guna.UI2.WinForms.Guna2Button Button_delete;
        private Guna.UI2.WinForms.Guna2Button Button_clean;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboBox_rtype;
        private System.Windows.Forms.ComboBox comboBox_rstatus;
        private System.Windows.Forms.ComboBox comboBox_rhn;
        private System.Windows.Forms.ComboBox comboBox_rno;
    }
}