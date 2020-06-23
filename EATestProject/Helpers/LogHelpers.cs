using System;
using System.IO;

namespace EAAutoFramework.Helpers
{
    public class LogHelpers
    {
        private static string _logFileName = string.Format("{0:yyyymmddhhmmss}",DateTime.Now);
        private static StreamWriter _streamw = null;

        //Create a file which stores the log information
        public static void CreateLogFile()
        {
            string dir = @"C:\Users\Anuj.Srivastava3\Documents\";
            if(Directory.Exists(dir))
            {
                _streamw = File.AppendText(dir + _logFileName + ".log");
            }
            else
            {
                Directory.CreateDirectory(dir);
                _streamw = File.AppendText(dir + _logFileName + ".log");
            }
        }

        //Create a method which can write the text in Log File
        public static void Write(string logMessage)
        {
            _streamw.Write("{0} {1}", DateTime.Now.ToLongTimeString(), DateTime.Now.ToLongDateString());
            _streamw.WriteLine("    {0}", logMessage);
            _streamw.Flush();
        }   
    }
}
