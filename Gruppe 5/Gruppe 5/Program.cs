using System;
using System.Threading;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gruppe_5 {
    class Program {
        static void Main(string[] args) {
            bool isRunning = true;
            
            while(isRunning == true) {

                string movingGround = "___________________________________________________________________________";


                for (int i = 0; i < movingGround.Length; i += 1)
                {
                    char[] movingGroundArray = movingGround.ToCharArray();
                    movingGroundArray[i] = '1';
                    if(i > 0) { movingGroundArray[i - 1] = '_'; }
                    movingGround = new string(movingGroundArray);
                    Console.WriteLine("|");
                    Console.WriteLine("|");
                    Console.WriteLine("|");
                    Console.WriteLine("|");
                    Console.WriteLine("|");
                    Console.WriteLine("|");
                    Console.WriteLine("|");
                    Console.WriteLine("|");
                    Console.WriteLine("|");
                    Console.WriteLine("|");
                    Console.WriteLine(movingGround);
                    Thread.Sleep(50);
                    Console.Clear();
                }
                movingGround = "___________________________________________________________________________";


            }


        }


        
    }
}
