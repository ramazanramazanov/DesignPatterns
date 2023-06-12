using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Command
{
    public class FileSystemReceiverUtil
    {
        public static IFileSystemReceiver getUnderlyingFileSystem()
        {
            Console.WriteLine("Underlying OS is:" + RuntimeInformation.OSDescription);
            IFileSystemReceiver receiver = null;

            if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
            {
                receiver = new WindowsFileSystemReceiver();
            }
            if(RuntimeInformation.IsOSPlatform(OSPlatform.Linux))
            {
                receiver = new LinixFileSystemReceiver();
            }
            return receiver;
        }
    }
}
