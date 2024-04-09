using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPM_Game
{
    class Program
    {
        static void Main(string[] args)
        {
            start:
            //Vars            
            string ans;// string for the given number
            string yourans;// string for the number to subtract your given number
            int xans;// your given number
            int subans;//your number to subtract the given number
            int yans = 2;//the CPU given number
            int go = 0;//game over code
            int zans = 0;//subtracted number of the CPU's given Number
            bool winner = false;//to check who won
            string nameans;//answer to your name
            string opsans;//opponent's answers
            string myans;//your answers
            string opans;//opponent's name
            string vsans;//to know what mode
            int op;//op's number 
            string ops;//
            int you;//your number
            string yous;
            string given;//your givens
            int giv;//your given number
            string who;//who is the first one
            bool opfirst = false;//opponent first
            bool youfirst = false;//you first
            bool p1win = false;//p1 win
            bool p2win = false;

            // Starting!
            Console.Title = "SPM Game";
            Console.WriteLine("Hello Fellow Human");
            Console.WriteLine("What's Your Name?");
            nameans = Console.ReadLine();
            Console.WriteLine("Hello {0}", nameans);
            Console.WriteLine("I'm Stryker");
            Console.WriteLine("");
            Console.WriteLine("Let's Play a Game");
            modestart:
            Console.WriteLine("What Mode Would You Want?");
            Console.WriteLine("A.SinglePlayer or B.MultiPlayer");
            vsans = Console.ReadLine();
            Console.WriteLine("");

            //SinglePlayer! 
            if (vsans == "SinglePlayer" || vsans == "singleplayer" || vsans == "Singleplayer" || vsans == "singlePlayer" || vsans == "a" || vsans == "A")
            {
                Console.WriteLine("You Chose SingePlayer Mode!");
                Console.WriteLine("");
                Console.WriteLine("Choose a Number Above 30 and We will subtract it with the numbers 1 or 2, whoever gets the number 0 or below first wins");
                Console.WriteLine("Choose a Number Above 30:");
                //Give the Number
                ans = Console.ReadLine();
                xans = Int32.Parse(ans);
                //Loop if given # is wrong 
                while (xans <= 30 || xans > 100)
                {
                    Console.WriteLine("Your Given Number is {0}", xans);
                    Console.WriteLine("Wrong Number");
                    Console.WriteLine("Choose a Number Above 30:");
                    ans = Console.ReadLine();
                    xans = Int32.Parse(ans);
                }
                //Given #
                Console.WriteLine("");
                Console.WriteLine(" {0} Your Given Number is {1}", nameans, xans);
                Console.WriteLine("");
                //Game Mechanics - The Real Game Part
                //Subtracting the Given# using Loop
                while (xans >= 0)
                {
                    //The Pattern of The Game
                    if (xans % 3 == 0)
                    {
                        yans = 2;
                        if (xans % 3 == 0)
                        {
                            yans = 2;
                        }
                    }
                    else if (xans % 3 != 0)
                    {
                        yans = 1;
                        if (xans % 3 != 0)
                        {
                            yans = 1;
                        }
                    }
                    Console.WriteLine("I will Minus {0} with {1}", xans, yans);
                    zans = xans -= yans;
                    winner = false;
                    Console.WriteLine("It's now {0}", zans);
                    if (xans <= 0)
                    {
                        if (winner == false)
                        {
                            Console.WriteLine("");
                            Console.WriteLine("Game Over! - You Lose {0}", nameans);
                            Console.WriteLine("");
                            Console.WriteLine("Click Any Button To Exit");
                            Console.ReadKey();
                            Environment.Exit(go);
                        }
                        else if (winner == true)
                        {
                            Console.WriteLine("");
                            Console.WriteLine("Game Over! - You Win {0}", nameans);
                            Console.WriteLine("");
                            Console.WriteLine("Click Any Button To Exit");
                            Console.ReadKey();
                            Environment.Exit(go);
                        }
                    }
                    Console.WriteLine("What's Your Number {0}?", nameans);

                    yourans = Console.ReadLine();
                    subans = Int32.Parse(yourans);
                    if (subans >= 3)
                    {
                        Console.WriteLine("Game Over!- You Cheated {0}", nameans);
                        Console.WriteLine("");
                        Console.WriteLine("Click Any Button To Exit");
                        Console.ReadKey();
                        Environment.Exit(go);
                        subans = 0;
                    }
                    else
                    {
                        winner = true;
                    }
                    xans -= subans;
                    Console.WriteLine("");
                    Console.WriteLine("It's {0} then", xans);
                    if (xans <= 0)
                    {
                        if (winner == false)
                        {
                            Console.WriteLine("");
                            Console.WriteLine("Game Over! - You Lose {0}", nameans);
                            Console.WriteLine("");
                            Console.WriteLine("Click Any Button To Exit");
                            Console.ReadKey();
                            Environment.Exit(go);
                        }
                        else if (winner == true)
                        {
                            Console.WriteLine("");
                            Console.WriteLine("Game Over! - You Win {0}", nameans);
                            Console.WriteLine("");
                            Console.WriteLine("Click Any Button To Exit");
                            Console.ReadKey();
                            Environment.Exit(go);
                        }
                    }
                }
            }
            //MultiPlayer
            else if (vsans == "MultiPlayer " || vsans == "multiplayer" || vsans == "Multiplayer" || vsans == "multiPlayer" || vsans == "b" || vsans == "B")
            {
                //Game Start 
                Console.WriteLine("You Chose MultiPlayer Mode!");
                Console.WriteLine("What's Your Opponent's Name?");
                opans = Console.ReadLine();
                Console.WriteLine("{0} will be battling {1}", nameans, opans);
                Console.WriteLine("");
                Console.WriteLine("Choose a Number above 30");
                given = Console.ReadLine();
                giv = Int32.Parse(given);
                while (giv <= 30 || giv > 100)
                {
                    Console.WriteLine("Your Given Number is {0}", giv);
                    Console.WriteLine("Wrong Number");
                    Console.WriteLine("Choose a Number Above 30:");
                    given = Console.ReadLine();
                    giv = Int32.Parse(given);
                }
                //who goes first
                whoplayfirst:
                Console.WriteLine("Who will play first?");
                who = Console.ReadLine();
                if (who == nameans)
                {
                    Console.WriteLine("{0} will go first", nameans);
                    youfirst = true;
                    opfirst = false;
                }
                else if (who == opans)
                {
                    Console.WriteLine("{0} will go first", opans);
                    youfirst = false;
                    opfirst = true;
                }
                else if (who != nameans || who != opans)
                {
                    Console.WriteLine("There is no {0} playing right now", who);
                    goto whoplayfirst;
                }
                if (opfirst == true)
                {
                    while (giv >= 0)
                    {
                        Console.WriteLine("{0} choose a number between 1 or 2 subtract {1}", opans, giv);
                        ops = Console.ReadLine();
                        op = Int32.Parse(ops);
                        if (op >= 3)
                        {
                            Console.WriteLine("Game Over!- {0} Cheated ", opans);
                            Console.WriteLine("");
                            Console.WriteLine("Click Any Button To Exit");
                            Console.ReadKey();
                            Environment.Exit(go);
                            op = 0;
                        }
                        p2win = true;
                        p1win = false;
                        giv -= op;
                        Console.WriteLine("It's now {0}", giv);
                        Console.WriteLine("{0} What's Yours?", nameans);
                        yous = Console.ReadLine();
                        you = Int32.Parse(yous);
                        if (you >= 3)
                        {
                            Console.WriteLine("Game Over!- {0} Cheated ", nameans);
                            Console.WriteLine("");
                            Console.WriteLine("Click Any Button To Exit");
                            Console.ReadKey();
                            Environment.Exit(go);
                            you = 0;
                        }
                        p2win = false;
                        p1win = true;
                        giv -= you;
                        Console.WriteLine("It's {0} then", giv);
                        if (giv <= 0)
                        {
                            if (p1win == true)
                            {
                                Console.WriteLine("Game Over!- {0} Wins ", nameans);
                                Console.WriteLine("");
                                Console.WriteLine("Click Any Button To Exit");
                                Console.ReadKey();
                                Environment.Exit(go);
                            }
                            else if (p2win == true)
                            {
                                Console.WriteLine("Game Over!- {0} Wins ", opans);
                                Console.WriteLine("");
                                Console.WriteLine("Click Any Button To Exit");
                                Console.ReadKey();
                                Environment.Exit(go);
                            }
                        }
                    }
                }
                else if (youfirst == true)
                {
                    while (giv >= 0)
                    {
                        Console.WriteLine("{0} choose a number between 1 or 2 subtract {1}", nameans, giv);
                        yous = Console.ReadLine();
                        you = Int32.Parse(yous);
                        if (you >= 3)
                        {
                            Console.WriteLine("Game Over!- {0} Cheated ", nameans);
                            Console.WriteLine("");
                            Console.WriteLine("Click Any Button To Exit");
                            Console.ReadKey();
                            Environment.Exit(go);
                            you = 0;
                        }
                        p2win = false;
                        p1win = true;
                        giv -= you;
                        Console.WriteLine("It's now {0}", giv);
                        if (giv <= 0)
                        {
                            if (p1win == true)
                            {
                                Console.WriteLine("Game Over!- {0} Wins ", nameans);
                                Console.WriteLine("");
                                Console.WriteLine("Click Any Button To Exit");
                                Console.ReadKey();
                                Environment.Exit(go);
                            }
                            else if (p2win == true)
                            {
                                Console.WriteLine("Game Over!- {0} Wins ", opans);
                                Console.WriteLine("");
                                Console.WriteLine("Click Any Button To Exit");
                                Console.ReadKey();
                                Environment.Exit(go);
                            }
                        }
                        Console.WriteLine("{0} What's Yours?", opans);
                        ops = Console.ReadLine();
                        op = Int32.Parse(ops);
                        if (op >= 3)
                        {
                            Console.WriteLine("Game Over!- {0} Cheated ", opans);
                            Console.WriteLine("");
                            Console.WriteLine("Click Any Button To Exit");
                            Console.ReadKey();
                            Environment.Exit(go);
                            op = 0;
                        }
                        p2win = true;
                        p1win = false;
                        giv -= op;
                        Console.WriteLine("It's {0} then", giv);
                        if (giv <= 0)
                        {
                            if (p1win == true)
                            {
                                Console.WriteLine("Game Over!- {0} Wins ", nameans);
                                Console.WriteLine("");
                                Console.WriteLine("Click Any Button To Exit");
                                Console.ReadKey();
                                Environment.Exit(go);
                            }
                            else if (p2win == true)
                            {
                                Console.WriteLine("Game Over!- {0} Wins ", opans);
                                Console.WriteLine("");
                                Console.WriteLine("Click Any Button To Exit");
                                Console.ReadKey();
                                Environment.Exit(go);
                            }
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Wrong Mode");
                    Console.WriteLine("");
                    goto modestart;
                }
            }

        }
    }
}
