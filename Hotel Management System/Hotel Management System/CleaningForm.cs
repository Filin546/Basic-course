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
    public partial class CleaningForm : Form
    {
        //Подключения класса CleaningClass
        CleaningClass cleaning = new CleaningClass();

        public CleaningForm()
        {
            InitializeComponent();
        }

        //Закрытие приложения
        private void Label_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //Отображает данные в dgv_cleaning
        private void getCleaningList()
        {
            dgv_cleaning.DataSource = cleaning.getCleaningList();
        }

        //Показывает данные по клику на любую часть ячейки
        private void dgv_cleaning_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox_cleaningrid.Text = dgv_cleaning.CurrentRow.Cells[0].Value.ToString();
            comboBox_roomn.Text = dgv_cleaning.CurrentRow.Cells[1].Value.ToString();
            comboBox_cleaningc.Text = dgv_cleaning.CurrentRow.Cells[2].Value.ToString();
            comboBox_typesc.Text = dgv_cleaning.CurrentRow.Cells[3].Value.ToString();
            dateTimePicker_dlc.Text = dgv_cleaning.CurrentRow.Cells[4].Value.ToString();
        }


        private void CleaningForm_Load(object sender, EventArgs e)
        {
            //Предоставление текущего времени
            dateTimePicker_dlc.MinDate = DateTime.Now;

            //Чтобы отобразить номер комнат в выпадающем списке
            comboBox_roomn.DataSource = cleaning.getCleaningRoom();
            comboBox_roomn.DisplayMember = "RoomNo";
            comboBox_roomn.ValueMember = "RoomId";

            //Чтобы отобразить категорию очистки в выпадающем списке
            comboBox_cleaningc.DataSource = cleaning.getCleaningСategory();
            comboBox_cleaningc.DisplayMember = "CleaningСategory";
            comboBox_cleaningc.ValueMember = "CleaningId";

            //Чтобы отобразить виды очистки в выпадающем списке
            comboBox_typesc.DataSource = cleaning.getCleaningTypes();
            comboBox_typesc.DisplayMember = "TypesCleaning";
            comboBox_typesc.ValueMember = "CleaningId";

            //Чтобы отобразить список комнат в Datagridview
            getCleaningList();

            //Задает цвет строки в dgv_cleaning
            dgv_cleaning.DefaultCellStyle.ForeColor = Color.Black;
        }

        //Реализация кнопки сохранения 
        private void Button_add_Click(object sender, EventArgs e)
        {
            try
            {
                string cid = textBox_cleaningrid.Text;
                string roomn = comboBox_roomn.Text;
                string ccategory = comboBox_cleaningc.Text;
                string typesc = comboBox_typesc.Text;
                DateTime dlc = dateTimePicker_dlc.Value;

                //Ипользования функции addCleaning из класса CleaningClass
                if (cleaning.addCleaning(cid, roomn, ccategory, typesc, dlc))
                {
                    MessageBox.Show("Уборка успешно добавлено", "Добавлена уборка", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    
                    getCleaningList();
                }
                else
                {
                    MessageBox.Show("Уборка не было успешно добавлено", "Уборка не добавлена", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //Реализация кнопки редактирования 
        private void Button_edit_Click_1(object sender, EventArgs e)
        {
            try
            {
                string cid = textBox_cleaningrid.Text;
                string roomn = comboBox_roomn.Text;
                string ccategory = comboBox_cleaningc.Text;
                string typesc = comboBox_typesc.Text;
                DateTime dlc = dateTimePicker_dlc.Value;

                //Ипользования функции editCleaning из класса CleaningClass
                Boolean editQuerry = cleaning.editCleaning(cid, roomn, ccategory, typesc, dlc);

                if (editQuerry)
                {
                    MessageBox.Show("Уборка успешно обновлено", "Уборка обновлена", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    getCleaningList();
                    Button_clean.PerformClick();
                }
                else
                {
                    MessageBox.Show("Уборка не обновляется", "Уборка не обновлено", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //Реализация кнопки удаление 
        private void Button_delete_Click_1(object sender, EventArgs e)
        {
            try
            {
                string rid = textBox_cleaningrid.Text;

                //Ипользования функции removeCleaning из класса CleaningClass
                Boolean deleteQuerry = cleaning.removeCleaning(rid);
                if (deleteQuerry)
                {
                    MessageBox.Show("Уборка удалена успешна", "Уборка удалена", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    getCleaningList();
                    Button_clean.PerformClick();
                }
                else
                {
                    MessageBox.Show("ОШИБКА - уборка не удалено", "Ошибка удаления", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //Реализация кнопки очистка 
        private void Button_clean_Click_1(object sender, EventArgs e)
        {
            textBox_cleaningrid.Clear();
            comboBox_roomn.SelectedIndex = -1;
            comboBox_cleaningc.SelectedIndex = -1;
            comboBox_typesc.SelectedIndex = -1;
        }
    }
}
