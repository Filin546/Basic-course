using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace Hotel_Management_System
{
    class ReceptionClass
    {
		//Подключения класса DBConnect
		DBConnect connect = new DBConnect();

		//Предоставление таблицы guest из базы данных 
		public DataTable getReceptionGuestId()
		{
			string selectQuerry = "SELECT * FROM `guest`";
			MySqlCommand command = new MySqlCommand(selectQuerry, connect.GetCon());
			MySqlDataAdapter adapter = new MySqlDataAdapter();
			DataTable table = new DataTable();

			adapter.SelectCommand = command;
			adapter.Fill(table);

			return table;
		}

		//Предоставление таблицы room из базы данных 
		public DataTable getReceptionRoom()
		{
			string selectQuerry = "SELECT * FROM `room`";
			MySqlCommand command = new MySqlCommand(selectQuerry, connect.GetCon());
			MySqlDataAdapter adapter = new MySqlDataAdapter();
			DataTable table = new DataTable();

			adapter.SelectCommand = command;
			adapter.Fill(table);

			return table;
		}

		//Предоставление таблицы reservation из базы данных 
		public DataTable getReceptionList()
		{
			string selectQuerry = "SELECT * FROM `reservation`";
			MySqlCommand command = new MySqlCommand(selectQuerry, connect.GetCon());
			MySqlDataAdapter adapter = new MySqlDataAdapter();
			DataTable table = new DataTable();

			adapter.SelectCommand = command;
			adapter.Fill(table);

			return table;
		}

		//Функцию для добавления
		public bool addReception(string recervid, string fiog, string recervro, DateTime din, DateTime dout)
		{
			string insertQuerry = "INSERT INTO `reservation`(`RecervId`, `GuestFullName`, `Room`, `DateIn`, `DateOut`) VALUES (@rid, @fiog, @rro, @din, @dout)";
			MySqlCommand command = new MySqlCommand(insertQuerry, connect.GetCon());

			command.Parameters.Add("@rid", MySqlDbType.VarChar).Value = recervid;
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

		//Функцию для редактирования 
		public bool editReception(string recervid, string fiog, string recervro, DateTime din, DateTime dout)
		{
			string editQuerry = "UPDATE `reservation` SET `GuestFullName`=@fiog,`Room`=@rro,`DateIn`=@din,`DateOut`=@dout WHERE `RecervId`=@rid";
			MySqlCommand command = new MySqlCommand(editQuerry, connect.GetCon());

			command.Parameters.Add("@rid", MySqlDbType.VarChar).Value = recervid;
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

		//Функцию для удаления
		public bool removeReception(string recervid)
		{
			string deleteQuerry = "DELETE FROM `reservation` WHERE `RecervId`=@rid";
			MySqlCommand command = new MySqlCommand(deleteQuerry, connect.GetCon());
			command.Parameters.Add("@rid", MySqlDbType.VarChar).Value = recervid;

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
