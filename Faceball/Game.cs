using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Faceball
{
	public partial class Game : Form
	{
        Scene scene;
        string FileName;

        public Game()
		{
			scene = new Scene(3);
			scene.Ball.Position = new Point(530, 368);
			InitializeComponent();
            DoubleBuffered = true;
            FileName = null;
			newGame();
		}

		public void newGame()
		{
			

		}

		private void panelScore_Paint(object sender, PaintEventArgs e)
		{
			lblScore1.Text = scene.ScorePlayer1.ToString();
			lblScore2.Text = scene.ScorePlayer2.ToString();
		}
		private void saveFile()
        {
            if (FileName == null)
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "Faceball document (*.fcb)|*.fcb";
                saveFileDialog.Title = "Save Faceball file";
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    FileName = saveFileDialog.FileName;
                }
            }
            if (FileName != null)
            {
                using (FileStream fileStream = new FileStream(FileName, FileMode.Create))
                {
                    IFormatter formatter = new BinaryFormatter();
                    formatter.Serialize(fileStream, scene);
                }
            }
        }
        private void openFile()
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Faceball document (*.fcb)|*.fcb";
            openFileDialog.Title = "Open Faceball file";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                FileName = openFileDialog.FileName;
                try
                {
                    using (FileStream fileStream = new FileStream(FileName, FileMode.Open))
                    {
                        IFormatter formater = new BinaryFormatter();
                        scene = (Scene)formater.Deserialize(fileStream);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Could not read file: " + FileName);
                    FileName = null;
                    return;
                }
                Invalidate(true);
            }
        }

        private void timerUpdate_Tick(object sender, EventArgs e)
        {
            int who = scene.UpdateScene(63, 73, 910, 600);
            if (who == 1)
            {
                MessageBox.Show("Player 1 Wins");
            }
            if (who == 2)
            {
                MessageBox.Show("Player 2 Wins");
            }
            Invalidate(true);
        }

        private void Game_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                scene.Player1.MoveUp();
            }
        }

		private void Game_Paint(object sender, PaintEventArgs e)
		{
			scene.Draw(e.Graphics);
		}
	}
}
