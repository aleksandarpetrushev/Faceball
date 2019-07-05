using Faceball.Properties;
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
        public static int RADIUS = 13;
        public Point Position { get; set; }
		public double velocityX { get; set; }
		public double velocityY { get; set; }
		public double Velocity { get; set; }
		public bool IsMoving { get; set; }
		public bool EVodena { get; set; }
		public Player player { get; set; }
		public double Angle { get; set; }
		public Goal goal { get; set; }
        public Image Icon { get; set; }

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
			//Velocity = 20;
			if(player != null)
			{

				EVodena = false;
				player.VodiTopka = false;
				if(velocityX != 0 || velocityY != 0)
				{
					velocityX = 3 * velocityX;
					velocityY = 3 * velocityY;
				}
				Position = new Point((int)(Position.X + velocityX), (int)(Position.Y + velocityY));
				player.Shoot();
				player = null;
			}
		}

		public int Move(int left, int top, int width, int height)
		{

			//Ako se mrda ima dve sostojbi ili e vodena ili e shutnata ako ne togas miruva
			if (EVodena)
			{
				//Ako e vodena togas zemi velocity od playerot
				velocityX = player.velocityX;
				velocityY = player.velocityY;
			}
			else
			{
				if ((velocityX < 0))
				{
					velocityX += 0.5;
				}
				else if (velocityX > 0)
				{
					velocityX -= 0.5;
				}
				if ((velocityY < 0))
				{
					velocityY += 0.5;
				}
				else if (velocityY > 0)
				{
					velocityY -= 0.5;
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

            int nextX = (int)(Position.X + velocityX);
			int nextY = (int)(Position.Y + velocityY);
			int lft = left + RADIUS;
			int rgt = left + width - RADIUS;
			int tp = top + RADIUS;
			int btm = top + height - RADIUS;

			if (nextY <= 414 && nextY >= 323 && nextX <= 80)
            {
                //goal player 2
                return 2;
            }
            else if (nextY >= 325 && nextY <= 413 && nextX >= 970)
            {
                //goal player 1
                return 1;
            }
            else
			{
				if (nextX <= lft)
				{
					nextX = lft + (lft - nextX);
					velocityX = -velocityX;
				}
				if (nextX >= rgt)
				{
					nextX = rgt - (nextX - rgt);
					velocityX = -velocityX;

				}
				if (nextY <= tp)
				{
					nextY = tp + (tp - nextY);
					velocityY = -velocityY;
				}
				if (nextY >= btm)
				{
					nextY = btm - (nextY - btm);
					velocityY = -velocityY;
				}
				Position = new Point(nextX, nextY);

            }
            return 0;
		}

		public void Draw(Graphics g)
		{
            Brush brush = new SolidBrush(Color.Red);
            g.DrawImage(Resources.Ball_removebg_preview, Position.X - RADIUS, Position.Y - RADIUS, 2 * RADIUS, 2 * RADIUS);
            brush.Dispose();
		}

		public bool IsColiding(Player player) //ball se collide-nuva so player
		{
			double d = (Position.X - player.Center.X) * (Position.X - player.Center.X) + (Position.Y - player.Center.Y) * (Position.Y - player.Center.Y);
			return d <= (2 * RADIUS) * (2 * RADIUS);
		}
	}
}
