﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicLib
{
    static class Loging
    {

        public static string FileName { get; private set; }
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

        private static void WriteToLogSep() => File.AppendAllText(FileName, string.Format("{0}\n"));

        public static void SetLog(string info, LogType type = LogType.ERROR)
        {
            WriteToLog(info, type);
            WriteToLogSep();
        }




    }
}
