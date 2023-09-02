using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace otusSOLID.Interfaces
{
    interface ICommandExecutor
    {
        public void Add(IGameCommand command);
        public void Execute();
    }
}
