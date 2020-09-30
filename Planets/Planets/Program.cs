using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Planets
{
    class Program
    {
        static void Main(string[] args)
        {
            Planets mercury = new Planets("Mercury", 0.330f, 4879, 5427, 3.7f, 1407.6f, 4222.6f, 57.9f, 88, 47.4f, 167, 0, false);
            Planets earth = new Planets("Earth", 5.97f, 12756, 5514, 9.8f, 23.9f, 24, 149.6f, 365.2f, 29.8f, 15, 1, false);
            Planets mars = new Planets("Mars",0.642f,6792,3933,3.7f,24.6f,24.7f,227.9f,687,24.1f,-65,2,false);
            Planets jupiter = new Planets("Jupiter",1898,142984,1326,23.1f,9.9f,9.9f,778.6f,4331,13.1f,-110,67,true);
            Planets saturn = new Planets("Saturn",568,120536,687,9,10.7f,10.7f,1433.5f,10747,9.7f,-140,62,true);
            Planets uranus = new Planets("Uranus",86.8f,51118,1271,8.7f,-17.2f,17.2f,2872.5f,30589,6.8f,-195,27,true);
            Planets neptune = new Planets("Neptune",102,49528,1638,11,16.1f,16.1f,4495.1f,59.8f,5.4f,-200,14,true);
            Planets pluto = new Planets("Pluto",0.0146f,2370,2095,0.7f,-153.3f,153.3f,5906.4f,90.56f,4.7f,-225,5,false);
            Planets venus = new Planets("Venus",0.330f,4879,5427,3.7f,1407.6f,4222.6f,57.9f,88,47.4f,167,0,false);


            List<Planets> planetList = new List<Planets>();

            planetList.Add(mercury);
            planetList.Add(earth);
            planetList.Add(mars);
            planetList.Add(jupiter);
            planetList.Add(saturn);
            planetList.Add(uranus);
            planetList.Add(neptune);
            planetList.Add(pluto);

            foreach (Planets item in planetList)
            {
                Console.WriteLine(item.Name);
            }
            Console.WriteLine("\nNow with Venus\n");

            planetList.Insert(1, venus);

            foreach (Planets item in planetList)
            {
                Console.WriteLine(item.Name);
            }
            Console.WriteLine("\nNow with out Pluto\n");

            planetList.RemoveAt(8);

            foreach (Planets item in planetList)
            {
                Console.WriteLine(item.Name);
            }

            Console.WriteLine("\npluto is back bby\n");

            planetList.Add(pluto);
            foreach (Planets item in planetList)
            {
                Console.WriteLine(item.Name);
            }

            Console.WriteLine("\nThe number of planets: " + planetList.Count);

            //now a new list with mean planets
            List<Planets> meanPlanetList = new List<Planets>();
            
            meanPlanetList.Add(mars);
            meanPlanetList.Add(jupiter);
            meanPlanetList.Add(saturn);
            meanPlanetList.Add(uranus);
            meanPlanetList.Add(neptune);
            meanPlanetList.Add(pluto);

            Console.WriteLine("\nnow all the mean planets\n");

            foreach (Planets item in meanPlanetList)
            {
                Console.WriteLine(item.Name);
            }

            List<Planets> mediumPlanets = new List<Planets>();

            mediumPlanets.Add(venus);
            mediumPlanets.Add(earth);
            mediumPlanets.Add(neptune);

            Console.WriteLine("\nnow all the medium planets or rather all the planets what has a diameter over 10000 and under 50000\n");

            foreach (Planets item in mediumPlanets)
            {
                Console.WriteLine(item.Name);
            }

            Console.WriteLine("\nnow to delete em all from all the lists\n");

            meanPlanetList.RemoveRange(0,5);
            planetList.RemoveRange(0, 9);
            mediumPlanets.RemoveRange(0, 2);

            Console.WriteLine("\ndone\n");
            Console.ReadKey();
        }
    }
}
