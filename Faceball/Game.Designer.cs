using System;
using System.Windows.Forms;

namespace Faceball
{
	partial class Game
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
			this.components = new System.ComponentModel.Container();
			this.timerUpdate = new System.Windows.Forms.Timer(this.components);
			this.panelScore = new System.Windows.Forms.Panel();
			this.label3 = new System.Windows.Forms.Label();
			this.lblScore2 = new System.Windows.Forms.Label();
			this.lblScore1 = new System.Windows.Forms.Label();
			this.panelScore.SuspendLayout();
			this.SuspendLayout();
			// 
			// timerUpdate
			// 
			this.timerUpdate.Tick += new System.EventHandler(this.timerUpdate_Tick);
			// 
			// panelScore
			// 
			this.panelScore.Controls.Add(this.label3);
			this.panelScore.Controls.Add(this.lblScore2);
			this.panelScore.Controls.Add(this.lblScore1);
			this.panelScore.Location = new System.Drawing.Point(429, 12);
			this.panelScore.Name = "panelScore";
			this.panelScore.Size = new System.Drawing.Size(200, 48);
			this.panelScore.TabIndex = 0;
			this.panelScore.Paint += new System.Windows.Forms.PaintEventHandler(this.panelScore_Paint);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
			this.label3.Location = new System.Drawing.Point(93, 15);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(16, 24);
			this.label3.TabIndex = 2;
			this.label3.Text = "-";
			// 
			// lblScore2
			// 
			this.lblScore2.AutoSize = true;
			this.lblScore2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
			this.lblScore2.Location = new System.Drawing.Point(155, 15);
			this.lblScore2.Name = "lblScore2";
			this.lblScore2.Size = new System.Drawing.Size(20, 24);
			this.lblScore2.TabIndex = 1;
			this.lblScore2.Text = "0";
			// 
			// lblScore1
			// 
			this.lblScore1.AutoSize = true;
			this.lblScore1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
			this.lblScore1.Location = new System.Drawing.Point(32, 15);
			this.lblScore1.Name = "lblScore1";
			this.lblScore1.Size = new System.Drawing.Size(20, 24);
			this.lblScore1.TabIndex = 0;
			this.lblScore1.Text = "0";
			// 
			// Game
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = global::Faceball.Properties.Resources.Field;
			this.ClientSize = new System.Drawing.Size(1091, 736);
			this.Controls.Add(this.panelScore);
			this.DoubleBuffered = true;
			this.Name = "Game";
			this.Text = "Game";
			this.Paint += new System.Windows.Forms.PaintEventHandler(this.Game_Paint);
			this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Game_KeyDown);
			this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Game_KeyUp);
			this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Game_MouseClick_1);
			this.panelScore.ResumeLayout(false);
			this.panelScore.PerformLayout();
			this.ResumeLayout(false);

		}

		

		#endregion

		private System.Windows.Forms.Timer timerUpdate;
        private System.Windows.Forms.Panel panelScore;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblScore2;
        private System.Windows.Forms.Label lblScore1;
    }
}