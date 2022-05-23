using MySql.Data.MySqlClient;
using System.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Hotel_Management_System
{
    class RoomClass
    {
		//Подключения класса DBConnect
		DBConnect connect = new DBConnect();

		//Предоставление таблицы category из базы данных 
		public DataTable getRoomType()
		{
			string selectQuerry = "SELECT * FROM `category`";
			MySqlCommand command = new MySqlCommand(selectQuerry, connect.GetCon());
			MySqlDataAdapter adapter = new MySqlDataAdapter();
			DataTable table = new DataTable();

			adapter.SelectCommand = command;
			adapter.Fill(table);

			return table;
		}

		//Предоставление таблицы number_status_category из базы данных 
		public DataTable getRoomStatus()
		{
			string selectQuerry = "SELECT * FROM `number_status_category`";
			MySqlCommand command = new MySqlCommand(selectQuerry, connect.GetCon());
			MySqlDataAdapter adapter = new MySqlDataAdapter();
			DataTable table = new DataTable();

			adapter.SelectCommand = command;
			adapter.Fill(table);

			return table;
		}

		//Предоставление таблицы hotels из базы данных 
		public DataTable getHotelNames()
		{
			string selectQuerry = "SELECT * FROM `hotels`";
			MySqlCommand command = new MySqlCommand(selectQuerry, connect.GetCon());
			MySqlDataAdapter adapter = new MySqlDataAdapter();
			DataTable table = new DataTable();

			adapter.SelectCommand = command;
			adapter.Fill(table);

			return table;
		}

		//Предоставление таблицы room_numbers из базы данных 
		public DataTable getRoomNo()
		{
			string selectQuerry = "SELECT * FROM `room_numbers`";
			MySqlCommand command = new MySqlCommand(selectQuerry, connect.GetCon());
			MySqlDataAdapter adapter = new MySqlDataAdapter();
			DataTable table = new DataTable();

			adapter.SelectCommand = command;
			adapter.Fill(table);

			return table;
		}

		//Функция для добавления данных
		public bool addRoom(string rid,string rno, string rtype, string rph, string rstatus, string rhn)
		{
			string insertQuerry = "INSERT INTO `room`(`RoomId`, `RoomNo`, `RoomType`, `RoomPhone`, `RoomStatus`, `HotelNames`) VALUES (@rid, @rno, @rtype, @rph, @rstatus, @rhn)";
			MySqlCommand command = new MySqlCommand(insertQuerry, connect.GetCon());
			command.Parameters.Add("@rid", MySqlDbType.VarChar).Value = rid;
			command.Parameters.Add("@rno", MySqlDbType.VarChar).Value = rno;
			command.Parameters.Add("@rtype", MySqlDbType.VarChar).Value = rtype;
			command.Parameters.Add("@rph", MySqlDbType.VarChar).Value = rph;
			command.Parameters.Add("@rstatus", MySqlDbType.VarChar).Value = rstatus;
			command.Parameters.Add("@rhn", MySqlDbType.VarChar).Value = rhn;

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

		//Функцию для получения таблицы списка комнат
		public DataTable getRoomList()
		{
			string selectQuerry = "SELECT * FROM `room`";
			MySqlCommand command = new MySqlCommand(selectQuerry, connect.GetCon());
			MySqlDataAdapter adapter = new MySqlDataAdapter();
			DataTable table = new DataTable();

			adapter.SelectCommand = command;
			adapter.Fill(table);

			return table;
		}

		//Функция для редактирования/обновления комнаты
		public bool editRoom(string rid, string rno, string rtype, string rph, string rstatus, string rhn)
		{
			string editQuerry = "UPDATE `room` SET `RoomNo`= @rno,`RoomType`= @rtype,`RoomPhone`= @rph,`RoomStatus`= @rstatus,`HotelNames`= @rhn WHERE `RoomId`= @rid";
			MySqlCommand command = new MySqlCommand(editQuerry, connect.GetCon());
			command.Parameters.Add("@rid", MySqlDbType.VarChar).Value = rid;
			command.Parameters.Add("@rno", MySqlDbType.VarChar).Value = rno;
			command.Parameters.Add("@rtype", MySqlDbType.VarChar).Value = rtype;
			command.Parameters.Add("@rph", MySqlDbType.VarChar).Value = rph;
			command.Parameters.Add("@rstatus", MySqlDbType.VarChar).Value = rstatus;
			command.Parameters.Add("@rhn", MySqlDbType.VarChar).Value = rhn;

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

		//Функция для удаления комнаты
		public bool removeRoom(string rid)
		{
			string deleteQuerry = "DELETE FROM `room` WHERE `RoomId`= @rid";
			MySqlCommand command = new MySqlCommand(deleteQuerry, connect.GetCon());
			command.Parameters.Add("@rid", MySqlDbType.VarChar).Value = rid;

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
	}
}
