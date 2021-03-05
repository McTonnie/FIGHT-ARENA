using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FIGHT_ARENA
//        string test = "  (p o_o)p　q(o_o q)";
{
    class Program
    {
        //initializeing the list remaining
        public static RemainingHerros remainingheros = new RemainingHerros();

        static void Main(string[] args)
        {

            Createherros();


            Console.WriteLine();
            Console.ReadKey();
        }

        public static string Winner()
        {
            string winner = remainingheros.Remaining[0].Name;
            return winner;
        }

        public static void Createherros()
        {
            Hero kungFuHarry = new Hero("Kung Fu Harry", 2, 2, 5, 5, 120);
            Hero superundenDino = new Hero("Superhunden Dino", 8, 6, 8, 2, 70);

            Hero hurtigKarl = new Hero("Hurtig karl", 5, 2, 3, 3, 90);   //atention this is not normal

            Hero giftGunner = new Hero("Gift Gunner", 13, 1, 5, 5, 90);
            Hero minimusenMikkel = new Hero("Minimusen Mikkel", 9, 9, 9, 9, 40);

            Hero kattenTiger = new Hero("Katten Tiger", 6, 3, 4, 4, 35); //atention this is not normal


            Hero gummigedenIvan = new Hero("Gummigeden Ivan", 6, 6, 8, 8, 70);
            Hero elgenEgon = new Hero("Elgen Egon", 11, 5, 4, 4, 90);

            remainingheros.addtolist(kungFuHarry);
            remainingheros.addtolist(superundenDino);
            remainingheros.addtolist(hurtigKarl);
            remainingheros.addtolist(giftGunner);
            remainingheros.addtolist(minimusenMikkel);
            remainingheros.addtolist(kattenTiger);
            remainingheros.addtolist(gummigedenIvan);
            remainingheros.addtolist(elgenEgon);
        }

        public static void Fight()
        {
            Random rdn = new Random();
            List<int> figters = new List<int>(NotTheSameRandom());
            //this for loop will run for every fight running at the same time
            for (int i = 0; i < (remainingheros.Remaining.Count - 1); i = i + 2)
            {

                Hero figther1 = remainingheros.Remaining[figters[i]];
                Hero figther2 = remainingheros.Remaining[figters[i + 1]];
                int numberOfRounds = 0;
                do
                {
                    numberOfRounds++;
                    if (figther1.Name == "Hurtig karl" || figther1.Name == "Katten Tiger")
                    {

                        //her skal kampen være ifen under første til sidst



                        if (figther2.Name == "Katten Tiger")
                        {

                        }
                    }
                    else
                    {
                        int figther1_atack = figther1.randomefect(figther1.AtackMin, figther1.AtackMax);
                        int figther2_defence = figther2.randomefect(figther2.DefenceMin, figther2.DefenceMax);

                        if (figther1_atack > figther2_defence)
                        {
                            figther2.Hitpoints = figther2.Hitpoints - figther1_atack;
                        }
                    }



                } while (figther1.Hitpoints > 0 || figther2.Hitpoints > 0);



            }



        }

        public static List<int> NotTheSameRandom()
        {
            Random rdn = new Random();
            List<int> figters = new List<int>();

            //this is running for each remaing hero in the remaing list 
            for (int i = 0; i < remainingheros.Remaining.Count; i++)
            {
                if (!figters.Contains(i))
                {
                    figters.Add(i);
                    int temprandom;
                    do
                    {
                        temprandom = rdn.Next(0, remainingheros.Remaining.Count);
                    } while (figters.Contains(temprandom));
                    figters.Add(temprandom);
                }
            }

            return figters;
        }



    }
}
