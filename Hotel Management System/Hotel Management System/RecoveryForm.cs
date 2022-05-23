using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Hotel_Management_System
{
    public partial class RecoveryForm : Form
    {
        //Подключения класса DBConnect
        DBConnect connect = new DBConnect();

        public RecoveryForm()
        {
            InitializeComponent();

            //Устанавливается для объекта KeyPreviewзначение true, чтобы разрешить форме обрабатывать 
            //ключ до того, как элемент управления с фокусом обработает его
            this.KeyPreview = true;
        }

        //Реализация восстановления пароля по кнопке 
        private void Button_recovery_Click(object sender, EventArgs e)
        {
            MySqlCommand command = new MySqlCommand("UPDATE `users` SET `password`=@pass WHERE `Telephone`=@login OR `UserName`= @login OR `Mail`= @login", connect.GetCon());

            command.Parameters.Add("@login", MySqlDbType.VarChar).Value = TextBox_username.Text;
            command.Parameters.Add("@pass", MySqlDbType.VarChar).Value = TextBox_password.Text;

            connect.OpenCon();

            if (UserVerification())
            {
                if (TextBox_checkpassword.TextLength < 3)
                {
                    label_password.Text = "Проверьте пароль или логин.\nМинимальная длина 3 символа.";
                    label_checkpassword.Text = null;
                }
                else
                {
                    if (TextBox_checkpassword.TextLength > 20)
                    {
                        label_password.Text = "Проверьте пароль или логин\nМаксимальная длина 20 символов.";
                        label_checkpassword.Text = null;
                    }
                    else
                    {
                        if (TextBox_checkpassword.Text == TextBox_password.Text)
                        {
                            if (command.ExecuteNonQuery() == 1)
                            {
                                MessageBox.Show("Пароль восстановлен");
                                this.Hide();
                                LoginForm login = new LoginForm();
                                login.Show();
                            }
                            else
                                MessageBox.Show("Пароль не восстановлен");
                        }
                        else
                        {
                            MessageBox.Show("Неправильно введены данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
        }

        //Закрытие приложения
        private void Label_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //Переход на LoginForm
        private void Label_entrance_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm login = new LoginForm();
            login.Show();
        }

        //Проверка пользователя по логину
        public Boolean UserVerification()
        {
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand command = new MySqlCommand("SELECT * FROM `users` WHERE `Telephone` = @login OR `UserName`= @login OR `Mail`= @login", connect.GetCon());

            command.Parameters.Add("@login", MySqlDbType.VarChar).Value = TextBox_username.Text;
            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count > 0)
            {
                return true;
            }
            else
                MessageBox.Show("Таких данных не существуют", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return false;
        }

        //Огнаричения символов для пароля 
        private void TextBox_checkpassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (TextBox_checkpassword.TextLength < 3)
            {
                label_checkpassword.Text = "Длина пароля меньше допустимой.\nМинимальная длина 3 символа.";
            }
            else
                if ((TextBox_checkpassword.TextLength == 3) && (TextBox_checkpassword.TextLength <= 20))
            {
                label_checkpassword.Text = "Длина пароля корректная";
            }
            else
                    if (TextBox_checkpassword.TextLength > 20)
            {
                label_checkpassword.Text = "Длина пароля превышает допустимую.\nМаксимальная длина 20 символов.";
            }
        }

        //Реализация входа по нажатию на Enter
        private void RecoveryForm_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Button_recovery.PerformClick();
            }
        }
    }
}
