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
	public partial class DeleteBookForm : Form
	{
		public DeleteBookForm()
		{
			InitializeComponent();
		}

		private void CloseBookDel_Click(object sender, EventArgs e)
		{
			del_id_b.Text = "";

			this.Hide();
			MainForm mainForm = new MainForm();
			mainForm.Show();
		}

		private void delBook_Click(object sender, EventArgs e)
		{
			DataBase db = new DataBase();
			db.openConnection();

			DataTable table = new DataTable();
			MySqlDataAdapter adapter = new MySqlDataAdapter();

			MySqlCommand command = new MySqlCommand("SELECT * From `books` WHERE `idB` = @idB", db.getConnection());
			command.Parameters.Add("@idB", MySqlDbType.VarChar).Value = del_id_b.Text;

			adapter.SelectCommand = command;
			adapter.Fill(table);

			if (!(table.Rows.Count > 0))
			{
				MessageBox.Show("Неверный ввод индекса");
			}
			else
			{
				MySqlCommand command2 = new MySqlCommand("DELETE FROM `books` WHERE `idB` = @idB", db.getConnection());

				command2.Parameters.Add("@idB", MySqlDbType.Int32).Value = del_id_b.Text;

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
