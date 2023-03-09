using DesignPatternsPlayground.CommandPattern.Characters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsPlayground.CommandPattern.Commands
{
    public class MoveUnitCommand : Command
    {
        private Unit _unit;
        private Position _currentPos;
        private Position _nextPos;

        public MoveUnitCommand(Unit unit, Position currentPos, Position nextPos)
        {
            _unit = unit;
            _currentPos = currentPos;
            _nextPos = nextPos;

            _unit.MoveTo(_nextPos.x, _nextPos.y);
        }

        public override void Execute(BaseCharacter character)
        {
        }

        public override void Undo()
        {
            _unit.MoveTo(_currentPos.x, _currentPos.y);
        }

        public override void Redo()
        {
            _unit.MoveTo(_nextPos.x, _nextPos.y);
        }
    }
}
