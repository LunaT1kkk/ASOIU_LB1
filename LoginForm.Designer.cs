namespace ASOIU_Laba1
{
	partial class LoginForm
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
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
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
			this.LeftPanel = new System.Windows.Forms.Panel();
			this.LeftLabel = new System.Windows.Forms.Label();
			this.TopLabel = new System.Windows.Forms.Label();
			this.LoginPicture = new System.Windows.Forms.PictureBox();
			this.PasswordPicture = new System.Windows.Forms.PictureBox();
			this.LoginInput = new System.Windows.Forms.TextBox();
			this.PasswordInput = new System.Windows.Forms.TextBox();
			this.EnterButton = new System.Windows.Forms.Button();
			this.RegistrationButton = new System.Windows.Forms.Button();
			this.LeftPanel.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.LoginPicture)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.PasswordPicture)).BeginInit();
			this.SuspendLayout();
			// 
			// LeftPanel
			// 
			this.LeftPanel.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.LeftPanel.Controls.Add(this.LeftLabel);
			resources.ApplyResources(this.LeftPanel, "LeftPanel");
			this.LeftPanel.Name = "LeftPanel";
			// 
			// LeftLabel
			// 
			this.LeftLabel.BackColor = System.Drawing.SystemColors.ActiveCaption;
			resources.ApplyResources(this.LeftLabel, "LeftLabel");
			this.LeftLabel.Name = "LeftLabel";
			// 
			// TopLabel
			// 
			this.TopLabel.BackColor = System.Drawing.SystemColors.ActiveBorder;
			resources.ApplyResources(this.TopLabel, "TopLabel");
			this.TopLabel.Name = "TopLabel";
			// 
			// LoginPicture
			// 
			this.LoginPicture.Image = global::ASOIU_Laba1.Properties.Resources.user;
			resources.ApplyResources(this.LoginPicture, "LoginPicture");
			this.LoginPicture.Name = "LoginPicture";
			this.LoginPicture.TabStop = false;
			// 
			// PasswordPicture
			// 
			this.PasswordPicture.Image = global::ASOIU_Laba1.Properties.Resources._lock;
			resources.ApplyResources(this.PasswordPicture, "PasswordPicture");
			this.PasswordPicture.Name = "PasswordPicture";
			this.PasswordPicture.TabStop = false;
			// 
			// LoginInput
			// 
			resources.ApplyResources(this.LoginInput, "LoginInput");
			this.LoginInput.Name = "LoginInput";
			// 
			// PasswordInput
			// 
			resources.ApplyResources(this.PasswordInput, "PasswordInput");
			this.PasswordInput.Name = "PasswordInput";
			// 
			// EnterButton
			// 
			resources.ApplyResources(this.EnterButton, "EnterButton");
			this.EnterButton.BackColor = System.Drawing.SystemColors.ActiveBorder;
			this.EnterButton.Cursor = System.Windows.Forms.Cursors.Hand;
			this.EnterButton.FlatAppearance.BorderSize = 0;
			this.EnterButton.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveCaption;
			this.EnterButton.Name = "EnterButton";
			this.EnterButton.UseVisualStyleBackColor = false;
			this.EnterButton.Click += new System.EventHandler(this.EnterButton_Click);
			// 
			// RegistrationButton
			// 
			resources.ApplyResources(this.RegistrationButton, "RegistrationButton");
			this.RegistrationButton.BackColor = System.Drawing.SystemColors.ActiveBorder;
			this.RegistrationButton.Cursor = System.Windows.Forms.Cursors.Hand;
			this.RegistrationButton.FlatAppearance.BorderSize = 0;
			this.RegistrationButton.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveCaption;
			this.RegistrationButton.Name = "RegistrationButton";
			this.RegistrationButton.UseVisualStyleBackColor = false;
			// 
			// LoginForm
			// 
			resources.ApplyResources(this, "$this");
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ControlLight;
			this.Controls.Add(this.RegistrationButton);
			this.Controls.Add(this.EnterButton);
			this.Controls.Add(this.PasswordInput);
			this.Controls.Add(this.LoginInput);
			this.Controls.Add(this.PasswordPicture);
			this.Controls.Add(this.LoginPicture);
			this.Controls.Add(this.TopLabel);
			this.Controls.Add(this.LeftPanel);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.Name = "LoginForm";
			this.LeftPanel.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.LoginPicture)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.PasswordPicture)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Panel LeftPanel;
		private System.Windows.Forms.Label LeftLabel;
		private System.Windows.Forms.Label TopLabel;
		private System.Windows.Forms.PictureBox LoginPicture;
		private System.Windows.Forms.PictureBox PasswordPicture;
		private System.Windows.Forms.TextBox LoginInput;
		private System.Windows.Forms.TextBox PasswordInput;
		private System.Windows.Forms.Button EnterButton;
		private System.Windows.Forms.Button RegistrationButton;
	}
}

