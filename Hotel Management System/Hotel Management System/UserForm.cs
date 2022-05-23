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
    public partial class UserForm : Form
    {
        public UserForm()
        {
            InitializeComponent();
        }

        //Закрытие приложения
        private void Label_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //Реализация открытия HotelForm по кнопке
        private void Button_guest_Click(object sender, EventArgs e)
        {
            //По нажитию на кнопку panel_slide перемещается к кнопке Button_guest 
            panel_slide.Height = Button_guest.Height;
            panel_slide.Top = Button_guest.Top;

            //По нажатию кнопки HotelForm открывается в Panel_admin
            //и закрывваает в Panel_admin окно, которое до нажитии было открыто 
            Panel_admin.Controls.Clear();
            HotelForm hotel = new HotelForm();
            hotel.TopLevel = false;
            hotel.Dock = DockStyle.Fill;
            hotel.FormBorderStyle = FormBorderStyle.None;
            Panel_admin.Controls.Add(hotel);
            hotel.Show();
        }

        //Реализация открытия UserRoomForm по кнопке
        private void Button_room_Click(object sender, EventArgs e)
        {
            //По нажитию на кнопку panel_slide перемещается к кнопку Button_room 
            panel_slide.Height = Button_room.Height;
            panel_slide.Top = Button_room.Top;

            //По нажатию кнопки UserRoomForm открывается в Panel_admin
            //и закрывваает в Panel_admin окно, которое до нажитии было открыто 
            Panel_admin.Controls.Clear();
            UserRoomForm room = new UserRoomForm();
            room.TopLevel = false;
            room.Dock = DockStyle.Fill;
            room.FormBorderStyle = FormBorderStyle.None;
            Panel_admin.Controls.Add(room);
            room.Show();
        }

        //Реализация открытия ProfileForm по кнопке
        private void Button_Profile_Click(object sender, EventArgs e)
        {
            //По нажитию на кнопку panel_slide перемещается к кнопку Button_Profile 
            panel_slide.Height = Button_Profile.Height;
            panel_slide.Top = Button_Profile.Top;

            //По нажатию кнопки ProfileForm открывается в Panel_admin
            //и закрывваает в Panel_admin окно, которое до нажитии было открыто 
            Panel_admin.Controls.Clear();
            ProfileForm profile = new ProfileForm();
            profile.TopLevel = false;
            profile.Dock = DockStyle.Fill;
            profile.FormBorderStyle = FormBorderStyle.None;
            Panel_admin.Controls.Add(profile);
            profile.Show();
        }

        //Реализация выхода из системы по кнопкее
        private void Button_logout_Click_1(object sender, EventArgs e)
        {
            //По нажитию на кнопку panel_slide перемещается к кнопку Button_logout
            panel_slide.Height = Button_logout.Height;
            panel_slide.Top = Button_logout.Top;

            //По нажитию на кнопку переходит в LoginForm
            //и закрывает окно UserForm
            this.Hide();
            LoginForm login = new LoginForm();
            login.Show();
        }

        //Реализация открытия RecordForm по кнопке
        private void Button_record_Click(object sender, EventArgs e)
        {
            //По нажитию на кнопку panel_slide перемещается к кнопку Button_record
            panel_slide.Height = Button_record.Height;
            panel_slide.Top = Button_record.Top;

            //По нажатию кнопки HotelForm открывается в Panel_admi
            //и закрывваает в Panel_admin окно, которое до нажитии было открыто 
            Panel_admin.Controls.Clear();
            RecordForm record = new RecordForm();
            record.TopLevel = false;
            record.Dock = DockStyle.Fill;
            record.FormBorderStyle = FormBorderStyle.None;
            Panel_admin.Controls.Add(record);
            record.Show();
        }
    }
}
