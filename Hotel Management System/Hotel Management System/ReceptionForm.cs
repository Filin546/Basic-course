using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;

namespace Hotel_Management_System
{
    public partial class ReceptionForm : Form
    {
        ////Подключения класса ReceptionClass
        ReceptionClass reception = new ReceptionClass();

        public ReceptionForm()
        {
            InitializeComponent();
        }

        private void ReceptionForm_Load(object sender, EventArgs e)
        {
            //Предоставление текущего времени
            dateTimePicker_in.MinDate = DateTime.Now;
            dateTimePicker_out.MinDate = DateTime.Now;

            //Чтобы отобразить ФИО гостя в выпадающем списке
            comboBox_fiog.DataSource = reception.getReceptionGuestId();
            comboBox_fiog.DisplayMember = "GuestFullName";
            comboBox_fiog.ValueMember = "GuestId";

            //Чтобы отобразить номер комнаты в выпадающем списке
            comboBox_recervro.DataSource = reception.getReceptionRoom();
            comboBox_recervro.DisplayMember = "RoomNo";
            comboBox_recervro.ValueMember = "RoomId";

            //Чтобы отобразить список комнат в Datagridview
            getReceptionList();

            //Задает цвет строки в dgv_reservation
            dgv_reservation.DefaultCellStyle.ForeColor = Color.Black;
        }

        //Закрытие приложения
        private void Label_exit_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //Отображает данные в dgv_reservation
        private void getReceptionList()
        {
            dgv_reservation.DataSource = reception.getReceptionList();
        }

        //Показывает данные по клику на любую часть ячейки
        private void dgv_reservation_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox_recervid.Text = dgv_reservation.CurrentRow.Cells[0].Value.ToString();
            comboBox_fiog.Text = dgv_reservation.CurrentRow.Cells[1].Value.ToString();
            comboBox_recervro.Text = dgv_reservation.CurrentRow.Cells[2].Value.ToString();
            dateTimePicker_in.Text = dgv_reservation.CurrentRow.Cells[3].Value.ToString();
            dateTimePicker_out.Text = dgv_reservation.CurrentRow.Cells[4].Value.ToString();
        }

        //Реализация кнопки сохранения 
        private void Button_add_Click(object sender, EventArgs e)
        {
            try
            {
                string recervid = textBox_recervid.Text;
                string fiog = comboBox_fiog.Text;
                string recervro = comboBox_recervro.Text;
                DateTime din = dateTimePicker_in.Value;
                DateTime dout = dateTimePicker_out.Value;

                if (reception.addReception(recervid, fiog, recervro, din, dout))
                {
                    MessageBox.Show("Бронирование успешно добавлено", "Добавлена бронирование", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    getReceptionList();
                }
                else
                {
                    MessageBox.Show("Бронирование не было успешно добавлено", "Бронирование не добавлена", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //Реализация кнопки очистка 
        private void Button_clean_Click(object sender, EventArgs e)
        {
            textBox_recervid.Clear();
            comboBox_fiog.SelectedIndex = -1;
            comboBox_recervro.SelectedIndex = -1;
        }

        //Реализация кнопки редактирования 
        private void Button_edit_Click(object sender, EventArgs e)
        {
            try
            {
                string recervid = textBox_recervid.Text;
                string fiog = comboBox_fiog.Text;
                string recervro = comboBox_recervro.Text;
                DateTime din = dateTimePicker_in.Value;
                DateTime dout = dateTimePicker_out.Value;

                Boolean editQuerry = reception.editReception(recervid, fiog, recervro, din, dout);

                if (editQuerry)
                {
                    MessageBox.Show("Бронирование успешно обновлено", "Бронирование обновлена", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    getReceptionList();
                    Button_clean.PerformClick();
                }
                else
                {
                    MessageBox.Show("Брониравние не обновляется", "Брониравние не обновлено", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //Реализация кнопки удаление 
        private void Button_delete_Click(object sender, EventArgs e)
        {
            try
            {
                string rid = textBox_recervid.Text;
                Boolean deleteQuerry = reception.removeReception(rid);
                if (deleteQuerry)
                {
                    MessageBox.Show("Брониравние удалено успешно", "Брониравние удалено", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    getReceptionList();
                    Button_clean.PerformClick();
                }
                else
                {
                    MessageBox.Show("ОШИБКА - брониравние не удалено", "Ошибка удаления", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
