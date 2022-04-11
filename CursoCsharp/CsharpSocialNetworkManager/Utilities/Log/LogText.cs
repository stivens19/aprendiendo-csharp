using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace CsharpSocialNetworkManager.Utilities.Log
{
    public class LogText:ILog<string>,ILogText
    {
        public void SaveLog(string action)
        {
            string logPath = Directory.GetCurrentDirectory() + @"\Log.txt";
            var currentContent = string.Empty;
            if (File.Exists(logPath))
            {
                var streamReader = new StreamReader(logPath);
                currentContent = streamReader.ReadToEnd();
                streamReader.Close();
            }
           
            StreamWriter streamWriter = new StreamWriter(logPath);
            streamWriter.WriteLine($"{DateTime.Now} - {action}");
            streamWriter.WriteLine(currentContent);
            streamWriter.Close();
        }
        public string GetLogText()
        {
            string logPath = Directory.GetCurrentDirectory() + @"\Log.txt";
            var currentContent = string.Empty;
            if (File.Exists(logPath))
            {
                var streamReader = new StreamReader(logPath);
                currentContent = streamReader.ReadToEnd();
                streamReader.Close();
            }
            return currentContent;
        }
    }
}
