﻿using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASOIU_Laba1
{
	class DataBase
	{
		MySqlConnection connection = new MySqlConnection("server=localhost;port=3306;user=root;password=root;database=solarsystem");
		public void openConnection()
		{
			if (connection.State == System.Data.ConnectionState.Closed)
				connection.Open();
		}
		public void closeConnection()
		{
			if (connection.State == System.Data.ConnectionState.Open)
				connection.Close();
		}

		public MySqlConnection getConnection()
		{
			return connection;
		}
	}
}
