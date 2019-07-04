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
			timerUpdate.Start();
			newGame();
            timerUpdate.Start();
		}

		public void newGame()
		{
			scene = new Scene(3);
			scene.Ball.Position = new Point(500, 300);

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
            int who = scene.UpdateScene(74, 63, 900, 600);

            if (who == 1)
            {
                MessageBox.Show("Player 1 Wins");
                int winScore = scene.WinScore;
                scene = new Scene(winScore);
            }
            if (who == 2)
            {
                MessageBox.Show("Player 2 Wins");
                int winScore = scene.WinScore;
                scene = new Scene(winScore);
            }
            Invalidate(true);
        }

        private void Game_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                scene.Player1.MoveUp();
            }
            else if (e.KeyCode == Keys.Down)
            {
                scene.Player1.MoveDown();
            }
            else if (e.KeyCode == Keys.Left)
            {
                scene.Player1.MoveLeft();
            }
            else if (e.KeyCode == Keys.Right)
            {
                scene.Player1.MoveRight();
            }
            else if (e.KeyCode == Keys.Enter)
            {
                scene.Ball.Shoot();
            }
            else if (e.KeyCode == Keys.W)
            {
                scene.Player2.MoveUp();
            }
            else if (e.KeyCode == Keys.S)
            {
                scene.Player2.MoveDown();
            }
            else if (e.KeyCode == Keys.A)
            {
                scene.Player2.MoveLeft();
            }
            else if (e.KeyCode == Keys.D)
            {
                scene.Player2.MoveRight();
            }
            else if (e.KeyCode == Keys.Space)
            {
                scene.Ball.Shoot();
            }
            Invalidate(true);
        }

        private void panelScore_Paint(object sender, PaintEventArgs e)
        {
            lblScore1.Text = scene.ScorePlayer1.ToString();
            lblScore2.Text = scene.ScorePlayer2.ToString();
        }

        private void Game_MouseClick(object sender, MouseEventArgs e)
        {
            Console.WriteLine(e.X + " " + e.Y);
        }
		private void Game_Paint(object sender, PaintEventArgs e)
		{
			scene.Draw(e.Graphics);
		}

		private void Game_KeyUp(object sender, KeyEventArgs e)
		{
			scene.DecreaseVelocity();
		}
	}
}
