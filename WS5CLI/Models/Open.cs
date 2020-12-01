using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Text;

namespace WS5CLI.Models
{
    class Open
    {
        public Open()
        {

        }

        public Process CreateProcess(string exePath, string filePath = null)
        {

            Process process = new Process();
            if (filePath != null)
            {
                process.StartInfo = new ProcessStartInfo()
                {

                    WindowStyle = ProcessWindowStyle.Minimized,
                    FileName = @"" + exePath,
                    Arguments = @"" + filePath

                };
            }
            else
            {
                process.StartInfo = new ProcessStartInfo()
                {

                    WindowStyle = ProcessWindowStyle.Minimized,
                    FileName = @"" + exePath

                };
            }

            process.Start();

            return process;
        }
          
    }
}
