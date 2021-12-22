
namespace ASOIU_Laba1
{
	partial class DeleteBookForm
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
			this.CloseBookDel = new System.Windows.Forms.Button();
			this.del_id_b = new System.Windows.Forms.TextBox();
			this.d_IdB = new System.Windows.Forms.Label();
			this.delBook = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// CloseBookDel
			// 
			this.CloseBookDel.Location = new System.Drawing.Point(158, 76);
			this.CloseBookDel.Name = "CloseBookDel";
			this.CloseBookDel.Size = new System.Drawing.Size(94, 29);
			this.CloseBookDel.TabIndex = 23;
			this.CloseBookDel.Text = "Отмена";
			this.CloseBookDel.UseVisualStyleBackColor = true;
			this.CloseBookDel.Click += new System.EventHandler(this.CloseBookDel_Click);
			// 
			// del_id_b
			// 
			this.del_id_b.Location = new System.Drawing.Point(198, 20);
			this.del_id_b.Name = "del_id_b";
			this.del_id_b.Size = new System.Drawing.Size(54, 27);
			this.del_id_b.TabIndex = 22;
			// 
			// d_IdB
			// 
			this.d_IdB.AutoSize = true;
			this.d_IdB.Location = new System.Drawing.Point(12, 23);
			this.d_IdB.Name = "d_IdB";
			this.d_IdB.Size = new System.Drawing.Size(161, 20);
			this.d_IdB.TabIndex = 21;
			this.d_IdB.Text = "Введите индекс книги";
			// 
			// delBook
			// 
			this.delBook.Location = new System.Drawing.Point(12, 76);
			this.delBook.Name = "delBook";
			this.delBook.Size = new System.Drawing.Size(94, 29);
			this.delBook.TabIndex = 20;
			this.delBook.Text = "Сохранить";
			this.delBook.UseVisualStyleBackColor = true;
			this.delBook.Click += new System.EventHandler(this.delBook_Click);
			// 
			// DeleteBookForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(273, 124);
			this.ControlBox = false;
			this.Controls.Add(this.CloseBookDel);
			this.Controls.Add(this.del_id_b);
			this.Controls.Add(this.d_IdB);
			this.Controls.Add(this.delBook);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
			this.Name = "DeleteBookForm";
			this.Text = "Удаление книги";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button CloseBookDel;
		private System.Windows.Forms.TextBox del_id_b;
		private System.Windows.Forms.Label d_IdB;
		private System.Windows.Forms.Button delBook;
	}
}