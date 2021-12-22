
namespace ASOIU_Laba1
{
	partial class AddBookForm
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
			this.closePlanet = new System.Windows.Forms.Button();
			this.addPlanet = new System.Windows.Forms.Button();
			this.inputW_B = new System.Windows.Forms.Label();
			this.inputN_B = new System.Windows.Forms.Label();
			this.input_A_B = new System.Windows.Forms.TextBox();
			this.input_N_B = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// closePlanet
			// 
			this.closePlanet.Location = new System.Drawing.Point(189, 149);
			this.closePlanet.Name = "closePlanet";
			this.closePlanet.Size = new System.Drawing.Size(94, 29);
			this.closePlanet.TabIndex = 11;
			this.closePlanet.Text = "Отмена";
			this.closePlanet.UseVisualStyleBackColor = true;
			this.closePlanet.Click += new System.EventHandler(this.closePlanet_Click);
			// 
			// addPlanet
			// 
			this.addPlanet.Location = new System.Drawing.Point(56, 149);
			this.addPlanet.Name = "addPlanet";
			this.addPlanet.Size = new System.Drawing.Size(94, 29);
			this.addPlanet.TabIndex = 12;
			this.addPlanet.Text = "Сохранить";
			this.addPlanet.UseVisualStyleBackColor = true;
			this.addPlanet.Click += new System.EventHandler(this.addPlanet_Click);
			// 
			// inputW_B
			// 
			this.inputW_B.AutoSize = true;
			this.inputW_B.Location = new System.Drawing.Point(24, 74);
			this.inputW_B.Name = "inputW_B";
			this.inputW_B.Size = new System.Drawing.Size(95, 20);
			this.inputW_B.TabIndex = 9;
			this.inputW_B.Text = "Автор книги";
			this.inputW_B.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// inputN_B
			// 
			this.inputN_B.AutoSize = true;
			this.inputN_B.Location = new System.Drawing.Point(24, 31);
			this.inputN_B.Name = "inputN_B";
			this.inputN_B.Size = new System.Drawing.Size(121, 20);
			this.inputN_B.TabIndex = 10;
			this.inputN_B.Text = "Название книги";
			this.inputN_B.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// input_A_B
			// 
			this.input_A_B.Location = new System.Drawing.Point(189, 74);
			this.input_A_B.Name = "input_A_B";
			this.input_A_B.Size = new System.Drawing.Size(125, 27);
			this.input_A_B.TabIndex = 6;
			// 
			// input_N_B
			// 
			this.input_N_B.Location = new System.Drawing.Point(189, 31);
			this.input_N_B.Name = "input_N_B";
			this.input_N_B.Size = new System.Drawing.Size(125, 27);
			this.input_N_B.TabIndex = 5;
			// 
			// AddBookForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(343, 199);
			this.ControlBox = false;
			this.Controls.Add(this.closePlanet);
			this.Controls.Add(this.addPlanet);
			this.Controls.Add(this.inputW_B);
			this.Controls.Add(this.inputN_B);
			this.Controls.Add(this.input_A_B);
			this.Controls.Add(this.input_N_B);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
			this.Name = "AddBookForm";
			this.Text = "Добавить книгу";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button closePlanet;
		private System.Windows.Forms.Button addPlanet;
		private System.Windows.Forms.Label inputW_B;
		private System.Windows.Forms.Label inputN_B;
		private System.Windows.Forms.TextBox input_A_B;
		private System.Windows.Forms.TextBox input_N_B;
	}
}