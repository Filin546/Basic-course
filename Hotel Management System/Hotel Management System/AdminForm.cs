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
    public partial class AdminForm : Form
    {
        public AdminForm()
        {
            InitializeComponent();
        }

        //Реализация открытия GuestForm по кнопке
        private void Button_guest_Click(object sender, EventArgs e)
        {
            //Перемещение panel_slide 
            panel_slide.Height = Button_guest.Height;
            panel_slide.Top = Button_guest.Top;

            //Очистка Panel_admin
            Panel_admin.Controls.Clear();

            //Открытие GuestForm в Panel_admin
            GuestForm guest = new GuestForm();
            guest.TopLevel = false;
            guest.Dock = DockStyle.Fill;
            guest.FormBorderStyle = FormBorderStyle.None;
            Panel_admin.Controls.Add(guest);
            guest.Show();
        }

        //Реализация открытия ReceptionForm по кнопке
        private void Button_reception_Click(object sender, EventArgs e)
        {
            //Перемещение panel_slide 
            panel_slide.Height = Button_reception.Height;
            panel_slide.Top = Button_reception.Top;

            //Очистка Panel_admin
            Panel_admin.Controls.Clear();

            //Открытие ReceptionForm в Panel_admin
            ReceptionForm reception = new ReceptionForm();
            reception.TopLevel = false;
            reception.Dock = DockStyle.Fill;
            reception.FormBorderStyle = FormBorderStyle.None;
            Panel_admin.Controls.Add(reception);
            reception.Show(); 
        }

        //Реализация открытия RoomForm по кнопке
        private void Button_room_Click(object sender, EventArgs e)
        {
            //Перемещение panel_slide 
            panel_slide.Height = Button_room.Height;
            panel_slide.Top = Button_room.Top;

            //Очистка Panel_admin
            Panel_admin.Controls.Clear();

            //Открытие RoomForm в Panel_admin
            RoomForm room = new RoomForm();
            room.TopLevel = false;
            room.Dock = DockStyle.Fill;
            room.FormBorderStyle = FormBorderStyle.None;
            Panel_admin.Controls.Add(room);
            room.Show();
        }

        //Реализация выхода из системы по кнопке
        private void Button_logout_Click(object sender, EventArgs e)
        {
            //Перемещение panel_slide 
            panel_slide.Height = Button_logout.Height;
            panel_slide.Top = Button_logout.Top;

            //Выход из системы
            this.Hide();
            LoginForm login = new LoginForm();
            login.Show();
        }

        private void Button_dashboard_Click(object sender, EventArgs e)
        {
            //Перемещение panel_slide 
            panel_slide.Height = Button_dashboard.Height;
            panel_slide.Top = Button_dashboard.Top;

            //Очистка Panel_admin
            Panel_admin.Controls.Clear();

            //Открытие Panel_cover в Panel_admin
            Panel_admin.Controls.Add(Panel_cover);
        }

        //Закрытие приложения
        private void Label_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
