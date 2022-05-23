using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel_Management_System
{
    public partial class RecordForm : Form
    {
        //Вызывается класс подключения в БД
        DBConnect connect = new DBConnect();

        //Вызывает класс RecordClass
        RecordClass record = new RecordClass();

        public RecordForm()
        {
            InitializeComponent();
        }

        private void RecordForm_Load(object sender, EventArgs e)
        {
            //Ограничения для даты 
            dateTimePicker_dateEntry.MinDate = DateTime.Now;
            dateTimePicker_departureDate.MinDate = DateTime.Now;

            //Вызывает метод из RecordClass для просмотра гостиниц
            comboBox_hotel.DataSource = record.getHotelNames();
            comboBox_hotel.DisplayMember = "HotelNames";

            //Показывает текст при запуске программы 
            comboBox_hotel.Text = "Выберите гостиницу";
            comboBox_room.Text = "";
            label_free.Text = "";
            label_roomtype.Text = "";
            label_price.Text = "";
        }

        private void comboBox_room_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Показывает тип конаты по выбору комнаты 
            string showRoomType = "SELECT `RoomType` FROM `room` WHERE `RoomNo` =  @room";
            MySqlCommand command = new MySqlCommand(showRoomType, connect.GetCon());
            command.Parameters.AddWithValue("@room", comboBox_room.Text);
            //Открывается соединение с БД
            connect.OpenCon();
            MySqlDataReader myReader = command.ExecuteReader();
            while (myReader.Read())
            {
                label_roomtype.Text = myReader.GetString(0);
            }
            myReader.Close();
            //Закрывается соединения с БД
            connect.CloseCon();

            //Показывает цену по типу категории 
            string showPrice = "SELECT category.Price FROM `category` INNER JOIN `room` ON category.Label =@roomtype";
            MySqlCommand command1 = new MySqlCommand(showPrice, connect.GetCon());
            command1.Parameters.AddWithValue("@roomtype", label_roomtype.Text);
            //Открывается соединение с БД
            connect.OpenCon();
            MySqlDataReader myReader1 = command1.ExecuteReader();
            while (myReader1.Read())
            {
                label_price.Text = myReader1.GetString(0);
            }
            myReader1.Close();
            //Закрывается соединения с БД
            connect.CloseCon();

        }

        private void comboBox_hotel_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            //Показывает количество сколько свободных комнат в гостинице
            string shownNumberRooms = "SELECT COUNT(`RoomStatus`) FROM `room` WHERE `RoomStatus` = 'Свободный' AND `HotelNames` = @hotel";
            MySqlCommand command = new MySqlCommand(shownNumberRooms, connect.GetCon());
            command.Parameters.AddWithValue("@hotel", comboBox_hotel.Text);
            //Открывается соединение с БД
            connect.OpenCon();
            label_free.Text = command.ExecuteScalar().ToString();
            //Закрывается соединения с БД
            connect.CloseCon();

            //Вызывает метод из класса для просмотра комнат 
            string Room = comboBox_hotel.Text;
            comboBox_room.DataSource = record.getRoom(Room);
            comboBox_room.DisplayMember = "RoomNo";
        }

        //Бронирование комнаты 
        private void Button_book_Click(object sender, EventArgs e)
        {
            try
            {
                string fiog = textBox_fio.Text;
                string recervro = comboBox_room.Text;
                DateTime din = dateTimePicker_dateEntry.Value;
                DateTime dout = dateTimePicker_departureDate.Value;

                if (record.addReception(fiog, recervro, din, dout))
                {
                    MessageBox.Show("Комната забронирована", "Успешно", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Комната не забронирована", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            //Изменение статуса комнаты
            string hotel = comboBox_hotel.Text;
            string roomt = comboBox_room.Text;
            //Передает данные в метод для изменения статуса комнаты 
            Boolean insertGuest = record.changeStatus(hotel, roomt);


            comboBox_hotel.Text = "Выберите гостиницу";
            label_free.Text ="";
            comboBox_room.SelectedIndex = -1;
            label_roomtype.Text = "";
            label_price.Text = "";
            textBox_fio.Clear();
        }

        private void Label_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
