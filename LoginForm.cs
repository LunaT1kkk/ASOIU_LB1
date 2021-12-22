using MySqlConnector;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ASOIU_Laba1
{
	public partial class LoginForm : Form
	{
		public LoginForm()
		{
			InitializeComponent();
		}

		private void EnterButton_Click(object sender, EventArgs e)
		{
			String loginUser = LoginInput.Text;
			String passwordUser = PasswordInput.Text;

			DataBase db = new DataBase();
			DataTable table = new DataTable();
			MySqlDataAdapter adapter = new MySqlDataAdapter();

			MySqlCommand command = new MySqlCommand("SELECT * From `users` WHERE `login` = @uL AND `password` = @uP", db.getConnection());
			command.Parameters.Add("@uL", MySqlDbType.VarChar).Value = loginUser;
			command.Parameters.Add("@uP", MySqlDbType.VarChar).Value = passwordUser;

			adapter.SelectCommand = command;
			adapter.Fill(table);

			if (table.Rows.Count > 0)
			{
				MessageBox.Show("Успешная авторизация");
				this.Hide();
				MainForm mainForm = new MainForm();
				mainForm.Show();
			}
			else
				MessageBox.Show("Неверный логин или пароль");
		}
	}
}
