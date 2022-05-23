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
    public partial class MaidForm : Form
    {
        public MaidForm()
        {
            InitializeComponent();
        }

        private void Button_dashboard_Click(object sender, EventArgs e)
        {
            panel_slide.Height = Button_dashboard.Height;
            panel_slide.Top = Button_dashboard.Top;

            Panel_admin.Controls.Clear();

            //Открытие Panel_cover в Panel_admin
            Panel_admin.Controls.Add(Panel_cover);
        }

        //Реализация открытия CleaningForm по кнопке
        private void Button_cleaning_Click(object sender, EventArgs e)
        {
            panel_slide.Height = Button_cleaning.Height;
            panel_slide.Top = Button_cleaning.Top;

            Panel_admin.Controls.Clear();
            CleaningForm cleaning = new CleaningForm();
            cleaning.TopLevel = false;
            cleaning.Dock = DockStyle.Fill;
            cleaning.FormBorderStyle = FormBorderStyle.None;
            Panel_admin.Controls.Add(cleaning);
            cleaning.Show();
        }

        //Реализация выхода из системы по кнопке
        private void Button_logout_Click(object sender, EventArgs e)
        {
            panel_slide.Height = Button_logout.Height;
            panel_slide.Top = Button_logout.Top;

            this.Hide();
            LoginForm login = new LoginForm();
            login.Show();
        }

        //Закрытие приложения
        private void Label_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
