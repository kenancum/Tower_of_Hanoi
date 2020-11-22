using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Tower_of_Hanoi.Data
{
    public class HanoiDisk
    {
        public int size;
        public string color;

        public HanoiDisk(int size, string color)
        {
            this.size = size;
            this.color = color;
        }
    }
}
