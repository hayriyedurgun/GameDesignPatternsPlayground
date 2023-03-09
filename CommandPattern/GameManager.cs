using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesignPatternsPlayground.CommandPattern.Characters;

namespace DesignPatternsPlayground.CommandPattern
{
    public class GameManager
    {
        private InputHandler _inputHandler;

        private BaseCharacter _ai;
        private BaseCharacter _character;

        public GameManager()
        {
            _ai = new AICharacter();
            _character = new Character();

            _inputHandler = new InputHandler();
        }

        //consumer of command stream
        public void Update(string inputName)
        {
            //producer of command
            var command = _inputHandler.Handle(inputName);
            if (command != null)
            {
                command.Execute(_ai);
                command.Execute(_character);
            }
        }
    }
}
