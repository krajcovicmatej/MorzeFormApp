namespace MorzeFormApp
{
	partial class Form1
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
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.button3 = new System.Windows.Forms.Button();
			this.button5 = new System.Windows.Forms.Button();
			this.label3 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// button1
			// 
			this.button1.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.button1.AutoSize = true;
			this.button1.Location = new System.Drawing.Point(122, 136);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(211, 88);
			this.button1.TabIndex = 0;
			this.button1.Text = "Kódovanie z Morzeovej abecedy";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// button2
			// 
			this.button2.Anchor = System.Windows.Forms.AnchorStyles.Right;
			this.button2.AutoSize = true;
			this.button2.Location = new System.Drawing.Point(480, 136);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(223, 88);
			this.button2.TabIndex = 1;
			this.button2.Text = "Dekódovanie z Morzeovej abecedy";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// label1
			// 
			this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.label1.Location = new System.Drawing.Point(73, 36);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(693, 24);
			this.label1.TabIndex = 2;
			this.label1.Text = "Vitajte v aplikácii na kódovanie a dekódovanie textu z/do Morzeovej abecedy";
			// 
			// label2
			// 
			this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.label2.Location = new System.Drawing.Point(118, 101);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(215, 19);
			this.label2.TabIndex = 3;
			this.label2.Text = "Vyberte si čo potrebujete spraviť :";
			this.label2.Click += new System.EventHandler(this.label2_Click);
			// 
			// button3
			// 
			this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.button3.AutoSize = true;
			this.button3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.button3.Location = new System.Drawing.Point(122, 329);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(172, 23);
			this.button3.TabIndex = 4;
			this.button3.Text = "Archivované súbory z kódovania";
			this.button3.UseVisualStyleBackColor = true;
			this.button3.Click += new System.EventHandler(this.button3_Click);
			// 
			// button5
			// 
			this.button5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.button5.AutoSize = true;
			this.button5.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.button5.Location = new System.Drawing.Point(519, 329);
			this.button5.Name = "button5";
			this.button5.Size = new System.Drawing.Size(184, 23);
			this.button5.TabIndex = 6;
			this.button5.Text = "Archivované súbory z dekódovania";
			this.button5.UseVisualStyleBackColor = true;
			this.button5.Click += new System.EventHandler(this.button5_Click);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.BackColor = System.Drawing.Color.Red;
			this.label3.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.label3.ForeColor = System.Drawing.Color.White;
			this.label3.Location = new System.Drawing.Point(0, 424);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(632, 26);
			this.label3.TabIndex = 7;
			this.label3.Text = "Upozornenie !!! Niektoré špeciálne znaky ako písmená s mäkčeňom alebo dĺžňom majú" +
    " rovnaké kódovanie ako normálne písmená. \r\nPreto niekedy pri dekódovaní môžu nas" +
    "tať chyby. ";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSize = true;
			this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.BackColor = System.Drawing.Color.Khaki;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.button5);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "Form1";
			this.Text = "MorzeApp_main";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Button button5;
		private System.Windows.Forms.Label label3;
	}
}

