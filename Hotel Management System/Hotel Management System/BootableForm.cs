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
    public partial class BootableForm : Form
    {
        public BootableForm()
        {
            InitializeComponent();
        }

        //Запуск таймера 
        private void BootableForm_Load(object sender, EventArgs e)
        {
            timer.Start();
        }

        //Задаем значение startPoint
        int startPoint = 0;

        //Реализация счетчика для запуска таймера
        private void timer_Tick(object sender, EventArgs e)
        {
            startPoint += 1;
            ProgressBar.Maximum=100;
            ProgressBar.Value = startPoint;
            if (ProgressBar.Value == 100)
            {
                //Останавливает таймер и устанавливает значение ProgressBar = 0 
                timer.Stop();
                ProgressBar.Value = 0;

                //Открытие LoginForm
                LoginForm login = new LoginForm();
                this.Hide();
                login.Show();
            }
        }
    }
}
