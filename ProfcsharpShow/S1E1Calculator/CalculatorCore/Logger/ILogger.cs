using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorCore.Log
{
    public interface ILog
    {
        void Log(string ingo);
    }

    public class FileLog : ILog
    {
        public void Log(string info)
        {
            File.AppendAllText("log.db", $"{info}{Environment.NewLine}");
        }
    }

    public class DebugLog : ILog
    {
        public void Log(string info)
        {
            Debug.WriteLine($"{info}{Environment.NewLine}");
        }
    }
}