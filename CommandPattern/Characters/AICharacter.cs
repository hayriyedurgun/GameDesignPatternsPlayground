using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsPlayground.CommandPattern.Characters
{
    public class AICharacter : BaseCharacter
    {
        public override void Fire()
        {
            Console.WriteLine("Fire from AI");
        }

        public override void Jump()
        {
            Console.WriteLine("Fire from AI");
        }
    }
}
