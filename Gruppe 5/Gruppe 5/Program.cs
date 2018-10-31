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
            int loft2dino = 17;
            int dino2ground = 0;
            int dinoCounter = 0;
            bool isRunning = true;
            int gameSpeed = 50;
            int gameSpeedCounter = 0;
            bool cactusOnGround = false;
            

            string dino = "                    __\n" +
                          "                   / _)\n" +
                          "         _.----._ / /\n" +
                          "        /        _ /\n" +
                          "    _ _/ (  | (  |\n" +
                          "  / __.- '|_|--|_|";
            bool dinoTop = false;

            while (isRunning == true) { // isRunning
                cactusOnGround = false;
                string movingGround = "________________________________________________________________________________________________________________________";

                // Make random number from 0-10, if number is < 5, spawn cactus on current run-through
                Random rndNum = new Random();
                int nextRndNum = rndNum.Next(0, 10);
                if (nextRndNum < 5) {
                    cactusOnGround = true;
                }

                for (int i = movingGround.Length - 1; i >= 0; i -= 1) {

                    //Spawns a cactus ('1') for current run-through of movingGround
                    if (cactusOnGround) {
                        char[] movingGroundArray = movingGround.ToCharArray();
                        movingGroundArray[i] = '1';
                        if (i < movingGround.Length - 1) { movingGroundArray[i + 1] = '_'; }
                        movingGround = new string(movingGroundArray);
                    }

                    for (int j = 0; j < heightOfPLayArea; j += 1) { Console.WriteLine(" "); } // Move ground down
                     dino = "                    __\n" +
                            "                   / _)\n" +
                            "         _.----._ / /\n" +
                            "        /        _ /\n" +
                            "    _ _/ (  | (  |\n" +
                            "  / __.- '|_|--|_|";

                    Console.WriteLine(dino);
                    Console.WriteLine(movingGround); // Print ground

                    { // Click the - at the left of this line if you are done editing

                        while ((Console.KeyAvailable && Console.ReadKey(true).Key == ConsoleKey.W)) {
                            Console.Write("W");
                        }

                        if (!dinoTop) {
                            while ((Console.KeyAvailable && Console.ReadKey(true).Key == ConsoleKey.Spacebar)) { // While spacebar is pressed/held down. Rest of program runs while this runs
                                if (dinoCounter >= 10) {
                                    dino2ground += 1;
                                    loft2dino -= 1;
                                }
                            }
                            dinoCounter += 1;

                        } else {
                            if (dinoCounter >= 5) {
                                dino2ground -= 1;
                                loft2dino += 1;
                                dinoCounter = 2;
                            }
                            dinoCounter += 1;
                        }

                        if (dino2ground >= 5) {
                            dinoTop = true;
                        } else if (dino2ground <= 0) {
                            dinoTop = false;
                        }

                        while ((Console.KeyAvailable && Console.ReadKey(true).Key == ConsoleKey.Escape)) {
                            goto end;
                        }
                    } // Buttons. Expand by clicking the + at the left of this line. Remember to close after edit.


                    Thread.Sleep(gameSpeed);
                    Console.Clear();

                    // Speeds the game up after a while 
                    /*
                    if (gameSpeedCounter >= 10) {
                        if (gameSpeed > 10) {
                            gameSpeed -= 1;
                            gameSpeedCounter = 0;
                        }
                    }
                    gameSpeedCounter += 1;
                    */

                }
                movingGround = "________________________________________________________________________________________________________________________";

            }



            end:;
            Console.Clear();
            Console.WriteLine("Du vandt");

        }
        public void dinoRunning()
        {
            // Dinosaur / Player - Running
            string dinoRun =
            "                    __\n" +
            "                   / _)\n" +
            "         _.----._ / /\n" +
            "        /        _ /\n" +
            "    _ _/ (  | (  |\n" +
            "  / __.-'/_/-- |_|";

            string dinoRun2 =
            "                    __\n" +
            "                   / _)\n" +
            "         _.----._ / /\n" +
            "        /        _ /\n" +
            "    _ _/ (  | (  |\n" +
            "  / __.- '|_|--/_/";

            Console.WriteLine(dinoRun); // Print Running Dinosaur
            Console.WriteLine(dinoRun2); // Print Running Dinosaur
        }

        public void dinoJumping()
        {
            string dinoJump =
            "                    __\n" +
            "                   / _)\n" +
            "         _.----._ / /\n" +
            "        /        _ /\n" +
            "    _ _/ (  | (  |\n" +
            "  / __.- '|_|--|_|";

            Console.WriteLine(dinoJump);
        }



        public void FunktionerSkrivesHer() {
            //Kaldes med Myfuntions.NavnetP�Funktionen i Main"
        }

        
        
    }
}
            DateTime timeStarted = DateTime.Now;
                    DateTime timeSinceStarted = DateTime.Now;
                    double totalminutes = (timeSinceStarted - timeStarted).TotalSeconds;
                    string timeRunning = "Seconds running: " + totalminutes;
                    Console.WriteLine(timeRunning.PadLeft(120));
                    for (int j = 0; j < loft2dino; j += 1) { Console.WriteLine(" "); } // Move ground down

                    Console.WriteLine(dino);
                    for (int j = 0; j < dino2ground; j += 1) { Console.WriteLine(" "); } // Move ground down
        end:;

