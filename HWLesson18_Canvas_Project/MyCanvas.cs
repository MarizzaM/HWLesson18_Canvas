using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HWLesson18_Canvas_Project
{
    public class MyCanvas
    {
        public const int MAX_WIDTH = 800;
        public const int MAX_HEIGHT = 600;
        private static int buttonIndex = 0;
        private static int MaxButtons = 3;
        private static MyButton[] buttons = new MyButton[MaxButtons];

        public static bool CreateNewButton (int x1, int y1, int x2, int y2)
        {
            while (buttonIndex < MaxButtons)
            {
                buttons [buttonIndex] = new MyButton(new Point(x1, y1), new Point(x2, y2));
                buttonIndex++;
                return true;
            }
            return false;
        }

        public static bool MoveButton(int buttonNumber, int x, int y)
        {
            if (buttons[buttonNumber] == null)
            {
                return false;
            }
            else 
            {
                buttons[buttonNumber].GetTopLeft().SetX(buttons[buttonNumber].GetTopLeft().GetX() + x);
                buttons[buttonNumber].GetTopLeft().SetY(buttons[buttonNumber].GetTopLeft().GetY() + y);
                buttons[buttonNumber].GetBottomRight().SetX(buttons[buttonNumber].GetBottomRight() .GetX()+ x);
                buttons[buttonNumber].GetBottomRight().SetY(buttons[buttonNumber].GetBottomRight().GetY() + y);
                return true;
            }
        }

        public static bool DeleteLastButton()
        {
            if (buttonIndex == 0)
            {
                return false;
            }
            else
            {
                for (int i = MaxButtons - 1; i >= 0; i--) {
                    if (buttons[i] != null) {
                        buttons[i] = null;
                        buttonIndex--;
                        break;
                    }
                }
                return true;
            }
        }

        public static void ClearAllButtons()
        {
            if (buttonIndex != 0) {
                for (int i = 0; i < MaxButtons; i++) {
                    if (buttons[i] != null) {
                        buttons[i] = null;
                        buttonIndex--;
                    }   
                }
            }
        }

        public static int GetCurrentNumberOfButtons() {
            return buttonIndex;
        }

        public static int GetMaxNumberOfButtons() {
            return MaxButtons;
        }

        public static int GetTheMaxWidthOfAButton() {
            int maxWidth = 0;
            if (buttonIndex != 0)
            {
                for (int i = 0; i < buttons.Length; i++)
                {
                    maxWidth = buttons[i].GetWidth() > maxWidth ? maxWidth = buttons[i].GetWidth() : maxWidth;
                }
            }
            return maxWidth;
        }

        public static int GetTheMaxHeightOfAButton() {
            int maxHeight = 0;
            if (buttonIndex != 0)
            {
                for (int i = 0; i < buttons.Length; i++)
                {
                    maxHeight = buttons[i].GetHeight() > maxHeight ? maxHeight = buttons[i].GetHeight() : maxHeight;
                }
            }
            return maxHeight;
        }

        public static bool IsPointInsideAButton(int x, int y) {
            for (int i = 0; i < buttons.Length; i++)
            {
                if (buttons[i] != null && x >= buttons[i].GetTopLeft().GetX() && x <= buttons[i].GetBottomRight().GetX()
                    && y >= buttons[i].GetTopLeft().GetY() && y <= buttons[i].GetBottomRight().GetY()) 
                {
                    return true;
                }
            }
            return false;
        }

        public static void Print()
        {
            for (int i = 0; i < buttons.Length; i++) 
            {
                if (buttons[i] != null) {
                    Console.WriteLine($"\n Button #{i+1}: {buttons[i]}  ");
                }
                
            }
        }

        public override string ToString()
        {
            Print();
            return base.ToString();
        }
    }
}
