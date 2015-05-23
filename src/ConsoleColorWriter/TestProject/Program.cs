using System;
using SHEePYTaGGeRNeP.ConsoleColorWriter;

namespace TestProject
{
    class Program
    {
        static void Main(string[] args)
        {
            CCW.WriteColoredText("Hello", ConsoleColor.Black, ConsoleColor.Cyan);
            try
            {
                Convert.ToInt16("test");
            }
            catch (Exception lvEx)
            {
                CCW.WriteErrorMessage(lvEx.Message);
            }
            CCW.WriteColoredText("Do you like ", ConsoleColor.White, ConsoleColor.Black, false, false);
            CCW.WriteColoredText("c", ConsoleColor.Red, ConsoleColor.Black, false, false);
            CCW.WriteColoredText("o", ConsoleColor.Yellow, ConsoleColor.Black, false, false);
            CCW.WriteColoredText("l", ConsoleColor.DarkMagenta, false, false);
            CCW.WriteColoredText("o", ConsoleColor.Green, ConsoleColor.Black, false, false);
            CCW.WriteColoredText("r", ConsoleColor.Blue, ConsoleColor.Black, false, false);
            CCW.WriteColoredText("s", ConsoleColor.DarkYellow, ConsoleColor.Black, false, false);
            CCW.WriteColoredText("?", ConsoleColor.DarkCyan, ConsoleColor.Black,true, false);
            Console.ReadKey();

            CCW.WriteColoredText("Press Enter to exit",ConsoleColor.DarkGray,ConsoleColor.DarkMagenta,true,true);
            Console.ReadLine();
        }
    }
}
