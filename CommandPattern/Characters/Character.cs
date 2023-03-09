using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsPlayground.CommandPattern.Characters
{
    internal class Character : BaseCharacter
    {
        public override void Fire()
        {
            Console.WriteLine("Fire from Character");
        }

        public override void Jump()
        {
            Console.WriteLine("Jump from Character");
        }
    }
}
