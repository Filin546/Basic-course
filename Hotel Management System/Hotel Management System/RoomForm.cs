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
    public partial class RoomForm : Form
    {
        //Подключения класса RoomClass
        RoomClass room = new RoomClass();

        public RoomForm()
        {
            InitializeComponent();
        }

        private void RoomForm_Load(object sender, EventArgs e)
        {
            //Чтобы отобразить номера комнат в выпадающем списке
            comboBox_rno.DataSource = room.getRoomNo();
            comboBox_rno.DisplayMember = "RoomNo";
            comboBox_rno.ValueMember = "RoomId";

            //Чтобы отобразить тип номера в выпадающем списке
            comboBox_rtype.DataSource = room.getRoomType();
            comboBox_rtype.DisplayMember = "Label";
            comboBox_rtype.ValueMember = "CategoryId";

            //Чтобы отобразить статус номера в выпадающем списке
            comboBox_rstatus.DataSource = room.getRoomStatus();
            comboBox_rstatus.DisplayMember = "RoomStatus";
            comboBox_rstatus.ValueMember = "RoomStatusID";

            //Чтобы отобразить названия отелей в выпадающем списке
            comboBox_rhn.DataSource = room.getHotelNames();
            comboBox_rhn.DisplayMember = "HotelNames";
            comboBox_rhn.ValueMember = "BuildingId";

            //Чтобы отобразить список комнат в Datagridview
            getRoomList();

            //Задает цвет строки в dgv_room
            dgv_room.DefaultCellStyle.ForeColor = Color.Black;
        }

        //Закрытие приложения
        private void Label_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //Реализация кнопки сохранения 
        private void Button_add_Click(object sender, EventArgs e)
        {
            try
            {
                string rid = textBox_rid.Text;
                string rno = comboBox_rno.Text;
                string rtype = comboBox_rtype.Text;
                string rph = textBox_rph.Text;
                string rstatus = comboBox_rstatus.Text;
                string rhn = comboBox_rhn.Text;

                if (room.addRoom(rid, rno, rtype, rph, rstatus, rhn))
                {
                    MessageBox.Show("Комната успешно добавлена", "Добавлена комната", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    getRoomList();
                }
                else
                {
                    MessageBox.Show("Комната не добавлена", "Добавить комнату", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            textBox_rid.Clear();
            comboBox_rno.SelectedIndex = -1;
            comboBox_rtype.SelectedIndex = -1;
            textBox_rph.Clear();
            comboBox_rstatus.SelectedIndex = -1;
            comboBox_rhn.SelectedIndex = -1;
        }

        //Отображает данные в dgv_room
        private void getRoomList()
        {
            dgv_room.DataSource = room.getRoomList();
        }

        //Реализация кнопки редактирования
        private void Button_edit_Click(object sender, EventArgs e)
        {
            try
            {
                string rid = textBox_rid.Text;
                string rno = comboBox_rno.Text;
                string rtype = comboBox_rtype.Text;
                string rph = textBox_rph.Text;
                string rstatus = comboBox_rstatus.Text;
                string rhn = comboBox_rhn.Text;

                Boolean editQuerry = room.editRoom(rid, rno, rtype, rph, rstatus, rhn);

                if (editQuerry)
                {
                    MessageBox.Show("Обновление номера прошло успешно", "Комната обновлена", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    getRoomList();
                    Button_clean.PerformClick();
                }
                else
                {
                    MessageBox.Show("Номер не обновляется", "Комната не обновлена", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //Показывает данные по клику на любую часть ячейки
        private void dgv_room_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox_rid.Text = dgv_room.CurrentRow.Cells[0].Value.ToString();
            comboBox_rno.Text = dgv_room.CurrentRow.Cells[1].Value.ToString();
            comboBox_rtype.Text = dgv_room.CurrentRow.Cells[2].Value.ToString();
            textBox_rph.Text = dgv_room.CurrentRow.Cells[3].Value.ToString();
            comboBox_rstatus.Text = dgv_room.CurrentRow.Cells[4].Value.ToString(); 
            comboBox_rhn.Text = dgv_room.CurrentRow.Cells[5].Value.ToString();
        }

        //Реализация кнопки удаление
        private void Button_delete_Click(object sender, EventArgs e)
        {
            if (comboBox_rno.Text == "")
            {
                MessageBox.Show("Обязательное поле - номер Комнаты", "Обязательное поле", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                try
                {
                    string rid = textBox_rid.Text;
                    Boolean deleteQuerry = room.removeRoom(rid);
                    if (deleteQuerry)
                    {
                        MessageBox.Show("Комната удалена успешно", "Комната удалена", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        getRoomList();
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
    }
}
