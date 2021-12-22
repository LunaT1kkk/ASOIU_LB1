
namespace ASOIU_Laba1
{
	partial class DeletePlanetForm
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
			this.ClosePlanetDel = new System.Windows.Forms.Button();
			this.del_id_p = new System.Windows.Forms.TextBox();
			this.uIdP = new System.Windows.Forms.Label();
			this.delPlanet = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// ClosePlanetDel
			// 
			this.ClosePlanetDel.Location = new System.Drawing.Point(172, 82);
			this.ClosePlanetDel.Name = "ClosePlanetDel";
			this.ClosePlanetDel.Size = new System.Drawing.Size(94, 29);
			this.ClosePlanetDel.TabIndex = 19;
			this.ClosePlanetDel.Text = "Отмена";
			this.ClosePlanetDel.UseVisualStyleBackColor = true;
			this.ClosePlanetDel.Click += new System.EventHandler(this.ClosePlanetDel_Click);
			// 
			// del_id_p
			// 
			this.del_id_p.Location = new System.Drawing.Point(212, 26);
			this.del_id_p.Name = "del_id_p";
			this.del_id_p.Size = new System.Drawing.Size(54, 27);
			this.del_id_p.TabIndex = 18;
			// 
			// uIdP
			// 
			this.uIdP.AutoSize = true;
			this.uIdP.Location = new System.Drawing.Point(26, 29);
			this.uIdP.Name = "uIdP";
			this.uIdP.Size = new System.Drawing.Size(180, 20);
			this.uIdP.TabIndex = 17;
			this.uIdP.Text = "Введите индекс планеты";
			// 
			// delPlanet
			// 
			this.delPlanet.Location = new System.Drawing.Point(26, 82);
			this.delPlanet.Name = "delPlanet";
			this.delPlanet.Size = new System.Drawing.Size(94, 29);
			this.delPlanet.TabIndex = 16;
			this.delPlanet.Text = "Сохранить";
			this.delPlanet.UseVisualStyleBackColor = true;
			this.delPlanet.Click += new System.EventHandler(this.delPlanet_Click);
			// 
			// DeletePlanetForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(291, 130);
			this.ControlBox = false;
			this.Controls.Add(this.ClosePlanetDel);
			this.Controls.Add(this.del_id_p);
			this.Controls.Add(this.uIdP);
			this.Controls.Add(this.delPlanet);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
			this.Name = "DeletePlanetForm";
			this.Text = "Удаление";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button ClosePlanetDel;
		private System.Windows.Forms.TextBox del_id_p;
		private System.Windows.Forms.Label uIdP;
		private System.Windows.Forms.Button delPlanet;
	}
}