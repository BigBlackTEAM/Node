using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicLib
{
    public static class Loging
    {

        
        
        public static string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Logs");
        
        public static string FileName = Path.Combine(path, "log.txt");

        
        public static void CreateFile(string fileName)
        {

            

            if (!File.Exists(fileName))
            {
                File.Create(fileName).Close();
            }
            FileName = fileName;
        }


        private static void WriteToLog(string info, LogType type) =>
            File.AppendAllText(FileName, string.Format("{0}-{1},\n{2}\n", type.ToString(), DateTime.Now.ToString(), info));

        private static void WriteToLogSep() => File.AppendAllText(FileName, "\n");

        public static void SetLog(string info, LogType type = LogType.ERROR)
        {
            WriteToLog(info, type);
            WriteToLogSep();
        }

        public static void SetLog(string info, LogType type, params object[] _params)
        {
            if (_params != null)
            {
                WriteToLog(info, type);
                _params.ToList().ForEach(x => File.AppendAllText(FileName, string.Format("{0}\n", x.ToString())));
                WriteToLogSep();
            }
        }


    }
}
