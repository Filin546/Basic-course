using MySql.Data.MySqlClient;
using System.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_Management_System
{
    class GuestClass
    {
		//Подключения класса DBConnect
		DBConnect connect = new DBConnect();

		//Функция для добавления данных
		public bool insertGuest(string gid, string uname, string fio, string phone, string city)
		{
			string insertQuerry = "INSERT INTO `guest`(`GuestId`, `UserName`, `GuestFullName`, `GuestPhone`, `GuestCity`) VALUES (@gid,@uname,@fio,@phone,@city)";
			MySqlCommand command = new MySqlCommand(insertQuerry, connect.GetCon());
			command.Parameters.Add("@gid", MySqlDbType.VarChar).Value = gid;
			command.Parameters.Add("@uname", MySqlDbType.VarChar).Value = uname;
			command.Parameters.Add("@fio", MySqlDbType.VarChar).Value = fio;
			command.Parameters.Add("@phone", MySqlDbType.VarChar).Value = phone;
			command.Parameters.Add("@city", MySqlDbType.VarChar).Value = city;

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

		//Предоставление таблицы guest из базы данных 
		public DataTable getGuest()
		{
			string selectQuerry = "SELECT * FROM `guest`";
			MySqlCommand command = new MySqlCommand(selectQuerry, connect.GetCon());
			MySqlDataAdapter adapter = new MySqlDataAdapter();
			DataTable table = new DataTable();

			adapter.SelectCommand = command;
			adapter.Fill(table);

			return table;
		}

		//Функцию для редактирования 
		public bool editGuest(string gid, string uname, string fio, string phone, string city)
		{
			string editQuerry = "UPDATE `guest` SET `UserName`=@uname,`GuestFullName`=@fio,`GuestPhone`=@ph,`GuestCity`=@ct WHERE `GuestId`=@gid";
			MySqlCommand command = new MySqlCommand(editQuerry, connect.GetCon());
			command.Parameters.Add("@gid", MySqlDbType.VarChar).Value = gid;
			command.Parameters.Add("@uname", MySqlDbType.VarChar).Value = uname;
			command.Parameters.Add("@fio", MySqlDbType.VarChar).Value = fio;
			command.Parameters.Add("@ph", MySqlDbType.VarChar).Value = phone;
			command.Parameters.Add("@ct", MySqlDbType.VarChar).Value = city;

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
		public bool removeGuest(string gid)
		{
			string deleteQuerry = "DELETE FROM `guest` WHERE `GuestId` = @gid";
			MySqlCommand command = new MySqlCommand(deleteQuerry, connect.GetCon());
			command.Parameters.Add("@gid", MySqlDbType.VarChar).Value = gid;

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

		//Предоставление таблицы users из базы данных 
		public DataTable getUserName()
		{
			string selectQuerry = "SELECT * FROM `users`";
			MySqlCommand command = new MySqlCommand(selectQuerry, connect.GetCon());
			MySqlDataAdapter adapter = new MySqlDataAdapter();
			DataTable table = new DataTable();

			adapter.SelectCommand = command;
			adapter.Fill(table);

			return table;
		}

		//Предоставление таблицы users из базы данных 
		public DataTable getFIO()
		{
			string selectQuerry = "SELECT * FROM `users`";
			MySqlCommand command = new MySqlCommand(selectQuerry, connect.GetCon());
			MySqlDataAdapter adapter = new MySqlDataAdapter();
			DataTable table = new DataTable();

			adapter.SelectCommand = command;
			adapter.Fill(table);

			return table;
		}
	}
}
