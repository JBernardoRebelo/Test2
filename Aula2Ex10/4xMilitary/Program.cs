using System;
using System.Numerics;
using System.Threading;
using System.Collections.Generic;

namespace _4xMilitary
{
    public class Program
    {
        private static void Main(string[] args)
        {
            Random rnd = new Random();

            // Vectors to move
            Vector2 vRight = new Vector2(10, 0);
            Vector2 vLeft = new Vector2(-10, 0);
            Vector2 vDown = new Vector2(0, 10);
            Vector2 vUp = new Vector2(0, -10);

            // Create list of units
            List<Unit> listU = new List<Unit>();

            // Units
            MilitaryUnit canon1 = new MilitaryUnit(PV(rnd), 50, 50);
            MilitaryUnit soldier = new MilitaryUnit(PV(rnd), 15, 10);
            MilitaryUnit sargent = new MilitaryUnit(PV(rnd), 25, 20);
            SettlerUnit villager = new SettlerUnit(PV(rnd), 10);
            SettlerUnit villager2 = new SettlerUnit(PV(rnd), 12);
            SettlerUnit horse = new SettlerUnit(PV(rnd), 20);

            // Add creations to list
            listU.Add(canon1);
            listU.Add(soldier);
            listU.Add(sargent);
            listU.Add(villager);
            listU.Add(villager2);
            listU.Add(horse);

            // Loop using everything case is setler or milatary
            foreach (Unit u in listU)
            {
                // int for movement randomizer
                int i = rnd.Next(1, 10);

                if (u is MilitaryUnit)
                {
                    MilitaryUnit mU = u as MilitaryUnit;

                    Console.WriteLine("Militia's... ");
                    Console.WriteLine("Position: " + mU.position);
                    Console.WriteLine(mU.ToString());

                    // Choose direction and moove
                    if (i > 6 && i <= 8) mU.Move(vRight);
                    if (i <= 2) mU.Move(vLeft);
                    if (i > 2 && i < 5) mU.Move(vUp);
                    if (i > 8 && i <= 10) mU.Move(vDown);

                    Console.WriteLine("Moved...");
                    Thread.Sleep(2000);
                    Console.WriteLine("Position: " + mU.position + "\n");

                }

                Thread.Sleep(2000);

                if (u is SettlerUnit)
                {
                    SettlerUnit sU = u as SettlerUnit;

                    Console.WriteLine("Setler's... ");
                    Console.WriteLine(sU.ToString());
                    Console.WriteLine("Position: " + sU.position);

                    // Choose direction and moove
                    if (i > 6 && i <= 8) sU.Move(vRight);
                    if (i <= 2) sU.Move(vLeft);
                    if (i > 2 && i < 5) sU.Move(vUp);
                    if (i > 8 && i <= 10) sU.Move(vDown);

                    Console.WriteLine("Moved...");
                    Thread.Sleep(2000);
                    Console.WriteLine("Position: " + sU.position + "\n");
                }
            }
        }

        // Returns a vector2 to assign positons to the units
        private static Vector2 PV(Random rnd)
        {
            int x = rnd.Next(1, 100);
            int y = rnd.Next(1, 100);
            Vector2 position = new Vector2(x, y);

            return position;
        }

    }
}
