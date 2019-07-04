﻿using System;
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
        public static int MAX_VELOCITY = 10;
        public static int left = 74;
        public static int top = 65;
        public static int width = 911;
        public static int height = 606;
        public static int RADIUS = 12;
        public Point Center { get; set; }
        public Icon Icon { get; set; }
        public double velocityX { get; set; }
        public double velocityY { get; set; }
		public double Velocity { get; set; }
		public bool VodiTopka { get; set; }
        public double Angle { get; set; }
        public bool isMoving { get; set; }
        public bool MovingUp { get; set; }
        public bool MovingDown { get; set; }
        public bool MovingLeft { get; set; }
        public bool MovingRight { get; set; }

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
			velocityX = 0;
			velocityY = 0;
        }

        public void MoveUp()
        {
            velocityY -= 0.5;
			isMoving = true;
			Console.WriteLine("MOVE UP");
			Move();
		}

        public void MoveDown()
        {
            velocityY += 0.5;
			isMoving = true;
			Move();
			
		}

        public void MoveRight()
        {
            velocityX += 0.5;
			isMoving = true;
			Move();
		}

        public void MoveLeft()
        {
            velocityX -= 0.5;
			isMoving = true;
			Move();
		}

        public void Move()
        {
            
			if(velocityX > MAX_VELOCITY)
			{
				velocityX-=0.5;
			}
			if (velocityY > MAX_VELOCITY)
			{
				velocityY-=0.5;
			}

			if (Velocity + 0.5 < MAX_VELOCITY) Velocity += 0.5;
			double nextX = Center.X + velocityX;
			double nextY = Center.Y + velocityY;
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
			isMoving = false;
			
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
			if ((velocityX < 0) && (MovingLeft == false))
			{
				velocityX += 0.5;
			}
			else if (velocityX > 0 && MovingRight == false)
			{
				velocityX -= 0.5;
			}
			if ((velocityY < 0) && MovingUp == false)
			{
				velocityY += 0.5;
			}
			else if (velocityY > 0 && MovingDown == false)
			{
				velocityY -= 0.5;
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
			g.FillEllipse(b, Center.X-RADIUS, Center.Y-RADIUS, 2*RADIUS, 2*RADIUS);
            b.Dispose();
            //g.DrawIcon(Icon, Center.X, Center.Y);
        }
    }
}
