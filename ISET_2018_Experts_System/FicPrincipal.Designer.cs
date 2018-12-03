namespace ISET_2018_Experts_System
{
	partial class EcranPrincipal
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
			this.lblRegles = new System.Windows.Forms.Label();
			this.BtnCharger = new System.Windows.Forms.Button();
			this.TBregles = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// lblRegles
			// 
			this.lblRegles.AutoSize = true;
			this.lblRegles.Location = new System.Drawing.Point(13, 13);
			this.lblRegles.Name = "lblRegles";
			this.lblRegles.Size = new System.Drawing.Size(40, 13);
			this.lblRegles.TabIndex = 0;
			this.lblRegles.Text = "Règles";
			// 
			// BtnCharger
			// 
			this.BtnCharger.Location = new System.Drawing.Point(16, 257);
			this.BtnCharger.Name = "BtnCharger";
			this.BtnCharger.Size = new System.Drawing.Size(75, 23);
			this.BtnCharger.TabIndex = 1;
			this.BtnCharger.Text = "Charger";
			this.BtnCharger.UseVisualStyleBackColor = true;
			// 
			// TBregles
			// 
			this.TBregles.Location = new System.Drawing.Point(13, 30);
			this.TBregles.Multiline = true;
			this.TBregles.Name = "TBregles";
			this.TBregles.ScrollBars = System.Windows.Forms.ScrollBars.Both;
			this.TBregles.Size = new System.Drawing.Size(775, 221);
			this.TBregles.TabIndex = 2;
			// 
			// EcranPrincipal
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.TBregles);
			this.Controls.Add(this.BtnCharger);
			this.Controls.Add(this.lblRegles);
			this.Name = "EcranPrincipal";
			this.Text = "Form1";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label lblRegles;
		private System.Windows.Forms.Button BtnCharger;
		private System.Windows.Forms.TextBox TBregles;
	}
}

