
namespace ASOIU_Laba1
{
	partial class AddPlanetForm
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
			this.input_N_P = new System.Windows.Forms.TextBox();
			this.input_W_P = new System.Windows.Forms.TextBox();
			this.input_L_P = new System.Windows.Forms.TextBox();
			this.inputN_P = new System.Windows.Forms.Label();
			this.inputW_P = new System.Windows.Forms.Label();
			this.inputL_P = new System.Windows.Forms.Label();
			this.addPlanet = new System.Windows.Forms.Button();
			this.closePlanet = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// input_N_P
			// 
			this.input_N_P.Location = new System.Drawing.Point(193, 41);
			this.input_N_P.Name = "input_N_P";
			this.input_N_P.Size = new System.Drawing.Size(125, 27);
			this.input_N_P.TabIndex = 0;
			// 
			// input_W_P
			// 
			this.input_W_P.Location = new System.Drawing.Point(193, 84);
			this.input_W_P.Name = "input_W_P";
			this.input_W_P.Size = new System.Drawing.Size(125, 27);
			this.input_W_P.TabIndex = 1;
			// 
			// input_L_P
			// 
			this.input_L_P.Location = new System.Drawing.Point(193, 128);
			this.input_L_P.Name = "input_L_P";
			this.input_L_P.Size = new System.Drawing.Size(125, 27);
			this.input_L_P.TabIndex = 2;
			// 
			// inputN_P
			// 
			this.inputN_P.AutoSize = true;
			this.inputN_P.Location = new System.Drawing.Point(28, 41);
			this.inputN_P.Name = "inputN_P";
			this.inputN_P.Size = new System.Drawing.Size(102, 20);
			this.inputN_P.TabIndex = 3;
			this.inputN_P.Text = "Имя планеты";
			this.inputN_P.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// inputW_P
			// 
			this.inputW_P.AutoSize = true;
			this.inputW_P.Location = new System.Drawing.Point(28, 84);
			this.inputW_P.Name = "inputW_P";
			this.inputW_P.Size = new System.Drawing.Size(96, 20);
			this.inputW_P.TabIndex = 3;
			this.inputW_P.Text = "Вес планеты";
			this.inputW_P.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// inputL_P
			// 
			this.inputL_P.AutoSize = true;
			this.inputL_P.Location = new System.Drawing.Point(28, 128);
			this.inputL_P.Name = "inputL_P";
			this.inputL_P.Size = new System.Drawing.Size(136, 20);
			this.inputL_P.TabIndex = 3;
			this.inputL_P.Text = "Жизнь на планете";
			this.inputL_P.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// addPlanet
			// 
			this.addPlanet.Location = new System.Drawing.Point(65, 223);
			this.addPlanet.Name = "addPlanet";
			this.addPlanet.Size = new System.Drawing.Size(94, 29);
			this.addPlanet.TabIndex = 4;
			this.addPlanet.Text = "Сохранить";
			this.addPlanet.UseVisualStyleBackColor = true;
			this.addPlanet.Click += new System.EventHandler(this.addPlanet_Click);
			// 
			// closePlanet
			// 
			this.closePlanet.Location = new System.Drawing.Point(193, 223);
			this.closePlanet.Name = "closePlanet";
			this.closePlanet.Size = new System.Drawing.Size(94, 29);
			this.closePlanet.TabIndex = 4;
			this.closePlanet.Text = "Отмена";
			this.closePlanet.UseVisualStyleBackColor = true;
			this.closePlanet.Click += new System.EventHandler(this.closePlanet_Click);
			// 
			// AddPlanetForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(358, 269);
			this.ControlBox = false;
			this.Controls.Add(this.closePlanet);
			this.Controls.Add(this.addPlanet);
			this.Controls.Add(this.inputL_P);
			this.Controls.Add(this.inputW_P);
			this.Controls.Add(this.inputN_P);
			this.Controls.Add(this.input_L_P);
			this.Controls.Add(this.input_W_P);
			this.Controls.Add(this.input_N_P);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
			this.Name = "AddPlanetForm";
			this.Text = "Добавление планеты";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox input_N_P;
		private System.Windows.Forms.TextBox input_W_P;
		private System.Windows.Forms.TextBox input_L_P;
		private System.Windows.Forms.Label inputN_P;
		private System.Windows.Forms.Label inputW_P;
		private System.Windows.Forms.Label inputL_P;
		private System.Windows.Forms.Button addPlanet;
		private System.Windows.Forms.Button closePlanet;
	}
}