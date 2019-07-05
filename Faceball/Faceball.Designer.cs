namespace Faceball
{
    partial class Faceball
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Faceball));
			this.panelMainMenu = new System.Windows.Forms.Panel();
			this.btnLoadGame = new System.Windows.Forms.Button();
			this.btnExit = new System.Windows.Forms.Button();
			this.btnInstructions = new System.Windows.Forms.Button();
			this.btnPlay = new System.Windows.Forms.Button();
			this.panelMainMenu.SuspendLayout();
			this.SuspendLayout();
			// 
			// panelMainMenu
			// 
			this.panelMainMenu.BackgroundImage = global::Faceball.Properties.Resources.WorldCup_background;
			this.panelMainMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.panelMainMenu.Controls.Add(this.btnLoadGame);
			this.panelMainMenu.Controls.Add(this.btnExit);
			this.panelMainMenu.Controls.Add(this.btnInstructions);
			this.panelMainMenu.Controls.Add(this.btnPlay);
			this.panelMainMenu.Location = new System.Drawing.Point(1, 1);
			this.panelMainMenu.Name = "panelMainMenu";
			this.panelMainMenu.Size = new System.Drawing.Size(809, 451);
			this.panelMainMenu.TabIndex = 0;
			// 
			// btnLoadGame
			// 
			this.btnLoadGame.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnLoadGame.BackgroundImage")));
			this.btnLoadGame.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnLoadGame.Image = ((System.Drawing.Image)(resources.GetObject("btnLoadGame.Image")));
			this.btnLoadGame.Location = new System.Drawing.Point(331, 227);
			this.btnLoadGame.Name = "btnLoadGame";
			this.btnLoadGame.Size = new System.Drawing.Size(111, 49);
			this.btnLoadGame.TabIndex = 5;
			this.btnLoadGame.Text = "Load Game";
			this.btnLoadGame.UseVisualStyleBackColor = true;
			this.btnLoadGame.Click += new System.EventHandler(this.btnLoadGame_Click);
			// 
			// btnExit
			// 
			this.btnExit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnExit.BackgroundImage")));
			this.btnExit.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnExit.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.Image")));
			this.btnExit.Location = new System.Drawing.Point(331, 337);
			this.btnExit.Name = "btnExit";
			this.btnExit.Size = new System.Drawing.Size(111, 49);
			this.btnExit.TabIndex = 4;
			this.btnExit.Text = "Exit";
			this.btnExit.UseVisualStyleBackColor = true;
			this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
			// 
			// btnInstructions
			// 
			this.btnInstructions.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnInstructions.BackgroundImage")));
			this.btnInstructions.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnInstructions.Image = ((System.Drawing.Image)(resources.GetObject("btnInstructions.Image")));
			this.btnInstructions.Location = new System.Drawing.Point(331, 282);
			this.btnInstructions.Name = "btnInstructions";
			this.btnInstructions.Size = new System.Drawing.Size(111, 49);
			this.btnInstructions.TabIndex = 3;
			this.btnInstructions.Text = "Instructions";
			this.btnInstructions.UseVisualStyleBackColor = true;
			// 
			// btnPlay
			// 
			this.btnPlay.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPlay.BackgroundImage")));
			this.btnPlay.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnPlay.Image = ((System.Drawing.Image)(resources.GetObject("btnPlay.Image")));
			this.btnPlay.Location = new System.Drawing.Point(331, 172);
			this.btnPlay.Name = "btnPlay";
			this.btnPlay.Size = new System.Drawing.Size(111, 49);
			this.btnPlay.TabIndex = 2;
			this.btnPlay.Text = "Play";
			this.btnPlay.UseVisualStyleBackColor = true;
			this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
			// 
			// Faceball
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(811, 453);
			this.Controls.Add(this.panelMainMenu);
			this.ForeColor = System.Drawing.Color.Black;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "Faceball";
			this.Text = "Emojicup";
			this.panelMainMenu.ResumeLayout(false);
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMainMenu;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnInstructions;
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.Button btnLoadGame;
    }
}

