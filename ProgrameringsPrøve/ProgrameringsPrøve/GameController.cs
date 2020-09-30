using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrameringsPrøve
{
    class GameController
    {
        //making a array to select the fighters at random
        Fighter[] fighterList = new Fighter[8];
        //making a random 
        Random random = new Random();

        //making all the fighters with their HP, ATK and DEF
        public void MakeFighters()
        {
            //using the Fighter Constructor since they all have the same
            Fighter harry = new Fighter("Kong Fu Harry", 120, 2, 2, 5, 5);
            Fighter dino = new Fighter("Super Hunden Dino", 70, 6, 8, 2, 8);
            Fighter karl = new Fighter("Hurtig Karl", 90, 2, 5, 0, 0);
            Fighter gunner = new Fighter("Gift Gunner", 90, 1, 13, 5, 5);
            Fighter ivan = new Fighter("Gummigeden Ivan", 70, 6, 6, 8, 8);
            Fighter egon = new Fighter("Elgen Egon", 90, 5, 11, 4, 4);
            Fighter mikkel = new Fighter("Minimusen Mikkel", 40, 9, 9, 27, 27);
            //using the KattenTiger Construcktor to also input the life of the tiger
            KattenTiger tiger = new KattenTiger("Katten Tiger", 35, 3, 6, 0, 0, 9);
            //i should have made it so i could use all the atributes i made like minAtk and maxAtk
            //setting the Fighters in the array
            fighterList[0] = tiger;
            fighterList[1] = harry;
            fighterList[2] = dino;
            fighterList[3] = karl;
            fighterList[4] = gunner;
            fighterList[5] = ivan;
            fighterList[6] = egon;
            fighterList[7] = mikkel;
        }
        //selecting the first fighter with a random
        public Fighter FirstPlaceing()
        {
            int test = random.Next(8);
            Fighter first = null;

            if (fighterList[test] != null)
            {
                first = fighterList[test];
                fighterList[test] = null;
            }
            else
            {
                FirstPlaceing();
            }
            return first;
        }
        //selecting the second fighter with a random
        public Fighter SecondPlaceing()
        {
            int test = random.Next(8);
            Fighter second = null;

            if (fighterList[test] != null)
            {
                second = fighterList[test];
                fighterList[test] = null;
            }
            else
            {
                SecondPlaceing();
            }
            return second;
        }
        //finding the winner by keeping them fighting until one of them has a HP < 0
        public Fighter Winner(Fighter first, Fighter second)
        {
            

            int firstMinAtk = first.AtkMin;
            int firstMaxAtk = first.AtkMax;
            int firstMinDef = first.DefMin;
            int firstMaxDef = first.DefMax;
            int firstHP = first.HP;

            int secondMinAtk = second.AtkMin;
            int secondMaxAtk = second.AtkMax;
            int secondMinDef = second.DefMin;
            int secondMaxDef = second.DefMax;
            int secondHP = second.HP;

            while (firstHP > 0 || secondHP > 0)
            {
                //checking if the fighter has less than 0 def 
                if (secondMaxDef > 0)
                {
                    //destorying the def until it hit 0
                    if (firstMinAtk - secondMaxDef > 0)
                    {
                        secondMaxDef = firstMinAtk - secondMaxDef;
                    }
                    //if the atk is more than the def setting the def to 0
                    else
                    {
                        secondMaxDef = 0;
                    }
                }
                //if the fighter has 0 def it will lose HP 
                else
                {
                    secondHP = firstMinAtk - secondHP;
                }
                //checking if the fighter died so it does not attack while it is dead
                if (secondHP > 0)
                {
                    if (firstMaxDef > 0)
                    {

                        if (secondMinAtk - firstMaxDef > 0)
                        {
                            firstMaxDef = secondMinAtk - firstMaxDef;
                        }
                        else
                        {
                            firstMaxDef = 0;
                        }
                    }
                    else
                    {
                        firstHP = secondMinAtk - firstHP;
                    }
                }
            }
            //seing whos the winner and returning it
            if (firstHP > 0)
            {
                Fighter winner = first;
                return winner;
            }
            else
            {
                Fighter winner = second;
                return winner;
            }
        }
    }
}
