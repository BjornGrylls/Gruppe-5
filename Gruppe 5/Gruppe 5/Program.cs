using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;


namespace Gruppe_5 {
    class Program {
        static void Main(string[] args) {

            // Initialize things
            Program MyFunctions = new Program();
            int heightOfPLayArea = 17;
            bool isRunning = true;
            int gameSpeed = 50;
            int counter = 0;
            
            while (isRunning == true) { // isRunning
                string movingGround = "______________________________________________________________________________________________________";
                for (int i = movingGround.Length-1; i >= 0; i -= 1) {
                    char[] movingGroundArray = movingGround.ToCharArray();
                    movingGroundArray[i] = '1';
                    if (i < movingGround.Length-1) { movingGroundArray[i + 1] = '_'; }
                    movingGround = new string(movingGroundArray);

                    for (int j = 0; j < heightOfPLayArea; j += 1) { Console.WriteLine(" "); } // Move ground down
                    Console.WriteLine(movingGround); // Print ground

                    { // Click the - at the left of this line if you are done editing
                        while ((Console.KeyAvailable && Console.ReadKey(true).Key == ConsoleKey.W)) { // While spacebar is pressed/held down. Rest of program runs while this runs
                            Console.WriteLine("WWWWW");
                        }

                        while ((Console.KeyAvailable && Console.ReadKey(true).Key == ConsoleKey.Spacebar)) { // While spacebar is pressed/held down. Rest of program runs while this runs
                            Console.WriteLine("Jumping");
                        }

                        while ((Console.KeyAvailable && Console.ReadKey(true).Key == ConsoleKey.Escape)) { // 
                            goto end;
                        }
                    } // Buttons. Expand by clicking the + at the left of this line. Remember to close after edit.
                    

                    Thread.Sleep(gameSpeed);
                    Console.Clear();

                    // Speeds the game up after a while
                    if (counter >= 10) {
                        if (gameSpeed > 10) {
                            gameSpeed -= 1;
                            counter = 0;
                        }
                    }
                    counter += 1;


                }
                movingGround = "______________________________________________________________________________________________________";

            }

            end:;
            Console.Clear();
            Console.WriteLine("Du vandt");

        }

        public void FunktionerSkrivesHer() {
            //Kaldes med Myfuntions.NavnetP�Funktionen i Main"
        }


        public void PrintDino() {
            Console.WriteLine(  "            Oo\n" +
                                "           O\n" +
                                "          Oooo\n" +
                                "         O\n" +
                                "       O  O\n" +
                                "      OO  o\n" +
                                "     o    oo");
        }

<<<<<<< HEAD
=======
        public void JumpTester() {
            do {
                Console.WriteLine("Jumping");
            } while (Console.ReadKey(true).Key == ConsoleKey.Spacebar);
        }
        public void printDino()
        {
            Console.WriteLine("            Oo\n" +
                    "           O\n" +
                    "          Oooo\n" +
                    "         O\n" +
                    "       O  O\n" +
                    "      OO  o\n" +
                    "     o    oo");
        }
        
>>>>>>> master
    }
}
