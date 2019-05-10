using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using System.IO;

namespace MyGame
{
    /// <summary>
    /// Вывод логов игры
    /// </summary>
    class IoLogs
    {
        /// <summary>
        /// LogConsoleWrite
        /// </summary>
        /// <param name="log"></param>
        public void LogConsoleWrite(string log)
        {
            WriteLine(log);
        }

        /// <summary>
        /// LogFileWrite
        /// </summary>
        /// <param name="log"></param>
        public void LogFileWrite(string log)
        {
            //System.IO.File.WriteAllText(@"..\..\log.txt", log);
            StreamWriter writer = new StreamWriter(@"..\..\log.txt",true);
            writer.WriteLine(log);
            writer.Close();
        }
    }
}
