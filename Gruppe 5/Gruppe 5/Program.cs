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

            bool isRunning = true;

            int gameSpeed = 35;
            int gameSpeedCounter = 0;

            // Cactus and things
            bool cactusOnGround = false;
            Random rndNum = new Random();
            string movingGround = "________________________________________________________________________________________________________________________";
            string cactus = 
            "   ___ \n" +
            "   | |\n" +
            "   | | \n" +
            "|| | | ||\n" +
            "||_| |_||\n" +
            "   | |\n" +
            "   | |\n"; 


            // Initialize animation of dino
            int dinoRunCounter = 0;


            // Initialize jumping things
            bool dinoTop = false;
            int loft2dino = 17;
            int dino2ground = 0;
            int dinoCounter = 0;

            // Initialize score and time things
            DateTime timeStarted = DateTime.Now;
            DateTime timeSinceStarted = DateTime.Now;
            double totalSeconds = (timeSinceStarted - timeStarted).TotalSeconds;
            string timeRunning = "Seconds running: " + totalSeconds;


            while (isRunning == true) { // While running == true
                cactusOnGround = false;
                movingGround = "________________________________________________________________________________________________________________________";

                // Make random number from 0-10, if number is < 5, spawn cactus on current run-through
                if (rndNum.Next(0, 10) < 7) {
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

                    timeSinceStarted = DateTime.Now;
                    totalSeconds = Math.Round((timeSinceStarted - timeStarted).TotalSeconds);
                    timeRunning = "Seconds running: " + totalSeconds;
                    Console.WriteLine(timeRunning.PadLeft(120));
                    for (int j = 0; j < loft2dino; j += 1) { Console.WriteLine(" "); } // Move ground down

                    dinoRunCounter = MyFunctions.PrintAnimatedDino(dinoRunCounter); // Dino is running

                    for (int j = 0; j < dino2ground; j += 1) { Console.WriteLine(" "); } // Move ground down
                    Console.WriteLine(movingGround); // Print ground

                    { // Click the - at the left of this line if you are done editing

                        while ((Console.KeyAvailable && Console.ReadKey(true).Key == ConsoleKey.W)) {
                            Console.WriteLine("                                    I");
                        }

                        if (!dinoTop) {
                            while ((Console.KeyAvailable && Console.ReadKey(true).Key == ConsoleKey.Spacebar)) { // While spacebar is pressed/held down. Rest of program runs while this runs
                                dinoCounter += 1;
                            }

                            if (dinoCounter >= 2) {
                                dino2ground += 1;
                                loft2dino -= 1;
                            }

                        } else {
                            if (dinoCounter >= 5) {
                                dino2ground -= 1;
                                loft2dino += 1;
                                dinoCounter = 0;
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

                    // Collision detection
                    if (i < 20 && dino2ground < 2 && cactusOnGround == true && i > 5) {
                        goto end;
                    }

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

            }

        end:;
            Console.Clear();
            Console.WriteLine("Du fik {0} point", totalSeconds);

        }

        public void FunktionerSkrivesHer() {
            //Kaldes med Myfuntions.NavnetPåFunktionen i Main"
        }

        public int PrintAnimatedDino(int dinoRunCounter) {
            string dinoRun1 =
            "                    __\n" +
            "                   / _)\n" +
            "         _.----._ / /\n" +
            "        /        _ /\n" +
            "    _ _/ (  | (  |\n" +
            "  / __.-'/_/---|_|";

            string dinoRun2 =
            "                    __\n" +
            "                   / _)\n" +
            "         _.----._ / /\n" +
            "        /        _ /\n" +
            "    _ _/ (  | (  |\n" +
            "  / __.-''|_|-/_/";

            if (dinoRunCounter >= 5) {
                Console.WriteLine(dinoRun1);
                if (dinoRunCounter >= 10) {
                    return 0;
                }
                dinoRunCounter += 1;
                return dinoRunCounter;
            }
            Console.WriteLine(dinoRun2);
            dinoRunCounter += 1;
            return dinoRunCounter;

        }


    }
}

