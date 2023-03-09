using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesignPatternsPlayground.CommandPattern.Commands;

namespace DesignPatternsPlayground.CommandPattern
{
    public class InputHandler
    {
        private Command _lastCommand;

        private Command _jumpCommand;
        private Command _fireCommand;
        private MoveUnitCommand _moveCommand;
        private Unit _currentUnit;

        public InputHandler()
        {
            _jumpCommand = new JumpCommand();
            _fireCommand = new FireCommand();
        }

        public Command Handle(string buttonName)
        {
            if (buttonName == "space")
            {
                _lastCommand = _jumpCommand;
                return _lastCommand;
            }
            else if (buttonName == "mouse1")
            {
                _lastCommand = _fireCommand;
                return _lastCommand;
            }
            else if (buttonName == "button_up")
            {
                _currentUnit = GetSelectedUnit();
                var current = _currentUnit.Position;

                var next = current;
                next.y++;

                _moveCommand = new MoveUnitCommand(_currentUnit, current, next);

                _lastCommand = _moveCommand;
                return _lastCommand;
            }
            else if (buttonName == "button_down")
            {
                _currentUnit = GetSelectedUnit();
                var current = _currentUnit.Position;

                var next = current;
                next.y--;

                _moveCommand = new MoveUnitCommand(_currentUnit, current, next);

                _lastCommand = _moveCommand;
                return _lastCommand;
            }
            else if (buttonName == "undo")
            {
                _lastCommand?.Undo();
            }
            else if (buttonName == "redo")
            {
                _lastCommand?.Redo();
            }

            return null;
        }

        private Unit GetSelectedUnit()
        {
            return new Unit();
        }
    }
}
