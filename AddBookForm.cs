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
	public partial class AddBookForm : Form
	{
		public AddBookForm()
		{
			InitializeComponent();
		}

		private void closePlanet_Click(object sender, EventArgs e)
		{
			input_N_B.Text = "";
			input_A_B.Text = "";

			this.Hide();
			MainForm mainForm = new MainForm();
			mainForm.Show();
		}

		private void addPlanet_Click(object sender, EventArgs e)
		{
			if (input_N_B.Text != "" && input_A_B.Text != "")
			{
				DataBase db = new DataBase();
				db.openConnection();

				MySqlCommand command = new MySqlCommand("INSERT INTO `books` (`idB`, `Name`, `Autor`) " +
					"VALUES (NULL, @nB, @aB)", db.getConnection());

				command.Parameters.Add("@nB", MySqlDbType.VarChar).Value = input_N_B.Text;
				command.Parameters.Add("@aB", MySqlDbType.VarChar).Value = input_A_B.Text;

				if (command.ExecuteNonQuery() == 1)
					MessageBox.Show("Добавление прошло успешно");
				else
					MessageBox.Show("Добавление не произошло\nОшибка!");

				db.closeConnection();

				input_N_B.Text = "";
				input_A_B.Text = "";

				this.Hide();
				MainForm mainForm = new MainForm();
				mainForm.Show();
			}
			else
				MessageBox.Show("Заполните поля");
		}
	}
}
