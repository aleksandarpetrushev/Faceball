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
		bool Shoot;

        public Game()
		{
			InitializeComponent();
            DoubleBuffered = true;
            FileName = null;
			newGame();
		}

		public void newGame()
		{
			scene = new Scene(3);
			Invalidate(true);
			timerUpdate.Start();

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
			if (scene.Player1.MovingDown)
				scene.Player1.MoveDown();
			if (scene.Player1.MovingUp)
				scene.Player1.MoveUp();
			if (scene.Player1.MovingLeft)
				scene.Player1.MoveLeft();
			if (scene.Player1.MovingRight)
				scene.Player1.MoveRight();

			if (scene.Player2.MovingDown)
				scene.Player2.MoveDown();
			if (scene.Player2.MovingUp)
				scene.Player2.MoveUp();
			if (scene.Player2.MovingLeft)
				scene.Player2.MoveLeft();
			if (scene.Player2.MovingRight)
				scene.Player2.MoveRight();

			if (Shoot)
			{
				scene.Ball.Shoot();
			}
				

			int who = scene.UpdateScene(74, 65, 911, 606);
			
			if (who == 1)
            {
                MessageBox.Show("Player 1 Wins");
                int winScore = scene.WinScore;
				timerUpdate.Stop();
				newGame();
            }
            if (who == 2)
            {
                MessageBox.Show("Player 2 Wins");
                int winScore = scene.WinScore;
				timerUpdate.Stop();
				newGame();
			}
            Invalidate(true);
        }

        private void Game_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                scene.Player1.MovingUp = true;
            }
            if (e.KeyCode == Keys.Down)
            {
                scene.Player1.MovingDown = true;
            }
            if (e.KeyCode == Keys.Left)
            {
                scene.Player1.MovingLeft = true;
            }
            if (e.KeyCode == Keys.Right)
            {
                scene.Player1.MovingRight = true;
            }
            if (e.KeyCode == Keys.Enter && scene.Ball.player == scene.Player1)
            {
				Shoot = true;
            }
            if (e.KeyCode == Keys.W)
            {
                scene.Player2.MovingUp = true;
            }
            if (e.KeyCode == Keys.S)
            {
                scene.Player2.MovingDown = true;
            }
            if (e.KeyCode == Keys.A)
            {
                scene.Player2.MovingLeft = true;
            }
            if (e.KeyCode == Keys.D)
            {
                scene.Player2.MovingRight = true;
            }
            if (e.KeyCode == Keys.Space && scene.Ball.player == scene.Player2)
            {
				Shoot = true;
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
            if (e.KeyCode == Keys.Up)
            {
                scene.Player1.MovingUp = false;
            }
            if (e.KeyCode == Keys.Down)
            {
                scene.Player1.MovingDown = false;
            }
            if (e.KeyCode == Keys.Left)
            {
                scene.Player1.MovingLeft = false;
            }
            if (e.KeyCode == Keys.Right)
            {
                scene.Player1.MovingRight = false;
            }
            if (e.KeyCode == Keys.Enter)
            {
				Shoot = false;
            }
            if (e.KeyCode == Keys.W)
            {
                scene.Player2.MovingUp = false;
            }
            if (e.KeyCode == Keys.S)
            {
                scene.Player2.MovingDown = false;
            }
            if (e.KeyCode == Keys.A)
            {
                scene.Player2.MovingLeft = false;
            }
            if (e.KeyCode == Keys.D)
            {
                scene.Player2.MovingRight = false;
            }
            if (e.KeyCode == Keys.Space)
            {
				Shoot = false;
            }
            Invalidate(true);
        }

		private void Game_MouseClick_1(object sender, MouseEventArgs e)
		{
			Console.WriteLine(e.X + " " + e.Y);
		}
	}
}
