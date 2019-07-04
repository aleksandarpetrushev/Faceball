using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Faceball
{
	//Klasa za golovite
	[Serializable]
	public class Goal
	{	
		public Rectangle rectangle { get; set; }
		public int Tim { get; set; }

		public Goal(int tim, Point point, int width, int height, Color color)
		{
			rectangle = new Rectangle(point.X, point.Y, width, height);
			Tim = tim;
		}

		public Goal()
		{
		}

		public void Draw(Graphics g)
		{
			Brush b = new SolidBrush(Color.AliceBlue);
			g.FillRectangle(b, rectangle);
			b.Dispose();
		}

		public bool IsGoal(Point point)
		{
			return rectangle.Contains(point);
		}
		
	}
}
