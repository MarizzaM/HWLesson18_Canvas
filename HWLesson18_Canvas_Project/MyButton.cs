using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HWLesson18_Canvas_Project
{
    internal class MyButton
    {
        protected Point topLeft;
        protected Point bottomRight;
        private int width;
        private int height;

        internal MyButton(Point topLeft, Point bottomRight)
        {
            this.topLeft = topLeft;
            this.bottomRight = bottomRight;
        }

        internal int GetWidth() 
        {
            return this.width = this.bottomRight.GetX() - this.topLeft.GetX() + 1;
        }

        internal int GetHeight()
        {
            return  this.height = this.bottomRight.GetY() - this.topLeft.GetY() + 1;
        }

        internal bool SetTopLeft(Point p) 
        {
            if (this.bottomRight.GetX() > p.GetX() && this.bottomRight.GetY() > p.GetY())
            {
                return true;
            } 
            else 
            {
                return false;
            }
        }

        internal bool SetBottomRight(Point p)
        {
            if (p.GetX() > this.topLeft.GetX() && p.GetY() >- this.topLeft.GetY())
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        internal Point GetTopLeft() 
        {
            return this.topLeft;
        }
        internal Point GetBottomRight()
        {
            return this.bottomRight;
        }

        public override string ToString()
        {
            GetWidth();
            GetHeight();
            return $"top-left: {this.topLeft}; bottom-right: {this.bottomRight} \n Width of the button is {this.width} pixel" +
                $"\n Hight of the button is {this.height} pixel";
        }
    }
}
