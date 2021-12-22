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
	public partial class UpdateBookForm : Form
	{
		public UpdateBookForm()
		{
			InitializeComponent();
		}

		private void CloseBookUp_Click(object sender, EventArgs e)
		{
			up_id_b.Text = "";
			update_N_B.Text = "";
			update_A_B.Text = "";

			this.Hide();
			MainForm mainForm = new MainForm();
			mainForm.Show();
		}

		private void upBook_Click(object sender, EventArgs e)
		{
			bool flag = true;

			DataBase db = new DataBase();
			db.openConnection();

			DataTable table = new DataTable();
			MySqlDataAdapter adapter = new MySqlDataAdapter();

			MySqlCommand command = new MySqlCommand("SELECT * From `books` WHERE `idB` = @idB", db.getConnection());
			command.Parameters.Add("@idB", MySqlDbType.Int32).Value = up_id_b.Text;

			adapter.SelectCommand = command;
			adapter.Fill(table);

			if (table.Rows.Count > 0)
			{
				if (update_N_B.Text != "" && update_A_B.Text != "")
				{
					MySqlCommand command2 = new MySqlCommand("UPDATE `books` SET `Name`= @nB," +
						"`Autor`= @aB WHERE `idB` = @id_b", db.getConnection());

					command2.Parameters.Add("@nB", MySqlDbType.VarChar).Value = update_N_B.Text;
					command2.Parameters.Add("@aB", MySqlDbType.VarChar).Value = update_A_B.Text;
					command2.Parameters.Add("@id_b", MySqlDbType.Int32).Value = up_id_b.Text;

					if (command2.ExecuteNonQuery() == 1)
						MessageBox.Show("Редактирование прошло успешно");
					else
						MessageBox.Show("Редактирование не произошло\nОшибка!");

					update_N_B.Text = "";
					update_A_B.Text = "";
					up_id_b.Text = "";

					this.Hide();
					MainForm mainForm = new MainForm();
					mainForm.Show();
				}
			}
			else
				MessageBox.Show("Неверный ввод индекса");
			
			db.closeConnection();
		}
	}
}
