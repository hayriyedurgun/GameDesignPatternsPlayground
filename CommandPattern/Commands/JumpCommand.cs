using DesignPatternsPlayground.CommandPattern.Characters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsPlayground.CommandPattern.Commands
{
    public class JumpCommand : Command
    {
        public override void Execute(Character character) => character.Jump();
    }
}
