using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command
{
    public interface IFileSystemReceiver
    {
        void openFile();
        void writeFile();
        void closeFile();
    }
    public class LinixFileSystemReceiver : IFileSystemReceiver
    {
        public void openFile()
        {
            Console.WriteLine("Opening file in Unix OS");
        }

        public void writeFile()
        {
            Console.WriteLine("Writing file in Unix OS");
        }

        public void closeFile()
        {
            Console.WriteLine("Closing file in Unix OS");
        }
    }
    public class WindowsFileSystemReceiver : IFileSystemReceiver
    {
        public void openFile()
        {
            Console.WriteLine("Opening file in Windows OS");
        }

        public void writeFile()
        {
            Console.WriteLine("Writing file in Windows OS");
        }

        public void closeFile()
        {
            Console.WriteLine("Closing file in Windows OS");
        }
    }
}
