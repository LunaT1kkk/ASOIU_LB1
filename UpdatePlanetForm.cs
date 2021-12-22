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
	public partial class UpdatePlanetForm : Form
	{
		public UpdatePlanetForm()
		{
			InitializeComponent();
		}

		private void ClosePlanetUp_Click(object sender, EventArgs e)
		{
			up_id_p.Text = "";
			update_N_P.Text = "";
			update_W_P.Text = "";
			update_L_P.Text = "";

			this.Hide();
			MainForm mainForm = new MainForm();
			mainForm.Show();
		}

		private void upPlanet_Click(object sender, EventArgs e)
		{
			bool flag = true;

			DataBase db = new DataBase();
			db.openConnection();

			DataTable table = new DataTable();
			MySqlDataAdapter adapter = new MySqlDataAdapter();

			MySqlCommand command = new MySqlCommand("SELECT * From `planet` WHERE `idP` = @idP", db.getConnection());
			command.Parameters.Add("@idP", MySqlDbType.VarChar).Value = up_id_p.Text;

			adapter.SelectCommand = command;
			adapter.Fill(table);

			if (!(table.Rows.Count > 0))
			{
				MessageBox.Show("Неверный ввод индекса");
				flag = false;
			}

			if (update_N_P.Text != "" && update_W_P.Text != "" && update_L_P.Text != "" && flag == true)
			{
				int weight;
				bool isW = int.TryParse(update_W_P.Text, out weight);
				if (!isW && update_W_P.Text == "")
				{
					MessageBox.Show("Неверный ввод в поле `Вес`!");
					flag = false;
				}

				else if (update_L_P.Text != "0")
					update_L_P.Text = "1";

				if (flag == true)
				{
					MySqlCommand command2 = new MySqlCommand("UPDATE `planet` SET `Name`= @nP," +
						"`Weight`= @wP,`Life`= @lP WHERE `idP` = @id_p", db.getConnection());

					command2.Parameters.Add("@nP", MySqlDbType.VarChar).Value = update_N_P.Text;
					command2.Parameters.Add("@wP", MySqlDbType.Int32).Value = update_W_P.Text;
					command2.Parameters.Add("@lP", MySqlDbType.Bool).Value = update_L_P.Text;
					command2.Parameters.Add("@id_p", MySqlDbType.Int32).Value = up_id_p.Text;

					if (command2.ExecuteNonQuery() == 1)
						MessageBox.Show("Редактирование прошло успешно");
					else
						MessageBox.Show("Редактирование не произошло\nОшибка!");

					update_N_P.Text = "";
					update_W_P.Text = "";
					update_L_P.Text = "";

					this.Hide();
					MainForm mainForm = new MainForm();
					mainForm.Show();
				}
			}

			db.closeConnection();
		}
	}
}
