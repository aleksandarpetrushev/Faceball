using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Faceball
{
    [Serializable]
    public class Ball
    {
        public static int RADIUS = 15;
        public Point Position { get; set; }
		private float velocityX;
		private float velocityY;
		public double Velocity { get; set; }
		public bool IsMoving { get; set; }
		public bool EVodena { get; set; }
		public Player player { get; set; }
		public double Angle { get; set; }
		public Goal goal { get; set; }

		public Ball(Point Position, int velocityX, int velocityY, double velocity, bool isMoving, bool eVodena, Player player)
		{
			Position = Position;
			velocityX = velocityX;
			velocityY = velocityY;
			Velocity = velocity;
			IsMoving = isMoving;
			EVodena = eVodena;
			this.player = player;
		}

		public Ball(Point position)
		{
            Position = position;
			Velocity = 0;
		}
		public void Shoot()
		{
			Velocity = 20;
            EVodena = false;
            player = null;
		}

		public int Move(int left, int top, int width, int height)
		{
			
				//Ako se mrda ima dve sostojbi ili e vodena ili e shutnata ako ne togas miruva
				if (EVodena)
				{
					//Ako e vodena togas zemi velocity od playerot
					Velocity = player.Velocity;
				}
				else
				{
					if (Velocity == 0)
					{
						IsMoving = false;
					}
					if (IsMoving)
					{
						//Ako mrda se proveruva dali e u gol --- Treba da ima klasa za golot sto ke bide rectangle
						//Se proveruva dali vlegla vo golot taka sto se povikuva is coliding vo Goal klasata
						
						Velocity--;
						
					}
					
				}

            //74 322
            //76 414
            //41 413
            //41 325

            //986 325
            //987 414
            //1015 411
            //1020 324

            float nextX = Position.X + velocityX;
			float nextY = Position.Y + velocityY;
            if (nextY <= 414 && nextY >= 323 && nextX <= 75)
            {
                //goal player 2
                return 2;
            }
            else if (nextY >= 325 && nextY <= 413 && nextX >= 986)
            {
                //goal player 1
                return 1;
            }
            else { 
			    if (nextX - RADIUS <= left || nextX + RADIUS >= width + left)
			    {
				    velocityX = -velocityX;
			    }
			    if (nextY - RADIUS <= top || nextY + RADIUS >= height + top)
			    {
				    velocityY = -velocityY;
			    }
                Position = new Point((int)(Position.X + velocityX), (int)(Position.Y + velocityY));
            }
            return 0;
		}

		public void Draw(Graphics g)
		{
			Brush brush = new SolidBrush(Color.Red);
			g.FillEllipse(brush, Position.X - RADIUS, Position.Y - RADIUS, RADIUS * 2, RADIUS * 2);
			brush.Dispose();
		}

		public bool IsColiding(Player player) //ball se collide-nuva so player
		{
			double d = (Position.X - player.Center.X) * (Position.X - player.Center.X) + (Position.Y - player.Center.Y) * (Position.Y - player.Center.Y);
			return d <= (2 * RADIUS) * (2 * RADIUS);
		}
	}
}
