using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace Hotel_Management_System
{
    class CleaningClass
    {
		//Подключения класса DBConnect
		DBConnect connect = new DBConnect();

		//Предоставление таблицы room из базы данных 
		public DataTable getCleaningRoom()
		{
			string selectQuerry = "SELECT * FROM `room`";
			MySqlCommand command = new MySqlCommand(selectQuerry, connect.GetCon());
			MySqlDataAdapter adapter = new MySqlDataAdapter();
			DataTable table = new DataTable();

			adapter.SelectCommand = command;
			adapter.Fill(table);

			return table;
		}

		//Предоставление таблицы cleaningstastus из базы данных 
		public DataTable getCleaningСategory()
		{
			string selectQuerry = "SELECT * FROM `cleaningstastus`";
			MySqlCommand command = new MySqlCommand(selectQuerry, connect.GetCon());
			MySqlDataAdapter adapter = new MySqlDataAdapter();
			DataTable table = new DataTable();

			adapter.SelectCommand = command;
			adapter.Fill(table);

			return table;
		}

		//Предоставление таблицы cleaningstastus из базы данных 
		public DataTable getCleaningTypes()
		{
			string selectQuerry = "SELECT * FROM `cleaningstastus`";
			MySqlCommand command = new MySqlCommand(selectQuerry, connect.GetCon());
			MySqlDataAdapter adapter = new MySqlDataAdapter();
			DataTable table = new DataTable();

			adapter.SelectCommand = command;
			adapter.Fill(table);

			return table;
		}

		//Предоставление таблицы cleaning из базы данных 
		public DataTable getCleaningList()
		{
			string selectQuerry = "SELECT * FROM `cleaning`";
			MySqlCommand command = new MySqlCommand(selectQuerry, connect.GetCon());
			MySqlDataAdapter adapter = new MySqlDataAdapter();
			DataTable table = new DataTable();

			adapter.SelectCommand = command;
			adapter.Fill(table);

			return table;
		}

		//Функция для добавления данных
		public bool addCleaning(string cid, string roomn, string ccategory, string typesc, DateTime dlc)
		{
			string insertQuerry = "INSERT INTO `cleaning`(`CleaningId`, `RoomNo`, `CleaningСategory`, `TypesCleaning`, `DateLastСleaning`) VALUES (@cid, @rn, @cleaningc, @typesc, @dlc)";
			MySqlCommand command = new MySqlCommand(insertQuerry, connect.GetCon());

			command.Parameters.Add("@cid", MySqlDbType.VarChar).Value = cid;
			command.Parameters.Add("@rn", MySqlDbType.VarChar).Value = roomn;
			command.Parameters.Add("@cleaningc", MySqlDbType.VarChar).Value = ccategory;
			command.Parameters.Add("@typesc", MySqlDbType.VarChar).Value = typesc;
			command.Parameters.Add("@dlc", MySqlDbType.Date).Value = dlc;

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

		//Функцию для редактирования 
		public bool editCleaning(string cid, string roomn, string ccategory, string typesc, DateTime dlc)
		{
			string editQuerry = "UPDATE `cleaning` SET `RoomNo`=@rn,`CleaningСategory`=@cleaningc,`TypesCleaning`=@typesc,`DateLastСleaning`=@dlc WHERE `CleaningId`=@cid";
			MySqlCommand command = new MySqlCommand(editQuerry, connect.GetCon());

			command.Parameters.Add("@cid", MySqlDbType.VarChar).Value = cid;
			command.Parameters.Add("@rn", MySqlDbType.VarChar).Value = roomn;
			command.Parameters.Add("@cleaningc", MySqlDbType.VarChar).Value = ccategory;
			command.Parameters.Add("@typesc", MySqlDbType.VarChar).Value = typesc;
			command.Parameters.Add("@dlc", MySqlDbType.Date).Value = dlc;

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

		//Функцию для удаления
		public bool removeCleaning(string cid)
		{
			string deleteQuerry = "DELETE FROM `cleaning` WHERE `CleaningId`=@cid";
			MySqlCommand command = new MySqlCommand(deleteQuerry, connect.GetCon());
			command.Parameters.Add("@cid", MySqlDbType.VarChar).Value = cid;

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
