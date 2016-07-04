using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4_1
{
    class Point
    {
        private int X { get; set; }
        private int Y { get; set; }

        public Point(int x, int y) 
        {
            this.X = x;
            this.Y = y;
        }

        public override bool Equals(System.Object obj)
        {
            if (obj == null)
            {
                return false;
            }


            Point p = obj as Point;
            if ((System.Object)p == null)
            {
                return false;
            }


            return (X == p.X) && (Y == p.Y);
        }

    
        public override string ToString()
        {
            return $"X: {X.ToString()} Y: {X.ToString()}";
        }
    }
}
