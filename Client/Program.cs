using HWLesson18_Canvas_Project;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client
{
    class Program
    {
        static void Main(string[] args)
        {
            MyCanvas.CreateNewButton(1, 8, 10, 12);
            MyCanvas.CreateNewButton(1, 6, 20, 10);
            MyCanvas.CreateNewButton(1, 11, 30, 12);

            MyCanvas.Print();

            Console.WriteLine("\nMoveButton(0, 0, 7)");
            MyCanvas.MoveButton(0, 0, 7);
            MyCanvas.Print();

            Console.WriteLine("\nThe Max Width Of A Button is " + MyCanvas.GetTheMaxWidthOfAButton());
            Console.WriteLine("\nThe Max Height Of A Button is " + MyCanvas.GetTheMaxHeightOfAButton());
            Console.WriteLine("\nCurrent Number Of Buttons " + MyCanvas.GetCurrentNumberOfButtons());
            Console.WriteLine("\nIs Point Inside A Button? " + MyCanvas.IsPointInsideAButton(200,200));
            Console.WriteLine("\nIs Point Inside A Button? " + MyCanvas.IsPointInsideAButton(1, 7));

            Console.WriteLine("\nDeleteLastButton()");
            MyCanvas.DeleteLastButton();
            MyCanvas.Print();

            Console.WriteLine("\nClearAllButtons()");
            MyCanvas.ClearAllButtons();
            Console.WriteLine("Current Number Of Buttons: " + MyCanvas.GetCurrentNumberOfButtons());


        }
    }
}
