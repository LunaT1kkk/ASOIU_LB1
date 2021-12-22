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
	public partial class MainForm : Form
	{
		public MainForm()
		{
			InitializeComponent();
			loadDataPlanet();
			loadDataBooks();
		}
		
		private void loadDataPlanet()
		{
			DataBase db = new DataBase();
			db.openConnection();

			MySqlCommand command = new MySqlCommand("SELECT * From `planet` ORDER BY `idP`", db.getConnection());
			MySqlDataReader reader = command.ExecuteReader();

			List<string[]> data = new List<string[]>();

			while (reader.Read())
			{
				data.Add(new string[4]);

				data[data.Count - 1][0] = reader[0].ToString();
				data[data.Count - 1][1] = reader[1].ToString();
				data[data.Count - 1][2] = reader[2].ToString();
				data[data.Count - 1][3] = reader[3].ToString();
			}
			reader.Close();
			db.closeConnection();

			foreach (string[] s in data)
				dataGridViewPlanet.Rows.Add(s);
		}

		private void addPlanet_Click(object sender, EventArgs e)
		{
			this.Hide();
			AddPlanetForm addPlanetForm = new AddPlanetForm();
			addPlanetForm.Show();
		}

		private void updatePlanet_Click(object sender, EventArgs e)
		{
			this.Hide();
			UpdatePlanetForm updatePlanetForm = new UpdatePlanetForm();
			updatePlanetForm.Show();
		}

		private void deletePlanet_Click(object sender, EventArgs e)
		{
			this.Hide();
			DeletePlanetForm deletePlanetForm = new DeletePlanetForm();
			deletePlanetForm.Show();
		}

		private void clsFilter_Click(object sender, EventArgs e)
		{
			this.Hide();
			MainForm mainForm = new MainForm();
			mainForm.Show();

			//for (int i = 0; i < dataGridViewPlanet.Rows.Count - 1; i++)
			//	dataGridViewPlanet.Rows[i].Visible = true;
		}

		private void findPlanet_Click(object sender, EventArgs e)
		{
			if (find_nameP.Text != "")
			{
				for (int i = 0; i < dataGridViewPlanet.Rows.Count; i++)
					dataGridViewPlanet.Rows[i].Visible = false;

				for (int i = 0; i < dataGridViewPlanet.Rows.Count; i++)
				{
					for (int j = 0; j < dataGridViewPlanet.Columns.Count; j++)
					{
						if (dataGridViewPlanet.Rows[i].Visible == false)
							dataGridViewPlanet.Rows[i].Visible = dataGridViewPlanet[j, i].Value.ToString() == find_nameP.Text;
					}
				}
			}
		}

		private void loadDataBooks()
		{
			DataBase db = new DataBase();
			db.openConnection();

			MySqlCommand command = new MySqlCommand("SELECT * From `books` ORDER BY `idB`", db.getConnection());
			MySqlDataReader reader = command.ExecuteReader();

			List<string[]> data = new List<string[]>();

			while (reader.Read())
			{
				data.Add(new string[4]);

				data[data.Count - 1][0] = reader[0].ToString();
				data[data.Count - 1][1] = reader[1].ToString();
				data[data.Count - 1][2] = reader[2].ToString();
			}
			reader.Close();
			db.closeConnection();

			foreach (string[] s in data)
				dataGridViewBooks.Rows.Add(s);
		}
		private void addBook_Click(object sender, EventArgs e)
		{
			this.Hide();
			AddBookForm addBookForm = new AddBookForm();
			addBookForm.Show();
		}

		private void updateBook_Click(object sender, EventArgs e)
		{
			this.Hide();
			UpdateBookForm upBookForm = new UpdateBookForm();
			upBookForm.Show();
		}

		private void deleteBook_Click(object sender, EventArgs e)
		{
			this.Hide();
			DeleteBookForm delBookForm = new DeleteBookForm();
			delBookForm.Show();
		}

		private void clsFilterBook_Click(object sender, EventArgs e)
		{
			this.Hide();
			MainForm mainForm = new MainForm();
			mainForm.Show();
		}

		private void FIndBook_Click(object sender, EventArgs e)
		{
			if (find_book_name.Text != "")
			{
				for (int i = 0; i < dataGridViewBooks.Rows.Count; i++)
					dataGridViewBooks.Rows[i].Visible = false;

				for (int i = 0; i < dataGridViewBooks.Rows.Count; i++)
				{
					for (int j = 0; j < dataGridViewBooks.Columns.Count; j++)
					{
						if (dataGridViewBooks.Rows[i].Visible == false)
							dataGridViewBooks.Rows[i].Visible = dataGridViewBooks[j, i].Value.ToString() == find_book_name.Text;
					}
				}
			}
		}
	}
}
