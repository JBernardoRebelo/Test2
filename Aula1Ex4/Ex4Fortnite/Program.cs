using System;
using System.Threading;

namespace Ex4Fortnite
{
    public class Program
    {
        private static void Main(string[] args)
        {
            Random rnd = new Random();
            Program program = new Program();

            // Default initialization
            FNPlayer p1 = new FNPlayer();

            // Sintaxe de inicialização de objectos com propriedades
            FNPlayer p2 = new FNPlayer("Ninja", rnd.Next(-50, 150));

            FNPlayer p3 = new FNPlayer("Dead", rnd.Next(-50, 150));

            while(p1.Hp + p2.Hp + p3.Hp >= 0)
            {
                Console.WriteLine("Player 1: " + p1.Skin + " HP: " + p1.Hp);
                Console.WriteLine("Player 2: " + p2.Skin + " HP " + p2.Hp);
                Console.WriteLine("Player 3: " + p3.Skin + " HP: " + p3.Hp);
                Thread.Sleep(3000);

                Console.WriteLine("p1 shoots p2");
                p1.Shoot(p2);

                Thread.Sleep(1000);

                Console.WriteLine("p2 shoots p3");
                p2.Shoot(p3);
                Thread.Sleep(1000);

                Console.WriteLine("p2 shoots p1");
                p2.Shoot(p1);
                Thread.Sleep(1000);

                Console.WriteLine("p1 heals");
                p1.Heal(rnd.Next(1,20));
                Thread.Sleep(1000);

                Console.WriteLine("p3 shoots p2");
                p3.Shoot(p2);
                Thread.Sleep(1000);

                Console.WriteLine("p2 heals");
                p2.Heal(rnd.Next(1, 20));
                Thread.Sleep(1000);

                Console.WriteLine("p1 shoots p3");
                p1.Shoot(p3);
                Thread.Sleep(1000);

                Console.WriteLine("p2 shoots p3");
                p2.Shoot(p3);
                Thread.Sleep(1000);

                Console.WriteLine("p3 shoots p1");
                p3.Shoot(p1);
                Thread.Sleep(1000);

                program.CheckHP(p1);
                program.CheckHP(p2);
                program.CheckHP(p3);

                program.CheckHPMax(p1);
                program.CheckHPMax(p2);
                program.CheckHPMax(p3);
            }

            Console.WriteLine("Hello Fortnite player!");
        }

        private void CheckHP(FNPlayer player)
        {
            if (player.Hp <= 0)
            {
                Console.WriteLine
                    ("Player with skin " + player.Skin + " has died");              
            }
        }

        private void CheckHPMax(FNPlayer player)
        {
            if (player.Hp >= 100)
            {
                player.Hp = 100;
            }
        }
    }
}
