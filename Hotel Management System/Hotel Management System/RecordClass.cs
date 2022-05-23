using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_Management_System
{
    class RecordClass
    {
		//Вызывается класс подключения в БД
		DBConnect connect = new DBConnect();

		//Метод для просмотра гостиниц 
		public DataTable getHotelNames()
		{
			string selectQuerry = "SELECT `HotelNames` FROM `hotels`";
			MySqlCommand command = new MySqlCommand(selectQuerry, connect.GetCon());
			MySqlDataAdapter adapter = new MySqlDataAdapter();
			DataTable table = new DataTable();

			adapter.SelectCommand = command;
			adapter.Fill(table);

			return table;
		}

		//Метод показывает свободные комнаты 
		public DataTable getRoom(string Room)
		{
			string selectQuerry = "SELECT `RoomNo` FROM `room` WHERE `RoomStatus` = 'Свободный' AND `HotelNames` =  @hotel";
			MySqlCommand command = new MySqlCommand(selectQuerry, connect.GetCon());

			//Заносить выбранное значение из comboBox_hotel в sql-запрос
			command.Parameters.AddWithValue("@hotel", Room);

			MySqlDataAdapter adapter = new MySqlDataAdapter();
			DataTable table = new DataTable();
			adapter.SelectCommand = command;
			adapter.Fill(table);
			return table;
		}

		//Метод для бронирования комнаты 
		public bool addReception( string fiog, string recervro, DateTime din, DateTime dout)
		{
			string insertQuerry = "INSERT INTO `reservation`( `GuestFullName`, `Room`, `DateIn`, `DateOut`) VALUES (@fiog, @rro, @din, @dout)";
			MySqlCommand command = new MySqlCommand(insertQuerry, connect.GetCon());
			command.Parameters.Add("@fiog", MySqlDbType.VarChar).Value = fiog;
			command.Parameters.Add("@rro", MySqlDbType.VarChar).Value = recervro;
			command.Parameters.Add("@din", MySqlDbType.Date).Value = din;
			command.Parameters.Add("@dout", MySqlDbType.Date).Value = dout;

			connect.OpenCon();
			if (command.ExecuteNonQuery() == 1)
			{
				connect.CloseCon();
				return true;
			}
			else
			{
				connect.CloseCon();
				return false;
			}

		}

		//Метод для изменения статуса
		public bool changeStatus(string hotel, string roomt)
		{
			string сhangingStatus = "UPDATE `room` SET `RoomStatus`= 'Занято' WHERE `HotelNames` = @hotel AND `RoomNo` = @room";
			MySqlCommand command = new MySqlCommand(сhangingStatus, connect.GetCon());
			command.Parameters.AddWithValue("@hotel", hotel);
			command.Parameters.AddWithValue("@room", roomt);
			connect.OpenCon();
			command.ExecuteNonQuery();
			return true;
		}
	}
}
