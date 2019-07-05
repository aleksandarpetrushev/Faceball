using Faceball.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Faceball
{
    public partial class ChooseEmoji : Form
    {
		public Image image1 { get; set; }
		public Image image2 { get; set; }
		public int winScore { get; set; }
		public ChooseEmoji()
        {
            InitializeComponent();
			image1 = Resources.crazyEmoji;
			image2 = Resources.hahaEmoji;
			winScore = 1;
        }

		private void pictureBox8_Click(object sender, EventArgs e)
		{
			image2 = Resources.crazyEmoji;
		}

		private void pictureBox4_Click(object sender, EventArgs e)
		{
			image1 = Resources.hahaEmoji;
		}

		private void pictureBox3_Click(object sender, EventArgs e)
		{
			image1 = Resources.excitedEmoji;
		}

		private void pictureBox2_Click(object sender, EventArgs e)
		{
			image1 = Resources.tiredEmoji;
		}

		private void pictureBox6_Click_1(object sender, EventArgs e)
		{
			image2 = Resources.excitedEmoji;
		}

		private void pictureBox5_Click_1(object sender, EventArgs e)
		{
			image2 = Resources.tiredEmoji;
		}

		private void pictureBox7_Click(object sender, EventArgs e)
		{
			image2 = Resources.hahaEmoji;
		}

		private void pictureBox1_Click(object sender, EventArgs e)
		{
			image1 = Resources.crazyEmoji;
		}

		private void textBox1_TextChanged(object sender, EventArgs e)
		{

		}

		private void numericUpDown1_ValueChanged(object sender, EventArgs e)
		{
			winScore = (int)numericUpDown1.Value;
		}

		private void button1_Click(object sender, EventArgs e)
		{
			Game game = new Game();
			game.Image1 = image1;
			game.Image2 = image2;
			game.WinScore = winScore;
			this.Close();
			game.ShowDialog();
		}

		private void button4_Click(object sender, EventArgs e)
		{
			image1 = Resources.tiredEmoji;
		}

		private void ChooseEmoji_Load(object sender, EventArgs e)
		{

		}

		private void button2_Click(object sender, EventArgs e)
		{
			image1 = Resources.CrazyEmoji2;
		}

		private void button9_Click(object sender, EventArgs e)
		{
			image2 = Resources.CrazyEmoji2;
		}

		private void button5_Click(object sender, EventArgs e)
		{
			image1 = Resources.excitedEmoji;
		}

		private void button6_Click(object sender, EventArgs e)
		{
			image2 = Resources.excitedEmoji;
		}

		private void button3_Click(object sender, EventArgs e)
		{
			image1 = Resources.hahaEmoji;
		}

		private void button8_Click(object sender, EventArgs e)
		{
			image2 = Resources.hahaEmoji;
		}

		private void button7_Click(object sender, EventArgs e)
		{
			image2 = Resources.tiredEmoji;
		}
	}
}
