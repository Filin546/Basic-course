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
    public partial class HotelForm : Form
    {
        //Подключения класса HotelClass
        HotelClass hotel = new HotelClass();
        public HotelForm()
        {
            InitializeComponent();
        }

        //Закрытие приложения
        private void Label_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //Отображает данные в dgv_UserHotel
        private void getRoomList()
        {
            dgv_UserHotel.DataSource = hotel.getRoomList();
        }

        private void UserHotelForm_Load(object sender, EventArgs e)
        {
            //Чтобы отобразить список гостиницы в Datagridview
            getRoomList();

            //Задает цвет строки в dgv_UserHotel
            dgv_UserHotel.DefaultCellStyle.ForeColor = Color.Black;
        }

    }
}