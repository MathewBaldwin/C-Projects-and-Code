using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Reflection;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string readMe = @"C:\Users\honda\Desktop\Borrowed Accounts.txt";
            if (!File.Exists(readMe))
            {
                
                string newTextFile = "Hello, Missing Something?";
                File.WriteAllText(readMe, newTextFile);
            }
            else
            {
                string readText = File.ReadAllText(readMe);
                Console.WriteLine(readText);
            }
            if (new FileInfo("C:/Users/honda/Desktop/Borrowed Accounts.txt").Length != 0)
            {
                Console.WriteLine("File is not empty");
            }
            else
            {
                Console.WriteLine("is empty");
            }
            using (StreamWriter stream = File.AppendText("C:/Users/honda/Desktop/Borrowed Accounts.txt"))
            {
                stream.WriteLine("\nthis is a new line");
            }
        }
    }
}






//would it be possible to use the kindect camera movement sensor to throw screens on different displays. I.E hold your hand still
// for a few seconds on the screen you want to copy, and move it to a different display in the room by just moving your hand to that display

    //have the sensor track your hand movements
    //stationary within a perimeter for 5 sconds means to copy the display
    //move your hand to a different display
    //stationary within a perimeter means drop the display
    //have the display placed in a temporary stasis or space in memory to move it
    //Transmit via HDMI or bluetooth converter
    //able to turn it on or off so you dont accidently push your display
//Start off with simple swipe gestures (maybe swipe to bring up bar and decide where you want the display to go)

