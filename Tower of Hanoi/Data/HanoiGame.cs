using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Tower_of_Hanoi.Data
{
    public class HanoiGame
    {
        public int svgHeight = 210;
        public int svgWidth = 200;
        List<HanoiTower> hanoiTowers = new List<HanoiTower>();
        

        public HanoiGame()
        {

        }

        public HanoiTower addTower(HanoiTower tower)
        {
            hanoiTowers.Add(tower);
            return tower;
        }
        public HanoiTower getTower(int towerId)
        {
            return hanoiTowers[towerId];
        }

        public void toConsole()
        {
            for (int i = 0; i < this.hanoiTowers.Count; i++)
            {
                Console.WriteLine("Tower "+i+ " - "+ getTower(i).hanoiDisks.Count + " disks");
                for (int j = 0; j < getTower(i).hanoiDisks.Count; j++)
                {
                    Console.WriteLine("Disk " + j + " " + getTower(i).hanoiDisks[j].size + " " + getTower(i).hanoiDisks[j].color);
                }
            }
        }

        public int totalOfTowers()
        {            
            return hanoiTowers.Count;
        }
        
    }
}
