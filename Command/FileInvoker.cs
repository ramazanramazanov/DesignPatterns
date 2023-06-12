using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command
{
    public class FileInvoker
    {
        private readonly ICommand _command;
        public FileInvoker(ICommand command)
        {
            _command = command;
        }
        public void Execute()
        {
            _command.execute();
        }
    }
}
