using System;
using System.Collections.Generic;
using System.Linq;

namespace LINQFinalFrontier
{
    public class Spaceship
    {

        public int NumLasers { get; set; }
        public int Size { get; set; }
        public bool HasWarpDrive { get; set; }
        public String Name { get; set; }
        static int nameCounter = 0;
        private static String[] names = {"Enterprise", "Voyager", "Wuddship", "Ariel", "Pegasus",
                "Defiant", "Valiant", "Victory", "Trafalgar", "Shadow"};

        public Spaceship(int numLasers, int size, bool hasWarpDrive, String name)
        {
            this.NumLasers = numLasers;
            this.Size = size;
            this.HasWarpDrive = hasWarpDrive;
            this.Name = name;
        }

        public Spaceship()
        {
            var r = new Random();

            this.NumLasers = r.Next(0, 20);
            this.Size = r.Next(0, 15);
            this.HasWarpDrive = r.Next(0, 100) % 2 == 0; ;

            this.Name = names[nameCounter];
            nameCounter++;
        }

        public void fightSpaceMonster()
        {
            Random random = new Random();
            int spaceMonsterHealth = random.Next(0, 12);
            if (this.NumLasers >= spaceMonsterHealth)
            {
                Console.WriteLine(Name + " wins the fight.");
            }
            else
            {
                Console.WriteLine(Name + " lost the fight.");
            }
        }

        public String toString()
        {
            return $"Name: {Name} \nLasers: {NumLasers} \nSize: {Size} \nWarpDrive: {HasWarpDrive}";
        }

    }
}
