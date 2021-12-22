
namespace ASOIU_Laba1
{
	partial class RegistrationForm
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
			this.panelLeftReg = new System.Windows.Forms.Panel();
			this.panelTopReg = new System.Windows.Forms.Panel();
			this.SuspendLayout();
			// 
			// panelLeftReg
			// 
			this.panelLeftReg.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.panelLeftReg.Dock = System.Windows.Forms.DockStyle.Left;
			this.panelLeftReg.Location = new System.Drawing.Point(0, 0);
			this.panelLeftReg.Name = "panelLeftReg";
			this.panelLeftReg.Size = new System.Drawing.Size(130, 338);
			this.panelLeftReg.TabIndex = 0;
			// 
			// panelTopReg
			// 
			this.panelTopReg.BackColor = System.Drawing.SystemColors.ActiveBorder;
			this.panelTopReg.Dock = System.Windows.Forms.DockStyle.Top;
			this.panelTopReg.Location = new System.Drawing.Point(130, 0);
			this.panelTopReg.Name = "panelTopReg";
			this.panelTopReg.Size = new System.Drawing.Size(283, 79);
			this.panelTopReg.TabIndex = 1;
			// 
			// RegistrationForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ControlLight;
			this.ClientSize = new System.Drawing.Size(413, 338);
			this.Controls.Add(this.panelTopReg);
			this.Controls.Add(this.panelLeftReg);
			this.Name = "RegistrationForm";
			this.Text = "RegistrationForm";
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel panelLeftReg;
		private System.Windows.Forms.Panel panelTopReg;
	}
}