/*
 Author: Ricardo Kim (CheatTrigger)
 Date: 25 Dezember 2017, 17:20
 Github: http://www.github.com/CTrigger
 Facebook: http://facebook.com/CheatTrigger

 Language: C#
 */

using System;
using System.Collections.Generic;
using System.Linq;
namespace xmasTreeConsoleCode
{
    class Program
    {
        
        static void ConsoleWait(int milisecond)
        {
            System.Threading.Thread.Sleep(milisecond);
        }
      
        static void Main(string[] args)
        {
            System.Media.SoundPlayer bgm = new System.Media.SoundPlayer();

            Random rnd = new Random();

            //Setup
            int delay = 100;
            bgm.SoundLocation = "./xmas.wav";

            List<ConsoleColor> cor = new List<ConsoleColor>();
            cor.Add(ConsoleColor.Blue);
            cor.Add(ConsoleColor.Cyan);
            cor.Add(ConsoleColor.Red);
            cor.Add(ConsoleColor.Yellow);
            cor.Add(ConsoleColor.White);
            cor.Add(ConsoleColor.Green);
            //setup end
            Console.ForegroundColor = ConsoleColor.Green;
            bgm.PlayLooping();
            while (true)
            {
                
               
                Console.WriteLine("                              ", Console.ForegroundColor = ConsoleColor.DarkGreen);
                Console.WriteLine("                              ", Console.ForegroundColor = ConsoleColor.DarkGreen);
                Console.WriteLine("              *               ", Console.ForegroundColor = ConsoleColor.DarkGreen);
                Console.WriteLine("             ***              ", Console.ForegroundColor = ConsoleColor.DarkGreen);

                Console.Write("            ***", Console.ForegroundColor = ConsoleColor.DarkGreen);
                Console.Write("o", Console.ForegroundColor = cor[rnd.Next(0, cor.Count())]);
                Console.WriteLine("*             ", Console.ForegroundColor = ConsoleColor.DarkGreen);

                Console.Write("           **", Console.ForegroundColor = ConsoleColor.DarkGreen);
                Console.Write("o", Console.ForegroundColor = cor[rnd.Next(0, cor.Count())]);
                Console.WriteLine("****            ", Console.ForegroundColor = ConsoleColor.DarkGreen);

                Console.WriteLine("          *********           ", Console.ForegroundColor = ConsoleColor.DarkGreen);

                Console.Write("         *", Console.ForegroundColor = ConsoleColor.DarkGreen);
                Console.Write("o", Console.ForegroundColor = cor[rnd.Next(0, cor.Count())]);
                Console.Write("*****", Console.ForegroundColor = ConsoleColor.DarkGreen);
                Console.Write("o", Console.ForegroundColor = cor[rnd.Next(0, cor.Count())]);
                Console.WriteLine("***          ", Console.ForegroundColor = ConsoleColor.DarkGreen);

                Console.WriteLine("        *************         ", Console.ForegroundColor = ConsoleColor.DarkGreen);

                Console.Write("       *******", Console.ForegroundColor = ConsoleColor.DarkGreen);
                Console.Write("o", Console.ForegroundColor = cor[rnd.Next(0, cor.Count())]);
                Console.Write("***", Console.ForegroundColor = ConsoleColor.DarkGreen);
                Console.Write("o", Console.ForegroundColor = cor[rnd.Next(0, cor.Count())]);
                Console.WriteLine("***        ", Console.ForegroundColor = ConsoleColor.DarkGreen);

                Console.Write("      ***", Console.ForegroundColor = ConsoleColor.DarkGreen);
                Console.Write("o", Console.ForegroundColor = cor[rnd.Next(0, cor.Count())]);
                Console.WriteLine("*************       ", Console.ForegroundColor = ConsoleColor.DarkGreen);

                Console.Write("     **************", Console.ForegroundColor = ConsoleColor.DarkGreen);
                Console.Write("o", Console.ForegroundColor = cor[rnd.Next(0, cor.Count())]);
                Console.WriteLine("****      ", Console.ForegroundColor = ConsoleColor.DarkGreen);

                Console.Write("    ******", Console.ForegroundColor = ConsoleColor.DarkGreen);
                Console.Write("o", Console.ForegroundColor = cor[rnd.Next(0, cor.Count())]);
                Console.WriteLine("**************     ", Console.ForegroundColor = ConsoleColor.DarkGreen);

                Console.WriteLine("             |W|              ", Console.ForegroundColor = ConsoleColor.DarkYellow);
                Console.WriteLine("             |W|              ", Console.ForegroundColor = ConsoleColor.DarkYellow);
                Console.WriteLine("                              ", Console.ForegroundColor = ConsoleColor.DarkGreen);

                Console.WriteLine("       Merry xmas 2018        ", Console.ForegroundColor = ConsoleColor.White);
                ConsoleWait(delay);
                Console.Clear();
            };
           
        }
    }
}
