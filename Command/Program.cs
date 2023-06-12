using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command
{
    internal class Program
    {
        static void Main(string[] args)
        {
			//Creating the receiver object
			IFileSystemReceiver fs = FileSystemReceiverUtil.getUnderlyingFileSystem();

			//creating command and associating with receiver
			OpenFileCommand openFileCommand = new OpenFileCommand(fs);

			//Creating invoker and associating with Command
			FileInvoker file = new FileInvoker(openFileCommand);

			//perform action on invoker object
			file.Execute();

			WriteFileCommand writeFileCommand = new WriteFileCommand(fs);
			file = new FileInvoker(writeFileCommand);
			file.Execute();

			CloseFileCommand closeFileCommand = new CloseFileCommand(fs);
			file = new FileInvoker(closeFileCommand);
			file.Execute();

			Console.ReadKey();
        }
    }
}
