using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySqlConnector;

namespace ASOIU_Laba1
{
	public partial class AddPlanetForm : Form
	{
		public AddPlanetForm()
		{
			InitializeComponent();
		}

		private void closePlanet_Click(object sender, EventArgs e)
		{
			input_N_P.Text = "";
			input_W_P.Text = "";
			input_L_P.Text = "";

			this.Hide();
			MainForm mainForm = new MainForm();
			mainForm.Show();
		}

		private void addPlanet_Click(object sender, EventArgs e)
		{
			bool flag = true;

			if (input_N_P.Text != "")
			{
				int weight;
				bool isW = int.TryParse(input_W_P.Text, out weight);
				if (!isW)
				{
					MessageBox.Show("Неверный ввод в поле `Вес`!");
					flag = false;
				}

				if (input_L_P.Text != "0" && input_L_P.Text != "")
					input_L_P.Text = "1";

				if (flag == true)
				{
					DataBase db = new DataBase();
					db.openConnection();

					MySqlCommand command = new MySqlCommand("INSERT INTO `planet` (`idP`, `Name`, `Weight`, " +
						"`Life`) VALUES (NULL, @nP, @wP, @lP)", db.getConnection());

					command.Parameters.Add("@nP", MySqlDbType.VarChar).Value = input_N_P.Text;
					command.Parameters.Add("@wP", MySqlDbType.Int32).Value = input_W_P.Text;
					command.Parameters.Add("@lP", MySqlDbType.Bool).Value = input_L_P.Text;

					if (command.ExecuteNonQuery() == 1)
						MessageBox.Show("Добавление прошло успешно");
					else
						MessageBox.Show("Добавление не произошло\nОшибка!");

					db.closeConnection();

					input_N_P.Text = "";
					input_W_P.Text = "";
					input_L_P.Text = "";

					this.Hide();
					MainForm mainForm = new MainForm();
					mainForm.Show();
				}
			}
			else
				MessageBox.Show("Введите имя планеты!");
		}
	}
}
