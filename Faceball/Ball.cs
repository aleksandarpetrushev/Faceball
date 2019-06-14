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
        public Point Center { get; set; }
        public int velocityX { get; set; }
        public int velocityY { get; set; }
		public double Velocity { get; set; }
		public bool IsMoving { get; set; }
		public bool EVodena { get; set; }
		public Player player { get; set; }

		public Ball(Point Center, int velocityX, int velocityY, double velocity, bool isMoving, bool eVodena, Player player)
		{
			Center = Center;
			velocityX = velocityX;
			velocityY = velocityY;
			Velocity = velocity;
			IsMoving = isMoving;
			EVodena = eVodena;
			this.player = player;
		}

		public void Move()
		{

		}
	}
}
