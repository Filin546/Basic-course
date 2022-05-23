using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Hotel_Management_System
{
    //Подключение к базе данных
    class DBConnect
    {
        //Реализация потокобезопасной версии паттерна Одиночки
        private static readonly MySqlConnection con = new MySqlConnection("server=localhost;port=3306;username=root;database=test");
        private static DBConnect instance = new DBConnect();

        public DBConnect() {}

        public static DBConnect Instance
        {
            get
            {
                lock (con)
                {
                    if (instance == null)
                    {
                        instance = new DBConnect();
                    }
                }
                return instance;
            }
        }

        public MySqlConnection GetCon()
        {
            return con;
        }
        public void OpenCon()
        {
            if (con.State == System.Data.ConnectionState.Closed)
                con.Open();
        }
        public void CloseCon()
        {
            if (con.State == System.Data.ConnectionState.Open)
                con.Close();
        }
    }
}
