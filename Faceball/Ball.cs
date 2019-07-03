using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Faceball
{
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

		public void Move(int left, int top, int width, int height, bool isShoot)
		{
			if (isShoot)
			{
				//Ednas se shutira 
				if(Velocity == 0)
				{
					IsMoving = false;
				}
				else
				{
					IsMoving = true;
				}
				
			}
			else
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

			}
			velocityX = (float)(Math.Cos(Angle) * Velocity);
			velocityY = (float)(Math.Sin(Angle) * Velocity);
			float nextX = Position.X + velocityX;
			float nextY = Position.Y + velocityY;
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

		public void Draw(Graphics g)
		{
			Brush brush = new SolidBrush(Color.Red);
			g.FillEllipse(brush, Position.X - RADIUS, Position.Y - RADIUS, RADIUS * 2, RADIUS * 2);
			brush.Dispose();
		}

		public bool IsColiding(Ball ball)
		{
			double d = (Position.X - ball.Position.X) * (Position.X - ball.Position.X) + (Position.Y - ball.Position.Y) * (Position.Y - ball.Position.Y);
			return d <= (2 * RADIUS) * (2 * RADIUS);
		}
	}
}
