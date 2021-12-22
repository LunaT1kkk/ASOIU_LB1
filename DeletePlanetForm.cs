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
	public partial class DeletePlanetForm : Form
	{
		public DeletePlanetForm()
		{
			InitializeComponent();
		}

		private void ClosePlanetDel_Click(object sender, EventArgs e)
		{
			del_id_p.Text = "";

			this.Hide();
			MainForm mainForm = new MainForm();
			mainForm.Show();
		}

		private void delPlanet_Click(object sender, EventArgs e)
		{
			DataBase db = new DataBase();
			db.openConnection();

			DataTable table = new DataTable();
			MySqlDataAdapter adapter = new MySqlDataAdapter();

			MySqlCommand command = new MySqlCommand("SELECT * From `planet` WHERE `idP` = @idP", db.getConnection());
			command.Parameters.Add("@idP", MySqlDbType.VarChar).Value = del_id_p.Text;

			adapter.SelectCommand = command;
			adapter.Fill(table);

			if (!(table.Rows.Count > 0))
			{
				MessageBox.Show("Неверный ввод индекса");
			}
			else
			{
				MySqlCommand command2 = new MySqlCommand("DELETE FROM `planet` WHERE `idP` = @idP", db.getConnection());

				command2.Parameters.Add("@idP", MySqlDbType.Int32).Value = del_id_p.Text;

				if (command2.ExecuteNonQuery() == 1)
				{
					MessageBox.Show("Удаление прошло успешно");

					db.closeConnection();

					this.Hide();
					MainForm mainForm = new MainForm();
					mainForm.Show();
				}
				else
					MessageBox.Show("Удаление не произошло\nОшибка!");
			}
		}
	}
}
