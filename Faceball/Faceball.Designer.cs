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
            this.panelMainMenu = new System.Windows.Forms.Panel();
            this.lblMainMenu = new System.Windows.Forms.Label();
            this.pictureFootball = new System.Windows.Forms.PictureBox();
            this.btnStartGame = new System.Windows.Forms.Button();
            this.btnOptions = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.panelMainMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureFootball)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMainMenu
            // 
            this.panelMainMenu.Controls.Add(this.btnExit);
            this.panelMainMenu.Controls.Add(this.btnOptions);
            this.panelMainMenu.Controls.Add(this.btnStartGame);
            this.panelMainMenu.Controls.Add(this.pictureFootball);
            this.panelMainMenu.Controls.Add(this.lblMainMenu);
            this.panelMainMenu.Location = new System.Drawing.Point(12, 12);
            this.panelMainMenu.Name = "panelMainMenu";
            this.panelMainMenu.Size = new System.Drawing.Size(776, 426);
            this.panelMainMenu.TabIndex = 0;
            // 
            // lblMainMenu
            // 
            this.lblMainMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblMainMenu.Font = new System.Drawing.Font("Jokerman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMainMenu.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblMainMenu.Location = new System.Drawing.Point(0, 0);
            this.lblMainMenu.Name = "lblMainMenu";
            this.lblMainMenu.Size = new System.Drawing.Size(776, 426);
            this.lblMainMenu.TabIndex = 0;
            this.lblMainMenu.Text = "Main Menu";
            this.lblMainMenu.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pictureFootball
            // 
            this.pictureFootball.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureFootball.Image = global::Faceball.Properties.Resources.footballImg_removebg_preview;
            this.pictureFootball.Location = new System.Drawing.Point(310, 69);
            this.pictureFootball.Name = "pictureFootball";
            this.pictureFootball.Size = new System.Drawing.Size(148, 144);
            this.pictureFootball.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureFootball.TabIndex = 1;
            this.pictureFootball.TabStop = false;
            // 
            // btnStartGame
            // 
            this.btnStartGame.Location = new System.Drawing.Point(336, 251);
            this.btnStartGame.Name = "btnStartGame";
            this.btnStartGame.Size = new System.Drawing.Size(92, 36);
            this.btnStartGame.TabIndex = 2;
            this.btnStartGame.Text = "Start Game";
            this.btnStartGame.UseVisualStyleBackColor = true;
            // 
            // btnOptions
            // 
            this.btnOptions.Location = new System.Drawing.Point(336, 293);
            this.btnOptions.Name = "btnOptions";
            this.btnOptions.Size = new System.Drawing.Size(92, 36);
            this.btnOptions.TabIndex = 3;
            this.btnOptions.Text = "Options";
            this.btnOptions.UseVisualStyleBackColor = true;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(336, 335);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(92, 36);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            // 
            // Faceball
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelMainMenu);
            this.Name = "Faceball";
            this.Text = "Form1";
            this.panelMainMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureFootball)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMainMenu;
        private System.Windows.Forms.PictureBox pictureFootball;
        private System.Windows.Forms.Label lblMainMenu;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnOptions;
        private System.Windows.Forms.Button btnStartGame;
    }
}

