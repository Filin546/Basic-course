
namespace Hotel_Management_System
{
    partial class RecordForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RecordForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.Label_exit = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox_hotel = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox_room = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label_free = new System.Windows.Forms.Label();
            this.label_roomtype = new System.Windows.Forms.Label();
            this.label_price = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox_fio = new System.Windows.Forms.TextBox();
            this.dateTimePicker_dateEntry = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker_departureDate = new System.Windows.Forms.DateTimePicker();
            this.Button_book = new Guna.UI2.WinForms.Guna2Button();
            this.panel1.SuspendLayout();
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
            this.panel1.TabIndex = 35;
            // 
            // Label_exit
            // 
            this.Label_exit.BackColor = System.Drawing.Color.Transparent;
            this.Label_exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Label_exit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Label_exit.Location = new System.Drawing.Point(910, 0);
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
            this.label6.Location = new System.Drawing.Point(314, 21);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(301, 29);
            this.label6.TabIndex = 11;
            this.label6.Text = "Онлайн-запись комнаты";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 24);
            this.label1.TabIndex = 36;
            this.label1.Text = "Гостиницы";
            // 
            // comboBox_hotel
            // 
            this.comboBox_hotel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBox_hotel.FormattingEnabled = true;
            this.comboBox_hotel.Location = new System.Drawing.Point(164, 84);
            this.comboBox_hotel.Name = "comboBox_hotel";
            this.comboBox_hotel.Size = new System.Drawing.Size(278, 24);
            this.comboBox_hotel.TabIndex = 37;
            this.comboBox_hotel.SelectedIndexChanged += new System.EventHandler(this.comboBox_hotel_SelectedIndexChanged_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(12, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 24);
            this.label2.TabIndex = 38;
            this.label2.Text = "Свободно";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(12, 168);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 24);
            this.label3.TabIndex = 39;
            this.label3.Text = "Комнаты";
            // 
            // comboBox_room
            // 
            this.comboBox_room.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBox_room.FormattingEnabled = true;
            this.comboBox_room.Location = new System.Drawing.Point(164, 168);
            this.comboBox_room.Name = "comboBox_room";
            this.comboBox_room.Size = new System.Drawing.Size(278, 24);
            this.comboBox_room.TabIndex = 40;
            this.comboBox_room.SelectedIndexChanged += new System.EventHandler(this.comboBox_room_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(12, 210);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(126, 24);
            this.label4.TabIndex = 41;
            this.label4.Text = "Тип комнаты";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(12, 252);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 24);
            this.label5.TabIndex = 42;
            this.label5.Text = "Цена";
            // 
            // label_free
            // 
            this.label_free.AutoSize = true;
            this.label_free.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_free.Location = new System.Drawing.Point(164, 130);
            this.label_free.Name = "label_free";
            this.label_free.Size = new System.Drawing.Size(0, 16);
            this.label_free.TabIndex = 43;
            // 
            // label_roomtype
            // 
            this.label_roomtype.AutoSize = true;
            this.label_roomtype.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_roomtype.Location = new System.Drawing.Point(164, 210);
            this.label_roomtype.Name = "label_roomtype";
            this.label_roomtype.Size = new System.Drawing.Size(0, 24);
            this.label_roomtype.TabIndex = 44;
            // 
            // label_price
            // 
            this.label_price.AutoSize = true;
            this.label_price.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_price.Location = new System.Drawing.Point(164, 252);
            this.label_price.Name = "label_price";
            this.label_price.Size = new System.Drawing.Size(0, 24);
            this.label_price.TabIndex = 45;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(12, 300);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 24);
            this.label7.TabIndex = 46;
            this.label7.Text = "ФИО ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(12, 347);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(129, 24);
            this.label8.TabIndex = 47;
            this.label8.Text = "Дата въезда ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(12, 399);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(126, 24);
            this.label9.TabIndex = 48;
            this.label9.Text = "Дата выезда";
            // 
            // textBox_fio
            // 
            this.textBox_fio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_fio.Location = new System.Drawing.Point(164, 301);
            this.textBox_fio.Name = "textBox_fio";
            this.textBox_fio.Size = new System.Drawing.Size(278, 22);
            this.textBox_fio.TabIndex = 49;
            // 
            // dateTimePicker_dateEntry
            // 
            this.dateTimePicker_dateEntry.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker_dateEntry.Location = new System.Drawing.Point(164, 349);
            this.dateTimePicker_dateEntry.Name = "dateTimePicker_dateEntry";
            this.dateTimePicker_dateEntry.Size = new System.Drawing.Size(278, 20);
            this.dateTimePicker_dateEntry.TabIndex = 50;
            // 
            // dateTimePicker_departureDate
            // 
            this.dateTimePicker_departureDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker_departureDate.Location = new System.Drawing.Point(164, 403);
            this.dateTimePicker_departureDate.Name = "dateTimePicker_departureDate";
            this.dateTimePicker_departureDate.Size = new System.Drawing.Size(278, 20);
            this.dateTimePicker_departureDate.TabIndex = 51;
            // 
            // Button_book
            // 
            this.Button_book.CheckedState.Parent = this.Button_book;
            this.Button_book.CustomImages.Parent = this.Button_book;
            this.Button_book.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Button_book.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Button_book.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Button_book.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Button_book.DisabledState.Parent = this.Button_book;
            this.Button_book.FillColor = System.Drawing.Color.Black;
            this.Button_book.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Button_book.ForeColor = System.Drawing.Color.White;
            this.Button_book.HoverState.Parent = this.Button_book;
            this.Button_book.Image = ((System.Drawing.Image)(resources.GetObject("Button_book.Image")));
            this.Button_book.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Button_book.ImageSize = new System.Drawing.Size(40, 40);
            this.Button_book.Location = new System.Drawing.Point(0, 641);
            this.Button_book.Name = "Button_book";
            this.Button_book.ShadowDecoration.Parent = this.Button_book;
            this.Button_book.Size = new System.Drawing.Size(170, 108);
            this.Button_book.TabIndex = 54;
            this.Button_book.Text = "Забронировать";
            this.Button_book.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Button_book.Click += new System.EventHandler(this.Button_book_Click);
            // 
            // RecordForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(930, 750);
            this.Controls.Add(this.Button_book);
            this.Controls.Add(this.dateTimePicker_departureDate);
            this.Controls.Add(this.dateTimePicker_dateEntry);
            this.Controls.Add(this.textBox_fio);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label_price);
            this.Controls.Add(this.label_roomtype);
            this.Controls.Add(this.label_free);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboBox_room);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBox_hotel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RecordForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.RecordForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2HtmlLabel Label_exit;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox_hotel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox_room;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label_free;
        private System.Windows.Forms.Label label_roomtype;
        private System.Windows.Forms.Label label_price;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBox_fio;
        private System.Windows.Forms.DateTimePicker dateTimePicker_dateEntry;
        private System.Windows.Forms.DateTimePicker dateTimePicker_departureDate;
        private Guna.UI2.WinForms.Guna2Button Button_book;
    }
}