using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Faceball
{
    [Serializable]
    public class Scene
    {
        public static Point CourtCenter = new Point(529, 369); // Centar na terenot
        public int WinScore { get; set; }
        public Player Player1 { get; set; }
		public Goal Goal1 { get; set; }
		public Player Player2 { get; set; }
		public Goal Goal2 { get; set; }
		public Ball Ball { get; set; }
        public bool SinglePlayer { get; set; }
        public int ScorePlayer1 { get; set; }
        public int ScorePlayer2 { get; set; }

        public Scene(int WinScore)
        {
            this.WinScore = WinScore;
            ScorePlayer1 = ScorePlayer2 = 0;
			Player1 = new Player();
			Player1.Center = new Point(95, 369);
			Player2 = new Player();
			Player2.Center = new Point(967, 369);
			Ball = new Ball(CourtCenter);
			Player.Ball = Ball;
        }

		public void newGame()
		{

			Player1.Center = new Point(95, 369);
			Player2.Center = new Point(967, 369);
		}

		public void Draw(Graphics g)
        {
            Player1.Draw(g);
            Player2.Draw(g);
            Ball.Draw(g);
        }

        public int UpdateScene(int left, int top, int width, int height)
        {
			int goal = 0;
			Player1.Move();
			Player2.Move();
			Player1.DecreaseVelocity();
			Player2.DecreaseVelocity();
			Ball.EVodena=Ball.IsColiding(Player1);
			if (Ball.EVodena)
			{
				Ball.player = Player1;
				Player1.VodiTopka = true;
				Ball.Move(left, top, width, height);
			}
			else
			{
				Player1.VodiTopka = false;
			}
			Ball.EVodena = Ball.IsColiding(Player2);
			if (Ball.EVodena)
			{
				Ball.player = Player2;
				Player2.VodiTopka = true;
			}
			else
			{
				Player2.VodiTopka = false;
			}

			goal = Ball.Move(left, top, width, height);

			if (goal == 2)  //Score za Desniot Player (Player 2)
            {
                ScorePlayer2++;
				Ball.Position = CourtCenter;
				Ball.velocityX = 0;
				Ball.velocityY = 0;
				Player1.Center = new Point(95, 369);
				Player2.Center = new Point(967, 369);
				if (ScorePlayer2 == WinScore)
                {
                    return 2;
                }
                
			}
            if (goal == 1) //Score za leviot player (Player 1) 
            {
                ScorePlayer1++;
				Ball.Position = CourtCenter;
				Ball.velocityX = 0;
				Ball.velocityY = 0;
				Player1.Center = new Point(95, 369);
				Player2.Center = new Point(967, 369);
				if (ScorePlayer1 == WinScore)
                {
                    return 1;
                }
			}
            
            return 0;
			
        }

		internal void DecreaseVelocity()
		{
			Player1.DecreaseVelocity();
			Player2.DecreaseVelocity();
		}
	}
}
