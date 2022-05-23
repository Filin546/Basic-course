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
    public partial class RegisterForm : Form
    {
        DBConnect connect = new DBConnect();

        public RegisterForm()
        {
            InitializeComponent();

            //Устанавливается для объекта KeyPreviewзначение true, чтобы разрешить форме обрабатывать 
            //ключ до того, как элемент управления с фокусом обработает его
            this.KeyPreview = true;
        }

        //Закрытие приложения
        private void Label_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //Переход в LoginForm
        private void registration_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm login = new LoginForm();
            login.Show();
        }

        //Реализация регистрации пользователя по кнопки 
        private void Button_register_Click(object sender, EventArgs e)
        {
            //Проверка ввода данных
            if (TextBox_username.Text == "" || TextBox_username.Text == "Введите логин" || TextBox_password.Text == "" || TextBox_password.Text == "Введите пароль" || TextBox_fio.Text == "" || TextBox_fio.Text == "Введите ФИО" || TextBox_telephone.Text == "" || TextBox_telephone.Text == "Введите телефон" || TextBox_mail.Text == "" || TextBox_mail.Text == "Введите почту" || TextBox_address.Text == "" || TextBox_address.Text == "Введите адресс проживания")
            {
                MessageBox.Show("Вы ввели не всю информацию. Заполните все поля");
                return;
            }

            if (checkUser())
                return;

            MySqlCommand command = new MySqlCommand("INSERT INTO `users`(`FIO`, `Telephone`, `Mail`, `Address`, `UserName`, `Password`) VALUES  (@fio, @tel, @mail, @addr, @usn, @pass)", connect.GetCon());

            command.Parameters.Add("@fio", MySqlDbType.VarChar).Value = TextBox_fio.Text;
            command.Parameters.Add("@tel", MySqlDbType.VarChar).Value = TextBox_telephone.Text;
            command.Parameters.Add("@mail", MySqlDbType.VarChar).Value = TextBox_mail.Text;
            command.Parameters.Add("@addr", MySqlDbType.VarChar).Value = TextBox_address.Text;
            command.Parameters.Add("@usn", MySqlDbType.VarChar).Value = TextBox_username.Text;
            command.Parameters.Add("@pass", MySqlDbType.VarChar).Value = TextBox_password.Text;

            connect.OpenCon();

            if ((TextBox_username.TextLength < 3) || (TextBox_password.TextLength < 3))
            {
                label_log_pass.Text = "Проверьте пароль или логин. Минимальная длина 3 символа.";
                label_login.Text = null; 
                label_password.Text = null;
            }
            else
            {
                if ((TextBox_username.TextLength > 20) || (TextBox_password.TextLength > 20))
                { 
                    label_log_pass.Text = "Проверьте пароль или логин. Максимальная длина 20 символов.";
                    label_login.Text = null;
                    label_password.Text = null;
                }
                else
                {
                    if (command.ExecuteNonQuery() == 1 )
                    {
                        MessageBox.Show("Аккаунт был создан");
                        ProfileClass.Repository.GetUser(TextBox_username.Text);//Запоминает данные введенные из TextBox_username для профиля
                        if (ProfileClass.Repository.user != null)
                        {
                            //Открывает UserForm после удачной регистрации 
                            this.Hide();
                            UserForm userForm = new UserForm();
                            userForm.Show();
                        }
                    }
                    else
                        MessageBox.Show("Аккаунт не был создан");
                }
            }
        }

        //Проверка сущесвтующий логинов в базе данных
        public Boolean checkUser()
        {
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand command = new MySqlCommand("SELECT * FROM `users` WHERE `UserName` = @usn ", connect.GetCon());

            command.Parameters.Add("@usn", MySqlDbType.VarChar).Value = TextBox_username.Text;

            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count > 0)
            {
                MessageBox.Show("Такой логи уже есть. Введите другой");
                return true;
            }
            else
                return false;
        }

        private void RegisterForm_Load(object sender, EventArgs e)
        {
            //По умолчанию пароль скрыт
            TextBox_password.UseSystemPasswordChar = true;
        }

        private void TextBox_username_KeyPress(object sender, KeyPressEventArgs e)
        {
            label_log_pass.Text = null;
            if (TextBox_username.TextLength < 3)
            {
                label_login.Text = "Длина логина меньше допустимой.\nМинимальная длина 3 символа.";
            }
            else
                if ((TextBox_username.TextLength == 3) && (TextBox_username.TextLength <= 20))
            {
                label_login.Text = "Длина логина корректная";
            }
            else
                    if (TextBox_username.TextLength > 20)
            {
                label_login.Text = "Длина логина превышает допустимую.\nМаксимальная длина 20 символов.";
            }
        }

        private void TextBox_password_KeyPress(object sender, KeyPressEventArgs e)
        {
            label_log_pass.Text = null;
            if (TextBox_password.TextLength < 3)
            {
                label_password.Text = "Длина пароля меньше допустимой.\nМинимальная длина 3 символа.";
            }
            else
                if ((TextBox_password.TextLength == 3) && (TextBox_password.TextLength <= 20))
            {
                label_password.Text = "Длина пароля корректная";
            }
            else
                    if (TextBox_password.TextLength > 20)
            {
                label_password.Text = "Длина пароля превышает допустимую.\nМаксимальная длина 20 символов.";
            }
        }

        private void pictureBox8_MouseDown(object sender, MouseEventArgs e)
        {
            TextBox_password.UseSystemPasswordChar = false;
        }

        private void pictureBox8_MouseUp(object sender, MouseEventArgs e)
        {
            TextBox_password.UseSystemPasswordChar = true;
        }

        ToolTip toolTip = new ToolTip();

        //Реализация подсказки
        private void TextBox_username_MouseHover(object sender, EventArgs e)
        {
            toolTip.SetToolTip(TextBox_username, "Введите\nваш логин");
            toolTip.IsBalloon = true;
        }

        private void TextBox_password_MouseHover(object sender, EventArgs e)
        {
            toolTip.SetToolTip(TextBox_password, "Введите\nваш пароль");
            toolTip.IsBalloon = true;
        }

        private void TextBox_fio_MouseHover(object sender, EventArgs e)
        {
            toolTip.SetToolTip(TextBox_fio, "Введите\nваше ФИО");
            toolTip.IsBalloon = true;     
        }

        private void TextBox_telephone_MouseHover(object sender, EventArgs e)
        {
            toolTip.SetToolTip(TextBox_telephone, "Введите\nваш телефон");
            toolTip.IsBalloon = true;
        }

        private void TextBox_mail_MouseHover(object sender, EventArgs e)
        {
            toolTip.SetToolTip(TextBox_mail, "Введите\nвашу почту");
            toolTip.IsBalloon = true;
        }

        private void TextBox_address_MouseHover(object sender, EventArgs e)
        {
            toolTip.SetToolTip(TextBox_address, "Введите\nваш адрес проживания");
            toolTip.IsBalloon = true;
        }

        //Реализация регистрации по нажатию на Enter
        private void RegisterForm_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Button_register.PerformClick();
            }
        }
    }
}
