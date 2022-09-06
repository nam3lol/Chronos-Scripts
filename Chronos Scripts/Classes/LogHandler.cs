using System;
using System.IO;
using System.Windows;
using System.Windows.Forms;

namespace Chronos_Scripts.Classes
{
    public static class LogHandler
    {
        public static void LoggerCode(string exp)
        {
            if (!Directory.Exists("./logs"))
            {
                Directory.CreateDirectory("./logs");
            }

            var logName = Directory.GetFiles("./logs/").Length + 1;
            string LogMsg = $"Source: {exp}";

            File.WriteAllText($"./logs/Chronos X Log {Directory.GetFiles("./logs/").Length + 1}.txt", LogMsg);

            MessageBox.Show("Unfortunately, an error occured in Chronos X. A log file was created at " + Environment.CurrentDirectory.ToString() + $"/logs/Chronos X Log {logName}", "Chronos X - Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            Environment.Exit(0);
        }
    }
}
