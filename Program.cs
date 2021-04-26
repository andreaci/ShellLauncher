using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ShellLauncher
{
    class Program
    {
        static void Main(string[] args)
        {

            do
            {
                string path = @"exe_path\";
                string exe = "***.exe";

                if (args != null && args.Length == 1)
                {
                    FileInfo temp = new FileInfo(args[0]);
                    path = temp.DirectoryName;
                    exe = temp.Name;
                }

                ProcessStartInfo info = new ProcessStartInfo(Path.Combine(path, exe))
                {
                    WorkingDirectory = path
                };

                Process process = Process.Start(info);
                process.WaitForExit();

                Thread.Sleep(5000);
            } while (true);
        }
    }
}
