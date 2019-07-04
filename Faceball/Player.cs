using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Faceball
{
    public enum DIRECTION
    {
        UP, UPRIGHT, RIGHT, DOWNRIGHT, DOWN, DOWNLEFT, LEFT, UPLEFT
    }
    [Serializable]
	public class Player
    {
        public static int MAX_VELOCITY = 20;
        public static int RADIUS = 25;
        public Point Center { get; set; }
        public Icon Icon { get; set; }
        public float velocityX { get; set; }
        public float velocityY { get; set; }
		public double Velocity { get; set; }
		public bool VodiTopka { get; set; }
        public double Angle { get; set; }
        public bool isMoving { get; set; }

		public Player(Point center, Icon icon, bool vodiTopka, double angle, bool isMoving)
		{
			Center = center;
			Icon = icon;
			Velocity = 0;
			velocityX = (float)(Math.Cos(Angle) * Velocity);
			velocityY = (float)(Math.Sin(Angle) * Velocity);
			VodiTopka = vodiTopka;
			Angle = angle;
			this.isMoving = isMoving;
		}

		public Player()
        {
			Velocity = 0;
        }

        public void MoveUp()
        {
            velocityY -= 5;
			isMoving = true;
			Console.WriteLine("VO MOVE UP" + isMoving);
        }

        public void MoveDown()
        {
            velocityY += 5;
			isMoving = true;
		}

        public void MoveRight()
        {
            velocityX += 5;
			isMoving = true;

		}

        public void MoveLeft()
        {
            velocityX -= 5;
			isMoving = true;
		}

        public void Move(int left, int top, int width, int height)
        {
            if (isMoving)
            {
				if (Velocity + 0.5 < MAX_VELOCITY) Velocity += 0.5;
				float nextX = Center.X + velocityX;
				float nextY = Center.Y + velocityY;
				int lft = left + RADIUS;
				int rgt = left + width - RADIUS;
				int tp = top + RADIUS;
				int btm = top + height - RADIUS;

                if (nextX <= lft)
                {
                    nextX = Center.X;
                }
                if (nextX >= rgt)
                {
                    nextX = Center.X;
                }
                if (nextY <= tp)
                {
                    nextY = Center.Y;
                }
                if (nextY >= btm)
                {
                    nextY = Center.Y;
                }
                Center = new Point((int)nextX, (int)nextY);
            }
			else
			{
				if(Velocity - 0.5 > 0) Velocity -= 0.5;
			}
        }

        public bool Shoot()
        {
            if (VodiTopka)
            {
                VodiTopka = false;
                return true;
            }

            return false;
        }

        public void DecreaseVelocity()
        {
            if (!isMoving)
            {
                velocityX -= 3;
                velocityY -= 3;
                if (velocityX < 0)
                    velocityX = 0;
                if (velocityY < 0)
                    velocityY = 0;
            }
        }

        public void IncreaseVelocity()
        {
            if (isMoving)
            {
                velocityX += 3;
                velocityY += 3;
                if (velocityX > MAX_VELOCITY)
                    velocityX = MAX_VELOCITY;
                if (velocityY > MAX_VELOCITY)
                    velocityY = MAX_VELOCITY;
            }
        }

        public void Draw(Graphics g)
        {
			Brush b = new SolidBrush(Color.Red);
			g.FillEllipse(b, Center.X, Center.Y, RADIUS, RADIUS);
            b.Dispose();
            //g.DrawIcon(Icon, Center.X, Center.Y);
        }
    }
}
