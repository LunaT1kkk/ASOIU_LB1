
namespace ASOIU_Laba1
{
	partial class UpdateBookForm
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
			this.CloseBookUp = new System.Windows.Forms.Button();
			this.up_id_b = new System.Windows.Forms.TextBox();
			this.uIdB = new System.Windows.Forms.Label();
			this.upBook = new System.Windows.Forms.Button();
			this.inputA_B = new System.Windows.Forms.Label();
			this.inputN_B = new System.Windows.Forms.Label();
			this.update_A_B = new System.Windows.Forms.TextBox();
			this.update_N_B = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// CloseBookUp
			// 
			this.CloseBookUp.Location = new System.Drawing.Point(188, 203);
			this.CloseBookUp.Name = "CloseBookUp";
			this.CloseBookUp.Size = new System.Drawing.Size(94, 29);
			this.CloseBookUp.TabIndex = 23;
			this.CloseBookUp.Text = "Отмена";
			this.CloseBookUp.UseVisualStyleBackColor = true;
			this.CloseBookUp.Click += new System.EventHandler(this.CloseBookUp_Click);
			// 
			// up_id_b
			// 
			this.up_id_b.Location = new System.Drawing.Point(259, 32);
			this.up_id_b.Name = "up_id_b";
			this.up_id_b.Size = new System.Drawing.Size(54, 27);
			this.up_id_b.TabIndex = 22;
			// 
			// uIdB
			// 
			this.uIdB.AutoSize = true;
			this.uIdB.Location = new System.Drawing.Point(12, 32);
			this.uIdB.Name = "uIdB";
			this.uIdB.Size = new System.Drawing.Size(180, 20);
			this.uIdB.TabIndex = 21;
			this.uIdB.Text = "Введите индекс планеты";
			// 
			// upBook
			// 
			this.upBook.Location = new System.Drawing.Point(44, 203);
			this.upBook.Name = "upBook";
			this.upBook.Size = new System.Drawing.Size(94, 29);
			this.upBook.TabIndex = 20;
			this.upBook.Text = "Сохранить";
			this.upBook.UseVisualStyleBackColor = true;
			this.upBook.Click += new System.EventHandler(this.upBook_Click);
			// 
			// inputA_B
			// 
			this.inputA_B.AutoSize = true;
			this.inputA_B.Location = new System.Drawing.Point(12, 141);
			this.inputA_B.Name = "inputA_B";
			this.inputA_B.Size = new System.Drawing.Size(95, 20);
			this.inputA_B.TabIndex = 18;
			this.inputA_B.Text = "Автор книги";
			this.inputA_B.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// inputN_B
			// 
			this.inputN_B.AutoSize = true;
			this.inputN_B.Location = new System.Drawing.Point(12, 98);
			this.inputN_B.Name = "inputN_B";
			this.inputN_B.Size = new System.Drawing.Size(121, 20);
			this.inputN_B.TabIndex = 19;
			this.inputN_B.Text = "Название книги";
			this.inputN_B.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// update_A_B
			// 
			this.update_A_B.Location = new System.Drawing.Point(188, 138);
			this.update_A_B.Name = "update_A_B";
			this.update_A_B.Size = new System.Drawing.Size(125, 27);
			this.update_A_B.TabIndex = 17;
			// 
			// update_N_B
			// 
			this.update_N_B.Location = new System.Drawing.Point(188, 98);
			this.update_N_B.Name = "update_N_B";
			this.update_N_B.Size = new System.Drawing.Size(125, 27);
			this.update_N_B.TabIndex = 16;
			// 
			// UpdateBookForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(342, 248);
			this.Controls.Add(this.CloseBookUp);
			this.Controls.Add(this.up_id_b);
			this.Controls.Add(this.uIdB);
			this.Controls.Add(this.upBook);
			this.Controls.Add(this.inputA_B);
			this.Controls.Add(this.inputN_B);
			this.Controls.Add(this.update_A_B);
			this.Controls.Add(this.update_N_B);
			this.Name = "UpdateBookForm";
			this.Text = "Редактирование книги";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button CloseBookUp;
		private System.Windows.Forms.TextBox up_id_b;
		private System.Windows.Forms.Label uIdB;
		private System.Windows.Forms.Button upBook;
		private System.Windows.Forms.Label inputA_B;
		private System.Windows.Forms.Label inputN_B;
		private System.Windows.Forms.TextBox update_A_B;
		private System.Windows.Forms.TextBox update_N_B;
	}
}