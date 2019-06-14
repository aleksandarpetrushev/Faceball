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
	public class Player
    {
        public static int MAX_VELOCITY = 20;
        public static int Radius = 25;
        public Point Position { get; set; }
        public Icon Icon { get; set; }
        public int VelocityX { get; set; }
        public int VelocityY { get; set; }
        public bool VodiTopka { get; set; }
        public double Angle { get; set; }
        public bool isMoving { get; set; }

        public Player()
        {
        }

        public void Move()
        {
            if (isMoving)
            {
                int newX = Position.X + VelocityX;
                int newY = Position.Y + VelocityY;
                Position = new Point(newX, newY);
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
                VelocityX -= 3;
                VelocityY -= 3;
                if (VelocityX < 0)
                    VelocityX = 0;
                if (VelocityY < 0)
                    VelocityY = 0;
            }
        }

        public void IncreaseVelocity()
        {
            if (isMoving)
            {
                VelocityX += 3;
                VelocityY += 3;
                if (VelocityX > MAX_VELOCITY)
                    VelocityX = MAX_VELOCITY;
                if (VelocityY > MAX_VELOCITY)
                    VelocityY = MAX_VELOCITY;
            }
        }

        public void Draw(Graphics g)
        {
            g.DrawIcon(Icon, Position.X, Position.Y);
        }
    }
}
