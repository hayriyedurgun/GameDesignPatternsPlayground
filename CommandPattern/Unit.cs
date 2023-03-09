using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsPlayground.CommandPattern
{
    public class Unit
    {
        public Position Position;

        internal void MoveTo(int x, int y)
        {
            Console.WriteLine($"unit moving to {x}:{y}");
        }
    }
}
