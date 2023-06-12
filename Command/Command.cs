using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command
{
    public interface ICommand
    {
        void execute();
    }
    public class OpenFileCommand : ICommand
    {
        private readonly IFileSystemReceiver _fileSystem;
        public OpenFileCommand(IFileSystemReceiver fileSystem)
        {
            _fileSystem = fileSystem;
        }
        public void execute()
        {
            _fileSystem.openFile();
        }
    }
    public class CloseFileCommand : ICommand
    {
        private readonly IFileSystemReceiver _fileSystem;
        public CloseFileCommand(IFileSystemReceiver fileSystem)
        {
            _fileSystem = fileSystem;
        }
        public void execute()
        {
            _fileSystem.closeFile();
        }
    }
    public class WriteFileCommand : ICommand
    {
        private readonly IFileSystemReceiver _fileSystem;
        public WriteFileCommand(IFileSystemReceiver fileSystem)
        {
            _fileSystem = fileSystem;
        }
        public void execute()
        {
            _fileSystem.writeFile();
        }
    }
}
