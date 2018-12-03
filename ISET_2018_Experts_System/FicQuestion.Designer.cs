namespace ISET_2018_Experts_System
{
	partial class EcranQuestion
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
			this.lblQuestion = new System.Windows.Forms.Label();
			this.TBreponse = new System.Windows.Forms.TextBox();
			this.BtnConfirmer = new System.Windows.Forms.Button();
			this.BtnAnnuler = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// lblQuestion
			// 
			this.lblQuestion.AutoSize = true;
			this.lblQuestion.Location = new System.Drawing.Point(13, 13);
			this.lblQuestion.Name = "lblQuestion";
			this.lblQuestion.Size = new System.Drawing.Size(49, 13);
			this.lblQuestion.TabIndex = 0;
			this.lblQuestion.Text = "Question";
			// 
			// TBreponse
			// 
			this.TBreponse.Location = new System.Drawing.Point(13, 30);
			this.TBreponse.Name = "TBreponse";
			this.TBreponse.Size = new System.Drawing.Size(100, 20);
			this.TBreponse.TabIndex = 1;
			// 
			// BtnConfirmer
			// 
			this.BtnConfirmer.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.BtnConfirmer.Location = new System.Drawing.Point(119, 28);
			this.BtnConfirmer.Name = "BtnConfirmer";
			this.BtnConfirmer.Size = new System.Drawing.Size(75, 23);
			this.BtnConfirmer.TabIndex = 2;
			this.BtnConfirmer.Text = "Confirmer";
			this.BtnConfirmer.UseVisualStyleBackColor = true;
			// 
			// BtnAnnuler
			// 
			this.BtnAnnuler.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.BtnAnnuler.Location = new System.Drawing.Point(200, 28);
			this.BtnAnnuler.Name = "BtnAnnuler";
			this.BtnAnnuler.Size = new System.Drawing.Size(75, 23);
			this.BtnAnnuler.TabIndex = 3;
			this.BtnAnnuler.Text = "Annuler";
			this.BtnAnnuler.UseVisualStyleBackColor = true;
			// 
			// EcranQuestion
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(286, 65);
			this.Controls.Add(this.BtnAnnuler);
			this.Controls.Add(this.BtnConfirmer);
			this.Controls.Add(this.TBreponse);
			this.Controls.Add(this.lblQuestion);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "EcranQuestion";
			this.Text = "FicQuestion";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label lblQuestion;
		private System.Windows.Forms.TextBox TBreponse;
		private System.Windows.Forms.Button BtnConfirmer;
		private System.Windows.Forms.Button BtnAnnuler;
	}
}