
namespace ASOIU_Laba1
{
	partial class MainForm
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.tabControl = new System.Windows.Forms.TabControl();
			this.tabPlanet = new System.Windows.Forms.TabPage();
			this.find_nameP = new System.Windows.Forms.TextBox();
			this.findPlanet = new System.Windows.Forms.Button();
			this.clsFilter = new System.Windows.Forms.Button();
			this.deletePlanet = new System.Windows.Forms.Button();
			this.updatePlanet = new System.Windows.Forms.Button();
			this.addPlanet = new System.Windows.Forms.Button();
			this.dataGridViewPlanet = new System.Windows.Forms.DataGridView();
			this.idP = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.PlanetName = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.PlanetWeight = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.PlanetLife = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.tabBooks = new System.Windows.Forms.TabPage();
			this.find_book_name = new System.Windows.Forms.TextBox();
			this.FIndBook = new System.Windows.Forms.Button();
			this.clsFilterBook = new System.Windows.Forms.Button();
			this.deleteBook = new System.Windows.Forms.Button();
			this.updateBook = new System.Windows.Forms.Button();
			this.addBook = new System.Windows.Forms.Button();
			this.dataGridViewBooks = new System.Windows.Forms.DataGridView();
			this.idB = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.NameBook = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.AutorBook = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.tabControl.SuspendLayout();
			this.tabPlanet.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewPlanet)).BeginInit();
			this.tabBooks.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewBooks)).BeginInit();
			this.SuspendLayout();
			// 
			// tabControl
			// 
			this.tabControl.Controls.Add(this.tabPlanet);
			this.tabControl.Controls.Add(this.tabBooks);
			resources.ApplyResources(this.tabControl, "tabControl");
			this.tabControl.Name = "tabControl";
			this.tabControl.SelectedIndex = 0;
			// 
			// tabPlanet
			// 
			this.tabPlanet.Controls.Add(this.find_nameP);
			this.tabPlanet.Controls.Add(this.findPlanet);
			this.tabPlanet.Controls.Add(this.clsFilter);
			this.tabPlanet.Controls.Add(this.deletePlanet);
			this.tabPlanet.Controls.Add(this.updatePlanet);
			this.tabPlanet.Controls.Add(this.addPlanet);
			this.tabPlanet.Controls.Add(this.dataGridViewPlanet);
			resources.ApplyResources(this.tabPlanet, "tabPlanet");
			this.tabPlanet.Name = "tabPlanet";
			this.tabPlanet.UseVisualStyleBackColor = true;
			// 
			// find_nameP
			// 
			this.find_nameP.BackColor = System.Drawing.SystemColors.InactiveCaption;
			resources.ApplyResources(this.find_nameP, "find_nameP");
			this.find_nameP.Name = "find_nameP";
			// 
			// findPlanet
			// 
			resources.ApplyResources(this.findPlanet, "findPlanet");
			this.findPlanet.Name = "findPlanet";
			this.findPlanet.UseVisualStyleBackColor = true;
			this.findPlanet.Click += new System.EventHandler(this.findPlanet_Click);
			// 
			// clsFilter
			// 
			resources.ApplyResources(this.clsFilter, "clsFilter");
			this.clsFilter.Name = "clsFilter";
			this.clsFilter.UseVisualStyleBackColor = true;
			this.clsFilter.Click += new System.EventHandler(this.clsFilter_Click);
			// 
			// deletePlanet
			// 
			resources.ApplyResources(this.deletePlanet, "deletePlanet");
			this.deletePlanet.Name = "deletePlanet";
			this.deletePlanet.UseVisualStyleBackColor = true;
			this.deletePlanet.Click += new System.EventHandler(this.deletePlanet_Click);
			// 
			// updatePlanet
			// 
			resources.ApplyResources(this.updatePlanet, "updatePlanet");
			this.updatePlanet.Name = "updatePlanet";
			this.updatePlanet.UseVisualStyleBackColor = true;
			this.updatePlanet.Click += new System.EventHandler(this.updatePlanet_Click);
			// 
			// addPlanet
			// 
			resources.ApplyResources(this.addPlanet, "addPlanet");
			this.addPlanet.Name = "addPlanet";
			this.addPlanet.UseVisualStyleBackColor = true;
			this.addPlanet.Click += new System.EventHandler(this.addPlanet_Click);
			// 
			// dataGridViewPlanet
			// 
			this.dataGridViewPlanet.AllowUserToAddRows = false;
			this.dataGridViewPlanet.AllowUserToDeleteRows = false;
			this.dataGridViewPlanet.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
			this.dataGridViewPlanet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridViewPlanet.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idP,
            this.PlanetName,
            this.PlanetWeight,
            this.PlanetLife});
			resources.ApplyResources(this.dataGridViewPlanet, "dataGridViewPlanet");
			this.dataGridViewPlanet.Name = "dataGridViewPlanet";
			this.dataGridViewPlanet.ReadOnly = true;
			this.dataGridViewPlanet.RowTemplate.Height = 29;
			// 
			// idP
			// 
			resources.ApplyResources(this.idP, "idP");
			this.idP.Name = "idP";
			this.idP.ReadOnly = true;
			// 
			// PlanetName
			// 
			resources.ApplyResources(this.PlanetName, "PlanetName");
			this.PlanetName.Name = "PlanetName";
			this.PlanetName.ReadOnly = true;
			// 
			// PlanetWeight
			// 
			resources.ApplyResources(this.PlanetWeight, "PlanetWeight");
			this.PlanetWeight.Name = "PlanetWeight";
			this.PlanetWeight.ReadOnly = true;
			// 
			// PlanetLife
			// 
			resources.ApplyResources(this.PlanetLife, "PlanetLife");
			this.PlanetLife.Name = "PlanetLife";
			this.PlanetLife.ReadOnly = true;
			// 
			// tabBooks
			// 
			this.tabBooks.Controls.Add(this.find_book_name);
			this.tabBooks.Controls.Add(this.FIndBook);
			this.tabBooks.Controls.Add(this.clsFilterBook);
			this.tabBooks.Controls.Add(this.deleteBook);
			this.tabBooks.Controls.Add(this.updateBook);
			this.tabBooks.Controls.Add(this.addBook);
			this.tabBooks.Controls.Add(this.dataGridViewBooks);
			resources.ApplyResources(this.tabBooks, "tabBooks");
			this.tabBooks.Name = "tabBooks";
			this.tabBooks.UseVisualStyleBackColor = true;
			// 
			// find_book_name
			// 
			this.find_book_name.BackColor = System.Drawing.SystemColors.InactiveCaption;
			resources.ApplyResources(this.find_book_name, "find_book_name");
			this.find_book_name.Name = "find_book_name";
			// 
			// FIndBook
			// 
			resources.ApplyResources(this.FIndBook, "FIndBook");
			this.FIndBook.Name = "FIndBook";
			this.FIndBook.UseVisualStyleBackColor = true;
			this.FIndBook.Click += new System.EventHandler(this.FIndBook_Click);
			// 
			// clsFilterBook
			// 
			resources.ApplyResources(this.clsFilterBook, "clsFilterBook");
			this.clsFilterBook.Name = "clsFilterBook";
			this.clsFilterBook.UseVisualStyleBackColor = true;
			this.clsFilterBook.Click += new System.EventHandler(this.clsFilterBook_Click);
			// 
			// deleteBook
			// 
			resources.ApplyResources(this.deleteBook, "deleteBook");
			this.deleteBook.Name = "deleteBook";
			this.deleteBook.UseVisualStyleBackColor = true;
			this.deleteBook.Click += new System.EventHandler(this.deleteBook_Click);
			// 
			// updateBook
			// 
			resources.ApplyResources(this.updateBook, "updateBook");
			this.updateBook.Name = "updateBook";
			this.updateBook.UseVisualStyleBackColor = true;
			this.updateBook.Click += new System.EventHandler(this.updateBook_Click);
			// 
			// addBook
			// 
			resources.ApplyResources(this.addBook, "addBook");
			this.addBook.Name = "addBook";
			this.addBook.UseVisualStyleBackColor = true;
			this.addBook.Click += new System.EventHandler(this.addBook_Click);
			// 
			// dataGridViewBooks
			// 
			this.dataGridViewBooks.AllowUserToAddRows = false;
			this.dataGridViewBooks.AllowUserToDeleteRows = false;
			this.dataGridViewBooks.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
			this.dataGridViewBooks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridViewBooks.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idB,
            this.NameBook,
            this.AutorBook});
			resources.ApplyResources(this.dataGridViewBooks, "dataGridViewBooks");
			this.dataGridViewBooks.Name = "dataGridViewBooks";
			this.dataGridViewBooks.ReadOnly = true;
			this.dataGridViewBooks.RowTemplate.Height = 29;
			// 
			// idB
			// 
			resources.ApplyResources(this.idB, "idB");
			this.idB.Name = "idB";
			this.idB.ReadOnly = true;
			// 
			// NameBook
			// 
			resources.ApplyResources(this.NameBook, "NameBook");
			this.NameBook.Name = "NameBook";
			this.NameBook.ReadOnly = true;
			// 
			// AutorBook
			// 
			resources.ApplyResources(this.AutorBook, "AutorBook");
			this.AutorBook.Name = "AutorBook";
			this.AutorBook.ReadOnly = true;
			// 
			// MainForm
			// 
			resources.ApplyResources(this, "$this");
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ControlLight;
			this.Controls.Add(this.tabControl);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.Name = "MainForm";
			this.tabControl.ResumeLayout(false);
			this.tabPlanet.ResumeLayout(false);
			this.tabPlanet.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewPlanet)).EndInit();
			this.tabBooks.ResumeLayout(false);
			this.tabBooks.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewBooks)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TabControl tabControl;
		private System.Windows.Forms.TabPage tabPlanet;
		private System.Windows.Forms.TabPage tabBooks;
		private System.Windows.Forms.DataGridView dataGridViewPlanet;
		private System.Windows.Forms.DataGridViewTextBoxColumn idP;
		private System.Windows.Forms.DataGridViewTextBoxColumn PlanetName;
		private System.Windows.Forms.DataGridViewTextBoxColumn PlanetWeight;
		private System.Windows.Forms.DataGridViewTextBoxColumn PlanetLife;
		private System.Windows.Forms.Button addPlanet;
		private System.Windows.Forms.Button updatePlanet;
		private System.Windows.Forms.Button deletePlanet;
		private System.Windows.Forms.Button clsFilter;
		private System.Windows.Forms.TextBox find_nameP;
		private System.Windows.Forms.Button findPlanet;
		private System.Windows.Forms.TextBox find_book_name;
		private System.Windows.Forms.Button FIndBook;
		private System.Windows.Forms.Button clsFilterBook;
		private System.Windows.Forms.Button deleteBook;
		private System.Windows.Forms.Button updateBook;
		private System.Windows.Forms.Button addBook;
		private System.Windows.Forms.DataGridView dataGridViewBooks;
		private System.Windows.Forms.DataGridViewTextBoxColumn idB;
		private System.Windows.Forms.DataGridViewTextBoxColumn NameBook;
		private System.Windows.Forms.DataGridViewTextBoxColumn AutorBook;
	}
}