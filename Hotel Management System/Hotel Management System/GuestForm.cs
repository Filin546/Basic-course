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
	public partial class GuestForm : Form
	{
		//Подключения класса GuestClass
		GuestClass guest = new GuestClass();

		public GuestForm()
		{
			InitializeComponent();
		}

		//Реализация кнопки очистка 
		private void Button_clean_Click(object sender, EventArgs e)
		{
			textBox_gid.Clear();
			comboBox_uname.SelectedIndex = -1;
			textBox_fio.Clear();
			textBox_phone.Clear();
			textBox_city.Clear();
		}

		//Реализация кнопки сохранения 
		private void Button_add_Click(object sender, EventArgs e)
		{
			if (textBox_gid.Text == "" || textBox_fio.Text == "" || textBox_phone.Text == "")
			{
				MessageBox.Show("Обязательное поле - идентификационный номер, ФИО и номер телефона:", "Обязательное поле", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
			else
			{
				try
				{
					string gid = textBox_gid.Text;
					string uname = comboBox_uname.Text;
					string fio = textBox_fio.Text;
					string phone = textBox_phone.Text;
					string city = textBox_city.Text;

					Boolean insertGuest = guest.insertGuest(gid, uname, fio, phone, city);

					if (insertGuest)
					{
						MessageBox.Show("Новый гость успешно сохранен", "Гость сохранен", MessageBoxButtons.OK, MessageBoxIcon.Information);
						getTable();
						Button_clean.PerformClick();
					}
					else
					{
						MessageBox.Show("ОШИБКА - гость не вставлен", "Ошибка сохранения", MessageBoxButtons.OK, MessageBoxIcon.Information);
					}
				}
				catch (Exception ex)
				{
					MessageBox.Show(ex.Message);
				}
			}
		}

		//Закрытие приложения
		private void Label_exit_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		private void GuestForm_Load(object sender, EventArgs e)
		{
			//Чтобы отобразить имена пользователей в выпадающем списке
			comboBox_uname.DataSource = guest.getUserName();
			comboBox_uname.DisplayMember = "UserName";
			comboBox_uname.ValueMember = "Id";

			//Чтобы отобразить список гостей в Datagridview
			getTable();

			//Задает цвет строки в dgvguest
			dgvguest.DefaultCellStyle.ForeColor = Color.Black;

		}

		//Отображает данные в dgvguest
		private void getTable()
		{
			dgvguest.DataSource = guest.getGuest();
		}

		//Реализация кнопки редактирования 
		private void Button_edit_Click(object sender, EventArgs e)
		{
			if (textBox_gid.Text == "" || comboBox_uname.Text == "" || textBox_fio.Text == "")
			{
				MessageBox.Show("Обязательное поле - идентификационный номер, имя пользователя и ФИО:", "Обязательное поле", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
			else
			{
				try
				{
					string gid = textBox_gid.Text;
					string uname = comboBox_uname.Text;
					string fio = textBox_fio.Text;
					string phone = textBox_phone.Text;
					string city = textBox_city.Text;

					Boolean editQuerry = guest.editGuest(gid, uname, fio, phone, city);

					if (editQuerry)
					{
						MessageBox.Show("Успешное обновление данных гостя", "Успешное обновление", MessageBoxButtons.OK, MessageBoxIcon.Information);
						getTable();
						Button_clean.PerformClick();
					}
					else
					{
						MessageBox.Show("ОШИБКА - данные гостя не обновляються", "Ошибка обновления", MessageBoxButtons.OK, MessageBoxIcon.Error);
					}
				}
				catch (Exception ex)
				{
					MessageBox.Show(ex.Message);
				}
			}

		}

		//Клик по любой части ячейки
		private void dgvguest_CellClick(object sender, DataGridViewCellEventArgs e)
        {
			textBox_gid.Text = dgvguest.CurrentRow.Cells[0].Value.ToString();
			comboBox_uname.Text = dgvguest.CurrentRow.Cells[1].Value.ToString();
			textBox_fio.Text = dgvguest.CurrentRow.Cells[2].Value.ToString();
			textBox_phone.Text = dgvguest.CurrentRow.Cells[3].Value.ToString();
			textBox_city.Text = dgvguest.CurrentRow.Cells[4].Value.ToString();
		}

		//Реализация кнопки удаление
		private void Button_delete_Click_1(object sender, EventArgs e)
        {
			if (textBox_gid.Text == "")
			{
				MessageBox.Show("Обязательное поле - идентификационный номер:", "Обязательное поле", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
			else
			{
				try
				{
					string gid = textBox_gid.Text;

					Boolean deleteQuerry = guest.removeGuest(gid);

					if (deleteQuerry)
					{
						MessageBox.Show("Гостевые данные успешно удалены", "Гость удален", MessageBoxButtons.OK, MessageBoxIcon.Information);
						getTable();
						Button_clean.PerformClick();
					}
					else
					{
						MessageBox.Show("ОШИБКА - гость не удален", "Ошибка удаления", MessageBoxButtons.OK, MessageBoxIcon.Error);
					}
				}
				catch (Exception ex)
				{
					MessageBox.Show(ex.Message);
				}
			}
		}

        private void textBox_sorting_TextChanged(object sender, EventArgs e)
        {
			//StrategyPattern Strategy = new StrategyPattern();
			
		}

        private void button1_Click(object sender, EventArgs e)
        {
			
		}

        /*//Реализация паттерн стратигия для сортировки 
		class Employee
		{
			public int GuestId { get; set; }
			public string UserName { get; set; }
			public override string ToString()
			{
				return string.Format("GuestId = {0}, UserName  = {1}", GuestId, UserName);
			}
		}
		class EmployeeByIdComparer : IComparer<Employee>
		{
			public int Compare(Employee x, Employee y)
			{
				return x.GuestId.CompareTo(y.GuestId);
			}
		}
		public static void SortLists()
		{
			var list = new List<Employee>();
			// Используем "функтор"
			list.Sort(new EmployeeByIdComparer());
			// Используем делегат
			list.Sort((x, y) => x.UserName.CompareTo(y.UserName));
		}*/
    }
}
