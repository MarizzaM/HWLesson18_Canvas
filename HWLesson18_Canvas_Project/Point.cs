using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HWLesson18_Canvas_Project
{
    internal class Point
    {
        private int x;
        private int y;

        internal Point(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        internal int GetX() 
        {
            return this.x;
        }

        internal int GetY()
        {
            return this.y;
        }

        internal void SetX(int x)
        {
            this.x = x;
        }

        internal void SetY(int y)
        {
            this.y = y;
        }
        public override string ToString()
        {
            return $"({x}, {y})";
        }
    }
}
