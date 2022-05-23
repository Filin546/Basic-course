using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace Hotel_Management_System
{
    class UserRoomClass
    {
		//Подключения класса DBConnect
		DBConnect connect = new DBConnect();

		//Предоставление таблицы room из базы данных 
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

	}
}
