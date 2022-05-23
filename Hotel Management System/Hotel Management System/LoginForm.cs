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
    public partial class LoginForm : Form
    {
		//Подключения класса DBConnect
		DBConnect connect = new DBConnect();

		ToolTip toolTip = new ToolTip();

		public LoginForm()
        {
            InitializeComponent();

			//Устанавливается для объекта KeyPreviewзначение true, чтобы разрешить форме обрабатывать 
			//ключ до того, как элемент управления с фокусом обработает его
			this.KeyPreview = true;
		}

		//Реализация кнопки входа в приложение 
		private void Button_login_Click(object sender, EventArgs e)
		{
			MySqlDataAdapter sda = new MySqlDataAdapter("SELECT `UserName` FROM `users` WHERE `UserName`= '" + TextBox_username.Text + "'OR `Mail`='" + TextBox_username.Text + "'OR `Telephone`='" + TextBox_username.Text + "' AND `Password`= '" + TextBox_password.Text + "'", connect.GetCon());
			DataTable dt = new DataTable();
			sda.Fill(dt);

			//Проверка введенных данных в TextBox_username и TextBox_password с базой данных
			if (TextBox_username.Text.Trim().Equals("") || TextBox_password.Text == "")
				MessageBox.Show("Ваш логин или пароль не введены.\nЛибо введена неполная информация", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			else
			{
				if (dt.Rows.Count == 1)
				{
					 
					//this.Hide();
					//Реализация входа по ролям 
					string role = dt.Rows[0]["UserName"].ToString();
					switch (role)
					{
						case "Admin":
							AdminForm adminForm = new AdminForm();
							adminForm.Show();
							this.Hide();
							break;
						case "Manager":
							ManagerForm managerForm = new ManagerForm();
							managerForm.Show();
							this.Hide();
							break;
						case "Maid":
							MaidForm maidForm = new MaidForm();
							maidForm.Show();
							this.Hide();
							break;
						default:
							ProfileClass.Repository.GetUser(TextBox_username.Text);//Запоминает данные введенные из TextBox_username для профиля
							if (ProfileClass.Repository.user != null)
							{
								UserForm userForm = new UserForm();
								userForm.Show();
								this.Hide();
							}
							break;
					}
				}
				else
					MessageBox.Show("Введены неправильные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		//Закрытие приложения
		private void Label_exit_Click(object sender, EventArgs e)
        {
			Application.Exit();
        }

		//Переход на RegisterForm для регистрации
		private void registration_Click(object sender, EventArgs e)
        {
			this.Hide();
			RegisterForm register = new RegisterForm();
			register.Show();
		}

		//Срытие пароля 
        private void pictureBox4_MouseDown(object sender, MouseEventArgs e)
        {
			TextBox_password.UseSystemPasswordChar = false;
		}

		//Показывает пароль на ножатие на картинку  
        private void pictureBox4_MouseUp(object sender, MouseEventArgs e)
        {
			TextBox_password.UseSystemPasswordChar = true;
		}

		//Переход на RecoveryForm для смены пароля 
		private void Label_PasswordRecovery_Click(object sender, EventArgs e)
        {
			RecoveryForm recovery = new RecoveryForm();
			recovery.Show();
			this.Hide();
		}


        private void TextBox_username_Enter(object sender, EventArgs e)
        {
			TextBox_username.Text = null;
			TextBox_username.ForeColor = Color.Black;
		}

		//Реализация входа по нажатию на Enter
		private void LoginForm_KeyUp(object sender, KeyEventArgs e)
        {
			if (e.KeyCode == Keys.Enter)
			{
				Button_login.PerformClick();
			}
		}

		//Реализация подсказки
		private void TextBox_username_MouseHover(object sender, EventArgs e)
        {
			toolTip.SetToolTip(TextBox_username, "Введите\nваш логин/почту/телефон");
			toolTip.IsBalloon = true;
		}

        private void LoginForm_Load(object sender, EventArgs e)
        {
			//По умолчанию пароль скрыт
			TextBox_password.UseSystemPasswordChar = true;
		}
    }
}
