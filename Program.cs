using System;
using System.Collections.Generic;
using System.Linq;

namespace LINQFinalFrontier
{
    class Program
    {
        static void Main(string[] args)
        {
            var spaceships = new List<Spaceship>();
            spaceships.Add(new Spaceship());
            spaceships.Add(new Spaceship());
            spaceships.Add(new Spaceship());
            spaceships.Add(new Spaceship());
            spaceships.Add(new Spaceship());
            spaceships.Add(new Spaceship());
            spaceships.Add(new Spaceship());
            spaceships.Add(new Spaceship());
            spaceships.Add(new Spaceship());
            spaceships.Add(new Spaceship());
            Console.WriteLine(sumOfEarthShips(spaceships));
            sendShipsToFightMonsters(spaceships);
            foreach (var item in ExplorationFleet(spaceships))
            {
                Console.WriteLine(item.Name);
            }
            
            Console.WriteLine(findMostGunsWithSize(spaceships, 15).Name);

        }
        //In Program.cs Write these functions using functional programming:
        public static int sumOfEarthShips(List<Spaceship> ships)
        {
            var earthShips = ships.Where(w => w.HasWarpDrive==false).Select(s => s.Name).Count();
            return earthShips;
        }

        public static void sendShipsToFightMonsters(List<Spaceship> ships)
        {
            var fightingShips = ships.Where(w => w.HasWarpDrive).ToList();
            foreach (Spaceship item in fightingShips)
            {
                item.fightSpaceMonster();
            }
        }

        public static Spaceship findMostGunsWithSize(List<Spaceship> ships, int size)
        {
            var fightingShips = ships.Where(w => w.Size == size).OrderByDescending(o => o.NumLasers).First();
            return fightingShips;
        }

        public static IEnumerable<Spaceship> ExplorationFleet(List<Spaceship> ships)
        {
            var reconShips = ships.Where(w => w.HasWarpDrive).OrderBy(o => o.NumLasers).Take(5).ToList();
            return reconShips;
        }
    }


}

