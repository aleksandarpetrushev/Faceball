namespace Faceball
{
    partial class ChooseEmoji
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
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			this.button4 = new System.Windows.Forms.Button();
			this.button5 = new System.Windows.Forms.Button();
			this.button6 = new System.Windows.Forms.Button();
			this.button7 = new System.Windows.Forms.Button();
			this.button8 = new System.Windows.Forms.Button();
			this.button9 = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.BackColor = System.Drawing.Color.Transparent;
			this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.label1.Font = new System.Drawing.Font("Goudy Old Style", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.SystemColors.ControlLight;
			this.label1.Location = new System.Drawing.Point(65, 114);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(145, 45);
			this.label1.TabIndex = 8;
			this.label1.Text = "Player 1";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.BackColor = System.Drawing.Color.Transparent;
			this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.label2.Font = new System.Drawing.Font("Goudy Old Style", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.SystemColors.ControlLight;
			this.label2.Location = new System.Drawing.Point(551, 114);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(145, 45);
			this.label2.TabIndex = 9;
			this.label2.Text = "Player 2";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.BackColor = System.Drawing.Color.Transparent;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.ForeColor = System.Drawing.SystemColors.ControlLight;
			this.label3.Location = new System.Drawing.Point(297, 341);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(206, 46);
			this.label3.TabIndex = 19;
			this.label3.Text = "Win Score";
			// 
			// numericUpDown1
			// 
			this.numericUpDown1.Location = new System.Drawing.Point(331, 400);
			this.numericUpDown1.Name = "numericUpDown1";
			this.numericUpDown1.Size = new System.Drawing.Size(135, 20);
			this.numericUpDown1.TabIndex = 20;
			this.numericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
			// 
			// button1
			// 
			this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button1.Image = global::Faceball.Properties.Resources.buttonBackground;
			this.button1.Location = new System.Drawing.Point(631, 400);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(157, 38);
			this.button1.TabIndex = 21;
			this.button1.Text = "Lets Play";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// button2
			// 
			this.button2.BackColor = System.Drawing.Color.Transparent;
			this.button2.Image = global::Faceball.Properties.Resources.CrazyEmoji2;
			this.button2.Location = new System.Drawing.Point(12, 211);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(86, 80);
			this.button2.TabIndex = 22;
			this.button2.UseVisualStyleBackColor = false;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// button3
			// 
			this.button3.BackColor = System.Drawing.Color.Transparent;
			this.button3.Image = global::Faceball.Properties.Resources.hahaEmoji;
			this.button3.Location = new System.Drawing.Point(203, 211);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(85, 80);
			this.button3.TabIndex = 23;
			this.button3.UseVisualStyleBackColor = false;
			this.button3.Click += new System.EventHandler(this.button3_Click);
			// 
			// button4
			// 
			this.button4.BackColor = System.Drawing.Color.Transparent;
			this.button4.Image = global::Faceball.Properties.Resources.tiredEmoji;
			this.button4.Location = new System.Drawing.Point(294, 211);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(79, 80);
			this.button4.TabIndex = 24;
			this.button4.UseVisualStyleBackColor = false;
			this.button4.Click += new System.EventHandler(this.button4_Click);
			// 
			// button5
			// 
			this.button5.BackColor = System.Drawing.Color.Transparent;
			this.button5.Image = global::Faceball.Properties.Resources.excitedEmoji;
			this.button5.Location = new System.Drawing.Point(104, 211);
			this.button5.Name = "button5";
			this.button5.Size = new System.Drawing.Size(93, 80);
			this.button5.TabIndex = 25;
			this.button5.UseVisualStyleBackColor = false;
			this.button5.Click += new System.EventHandler(this.button5_Click);
			// 
			// button6
			// 
			this.button6.BackColor = System.Drawing.Color.Transparent;
			this.button6.Image = global::Faceball.Properties.Resources.excitedEmoji;
			this.button6.Location = new System.Drawing.Point(522, 211);
			this.button6.Name = "button6";
			this.button6.Size = new System.Drawing.Size(93, 80);
			this.button6.TabIndex = 29;
			this.button6.UseVisualStyleBackColor = false;
			this.button6.Click += new System.EventHandler(this.button6_Click);
			// 
			// button7
			// 
			this.button7.BackColor = System.Drawing.Color.Transparent;
			this.button7.Image = global::Faceball.Properties.Resources.tiredEmoji;
			this.button7.Location = new System.Drawing.Point(712, 211);
			this.button7.Name = "button7";
			this.button7.Size = new System.Drawing.Size(79, 80);
			this.button7.TabIndex = 28;
			this.button7.UseVisualStyleBackColor = false;
			this.button7.Click += new System.EventHandler(this.button7_Click);
			// 
			// button8
			// 
			this.button8.BackColor = System.Drawing.Color.Transparent;
			this.button8.Image = global::Faceball.Properties.Resources.hahaEmoji;
			this.button8.Location = new System.Drawing.Point(621, 211);
			this.button8.Name = "button8";
			this.button8.Size = new System.Drawing.Size(85, 80);
			this.button8.TabIndex = 27;
			this.button8.UseVisualStyleBackColor = false;
			this.button8.Click += new System.EventHandler(this.button8_Click);
			// 
			// button9
			// 
			this.button9.BackColor = System.Drawing.Color.Transparent;
			this.button9.Image = global::Faceball.Properties.Resources.CrazyEmoji2;
			this.button9.Location = new System.Drawing.Point(430, 211);
			this.button9.Name = "button9";
			this.button9.Size = new System.Drawing.Size(86, 80);
			this.button9.TabIndex = 26;
			this.button9.UseVisualStyleBackColor = false;
			this.button9.Click += new System.EventHandler(this.button9_Click);
			// 
			// ChooseEmoji
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = global::Faceball.Properties.Resources.WorldCup_background;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.button6);
			this.Controls.Add(this.button7);
			this.Controls.Add(this.button8);
			this.Controls.Add(this.button9);
			this.Controls.Add(this.button5);
			this.Controls.Add(this.button4);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.numericUpDown1);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "ChooseEmoji";
			this.Text = "ChooseEmoji";
			this.Load += new System.EventHandler(this.ChooseEmoji_Load);
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.NumericUpDown numericUpDown1;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Button button4;
		private System.Windows.Forms.Button button5;
		private System.Windows.Forms.Button button6;
		private System.Windows.Forms.Button button7;
		private System.Windows.Forms.Button button8;
		private System.Windows.Forms.Button button9;
	}
}