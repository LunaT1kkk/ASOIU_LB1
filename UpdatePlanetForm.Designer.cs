
namespace ASOIU_Laba1
{
	partial class UpdatePlanetForm
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
			this.upPlanet = new System.Windows.Forms.Button();
			this.inputL_P = new System.Windows.Forms.Label();
			this.inputW_P = new System.Windows.Forms.Label();
			this.inputN_P = new System.Windows.Forms.Label();
			this.update_L_P = new System.Windows.Forms.TextBox();
			this.update_W_P = new System.Windows.Forms.TextBox();
			this.update_N_P = new System.Windows.Forms.TextBox();
			this.up_id_p = new System.Windows.Forms.TextBox();
			this.uIdP = new System.Windows.Forms.Label();
			this.ClosePlanetUp = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// upPlanet
			// 
			this.upPlanet.Location = new System.Drawing.Point(80, 264);
			this.upPlanet.Name = "upPlanet";
			this.upPlanet.Size = new System.Drawing.Size(94, 29);
			this.upPlanet.TabIndex = 12;
			this.upPlanet.Text = "Сохранить";
			this.upPlanet.UseVisualStyleBackColor = true;
			this.upPlanet.Click += new System.EventHandler(this.upPlanet_Click);
			// 
			// inputL_P
			// 
			this.inputL_P.AutoSize = true;
			this.inputL_P.Location = new System.Drawing.Point(27, 197);
			this.inputL_P.Name = "inputL_P";
			this.inputL_P.Size = new System.Drawing.Size(136, 20);
			this.inputL_P.TabIndex = 8;
			this.inputL_P.Text = "Жизнь на планете";
			this.inputL_P.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// inputW_P
			// 
			this.inputW_P.AutoSize = true;
			this.inputW_P.Location = new System.Drawing.Point(27, 152);
			this.inputW_P.Name = "inputW_P";
			this.inputW_P.Size = new System.Drawing.Size(96, 20);
			this.inputW_P.TabIndex = 9;
			this.inputW_P.Text = "Вес планеты";
			this.inputW_P.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// inputN_P
			// 
			this.inputN_P.AutoSize = true;
			this.inputN_P.Location = new System.Drawing.Point(27, 109);
			this.inputN_P.Name = "inputN_P";
			this.inputN_P.Size = new System.Drawing.Size(102, 20);
			this.inputN_P.TabIndex = 10;
			this.inputN_P.Text = "Имя планеты";
			this.inputN_P.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// update_L_P
			// 
			this.update_L_P.Location = new System.Drawing.Point(193, 194);
			this.update_L_P.Name = "update_L_P";
			this.update_L_P.Size = new System.Drawing.Size(125, 27);
			this.update_L_P.TabIndex = 7;
			// 
			// update_W_P
			// 
			this.update_W_P.Location = new System.Drawing.Point(193, 149);
			this.update_W_P.Name = "update_W_P";
			this.update_W_P.Size = new System.Drawing.Size(125, 27);
			this.update_W_P.TabIndex = 6;
			// 
			// update_N_P
			// 
			this.update_N_P.Location = new System.Drawing.Point(193, 106);
			this.update_N_P.Name = "update_N_P";
			this.update_N_P.Size = new System.Drawing.Size(125, 27);
			this.update_N_P.TabIndex = 5;
			// 
			// up_id_p
			// 
			this.up_id_p.Location = new System.Drawing.Point(264, 33);
			this.up_id_p.Name = "up_id_p";
			this.up_id_p.Size = new System.Drawing.Size(54, 27);
			this.up_id_p.TabIndex = 14;
			// 
			// uIdP
			// 
			this.uIdP.AutoSize = true;
			this.uIdP.Location = new System.Drawing.Point(27, 33);
			this.uIdP.Name = "uIdP";
			this.uIdP.Size = new System.Drawing.Size(180, 20);
			this.uIdP.TabIndex = 13;
			this.uIdP.Text = "Введите индекс планеты";
			// 
			// ClosePlanetUp
			// 
			this.ClosePlanetUp.Location = new System.Drawing.Point(207, 264);
			this.ClosePlanetUp.Name = "ClosePlanetUp";
			this.ClosePlanetUp.Size = new System.Drawing.Size(94, 29);
			this.ClosePlanetUp.TabIndex = 15;
			this.ClosePlanetUp.Text = "Отмена";
			this.ClosePlanetUp.UseVisualStyleBackColor = true;
			this.ClosePlanetUp.Click += new System.EventHandler(this.ClosePlanetUp_Click);
			// 
			// UpdatePlanetForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(389, 319);
			this.ControlBox = false;
			this.Controls.Add(this.ClosePlanetUp);
			this.Controls.Add(this.up_id_p);
			this.Controls.Add(this.uIdP);
			this.Controls.Add(this.upPlanet);
			this.Controls.Add(this.inputL_P);
			this.Controls.Add(this.inputW_P);
			this.Controls.Add(this.inputN_P);
			this.Controls.Add(this.update_L_P);
			this.Controls.Add(this.update_W_P);
			this.Controls.Add(this.update_N_P);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
			this.Name = "UpdatePlanetForm";
			this.Text = "Редактирование планет";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.Button upPlanet;
		private System.Windows.Forms.Label inputL_P;
		private System.Windows.Forms.Label inputW_P;
		private System.Windows.Forms.Label inputN_P;
		private System.Windows.Forms.TextBox update_L_P;
		private System.Windows.Forms.TextBox update_W_P;
		private System.Windows.Forms.TextBox update_N_P;
		private System.Windows.Forms.TextBox up_id_p;
		private System.Windows.Forms.Label uIdP;
		private System.Windows.Forms.Button ClosePlanetUp;
	}
}