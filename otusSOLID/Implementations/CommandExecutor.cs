using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using otusSOLID.Interfaces;

namespace otusSOLID.Implementations
{
    public class CommandExecutor : ICommandExecutor
    {
        private List<IGameCommand> Commands;
        public CommandExecutor()
        {
            Commands = new List<IGameCommand>();
        }

        public void Execute()
        {
            foreach (var item in Commands)
            {
                item.Execute();
            }

            Commands.Clear();
        }

        public void Add(IGameCommand command)
        {
            Commands.Add(command);
        }
    }
}
