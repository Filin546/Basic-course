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
    public partial class UserRoomForm : Form
    {
        //Подключения класса UserRoomClass
        UserRoomClass room = new UserRoomClass();
        public UserRoomForm()
        {
            InitializeComponent();
        }

        private void UserRoomForm_Load(object sender, EventArgs e)
        {
            //Чтобы отобразить список комнат в Datagridview
            getRoomList();

            //Задает цвет строки в dgv_UserRoom
            dgv_UserRoom.DefaultCellStyle.ForeColor = Color.Black;
        }

        //Отображает данные в dgv_UserRoom
        private void getRoomList()
        {
            dgv_UserRoom.DataSource = room.getRoomList();
        }

        //Закрытие приложения
        private void Label_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
