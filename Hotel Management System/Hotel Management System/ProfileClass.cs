using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel_Management_System
{
	//Реализация профиля
	class ProfileClass
	{
		//Запоминает значения
		public class User
		{
			public string FIO { get; set; }
			public string Telephone { get; set; }
			public string Mail { get; set; }
			public string Address { get; set; }
		}
		public class Repository
		{
			public static User user = new User();
			public static void GetUser(string login)
			{
				using (MySqlConnection connection = new MySqlConnection("server = localhost; port = 3306; username = root; database = test"))
				{
					//User user = null;
					connection.Open();
					const string selectQuery = "SELECT `FIO`, `Telephone`, `Mail`, `Address` FROM `users` WHERE `UserName` =  @login OR `Mail`= @login OR `Telephone`= @login";
					MySqlCommand command = new MySqlCommand(selectQuery, connection);
					command.Parameters.AddWithValue("@login", login);
					MySqlDataReader reader = command.ExecuteReader();
					if (reader.HasRows)
					{
						while (reader.Read())
						{
							user.FIO = reader.GetString(0);
							user.Telephone = reader.GetString(1);
							user.Mail = reader.GetString(2);
							user.Address = reader.GetString(3);
						}
					}
					command.Connection.Close();
					return;
				}
			}
		}
	}
}
