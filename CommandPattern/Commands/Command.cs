using DesignPatternsPlayground.CommandPattern.Characters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsPlayground.CommandPattern.Commands
{
    public abstract class Command
    {
        public abstract void Execute(BaseCharacter character);

        public virtual void Undo()
        {

        }

        public virtual void Redo()
        {

        }
    }
}
