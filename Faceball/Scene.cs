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
        public static Point CourtCenter = new Point(150, 150); // Centar na terenot
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
        }

        public void Draw(Graphics g)
        {
            Player1.Draw(g);
			Goal1.Draw(g);
            Player2.Draw(g);
			Goal2.Draw(g);
            Ball.Draw(g);
        }

        public bool UpdateScene(int left, int top, int width, int height, bool isShoot)
        {
            Player1.Move(left, top, width, height);
            Player2.Move(left, top, width, height);
            Ball.Move(left, top, width, height, isShoot);
            if (Goal1.IsGoal(Ball.Position))  //Score za Desniot Player (Player 2)
            {
                ScorePlayer2++;
                if (ScorePlayer2 == WinScore)
                {
                    return true;
                }
                Ball.Position = CourtCenter;
            }
            if (Goal2.IsGoal(Ball.Position)) //Score za leviot player (Player 1) 
            {
                ScorePlayer1++;
                if (ScorePlayer1 == WinScore)
                {
                    return true;
                }
                Ball.Position = CourtCenter;
            }
            if (Ball.IsColiding(Player1))
            {
                Ball.EVodena = true;        //ako dojdat do topkata, pocnuvaat da ja vodat
                Ball.player = Player1;
            }
            if (Ball.IsColliding(Player2))
            {
                Ball.EVodena = true;
                Ball.player = Player2;
            }
            return false;
        }
    }
}
