using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace CsharpSocialNetworkManager.Utilities.Log
{
    public class LogJson : ILog<LogObject>,ILog<string>
    {
        public void SaveLog(LogObject action)
        {
            string logPath = Directory.GetCurrentDirectory() + @"\Log.json";
            var currentContent = string.Empty;
            List<LogObject> logObjects = new List<LogObject>();
            if (File.Exists(logPath))
            {
                var streamReader = new StreamReader(logPath);
                currentContent = streamReader.ReadToEnd();
                logObjects = JsonConvert.DeserializeObject<List<LogObject>>(currentContent);
                streamReader.Close();
            }

            StreamWriter streamWriter = new StreamWriter(logPath);
           

            ////LogObject logObject = new LogObject() { LogDate = DateTime.Now, Action = action };
            logObjects.Add(action);

            var jsonResult = JsonConvert.SerializeObject(logObjects);
            streamWriter.WriteLine(jsonResult);
            streamWriter.Close();
        }

        public void SaveLog(string action)
        {
            string logPath = Directory.GetCurrentDirectory() + @"\Log.json";
            var currentContent = string.Empty;
            List<LogObject> logObjects = new List<LogObject>();
            if (File.Exists(logPath))
            {
                var streamReader = new StreamReader(logPath);
                currentContent = streamReader.ReadToEnd();
                logObjects = JsonConvert.DeserializeObject<List<LogObject>>(currentContent);
                streamReader.Close();
            }

            StreamWriter streamWriter = new StreamWriter(logPath);


            LogObject logObject = new LogObject() { LogDate = DateTime.Now, Action = action };
            logObjects.Add(logObject);

            var jsonResult = JsonConvert.SerializeObject(logObjects);
            streamWriter.WriteLine(jsonResult);
            streamWriter.Close();
        }
    }
}
