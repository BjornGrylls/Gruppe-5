using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;


namespace Gruppe_5 {
    class Program {
        static void Main(string[] args) {

            Console.WriteLine("Press ESC to stop");
            do {
                while (!Console.KeyAvailable) { // isRunning



                    string movingGround = "___________________________________________________________________________";


                    for (int i = movingGround.Length-1; i >= 0; i -= 1) {
                        char[] movingGroundArray = movingGround.ToCharArray();
                        movingGroundArray[i] = '1';
                        if (i < movingGround.Length-1) { movingGroundArray[i + 1] = '_'; }
                        movingGround = new string(movingGroundArray);
                        for (int j = 0; j < 11; j+=1) { // Move ground down
                            Console.WriteLine("|");
                        }
                        Console.WriteLine(movingGround);
                        Thread.Sleep(50);
                        Console.Clear();
                        
                    }
                    movingGround = "___________________________________________________________________________";


                }
            } while (Console.ReadKey(true).Key != ConsoleKey.Escape); // until esc is pressed. Only works when the 1 is not on the line
        }

        
    }
}
