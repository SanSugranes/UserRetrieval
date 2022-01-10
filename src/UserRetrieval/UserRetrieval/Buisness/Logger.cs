﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserRetrieval.Buisness
{
    static class Logger
    {
        internal enum LogLevel
        {
            INFO,
            WARNING,
            ERROR,
            DEBUG
        }

        private static string appLogPath = "";
        private static string userLogPath = "";
        internal static string AppLogPath { set { appLogPath = value; } }
        internal static string UserLogPath { set { userLogPath = value; } }

        internal static void Log(LogLevel logLevel, string message)
        {
            DateTime now = DateTime.Now;
            StreamWriter writer = new StreamWriter(appLogPath, true);

            string logMessage = $"[{now}]: {message}";
            switch (logLevel)
            {
                case LogLevel.INFO:
                    logMessage = "[INFO]" + logMessage;
                    break;
                case LogLevel.WARNING:
                    logMessage = "[WARNING]" + logMessage;
                    break;
                case LogLevel.ERROR:
                    logMessage = "[ERROR]" + logMessage;
                    break;
                case LogLevel.DEBUG:
                    logMessage = "[DEBUG]" + logMessage;
                    break;
                default:
                    break;
            }

            try
            {
                writer.WriteLine(logMessage);
                writer.Close();
            }
            catch (IOException exeption)
            {
                Console.WriteLine("[ERROR] Issue occured when loging in the appLog. Expeption message :\n" + exeption);
            }
        }

        internal static void AppendToUsers(string message)
        {
            FileStream userLog = new FileStream(userLogPath, FileMode.OpenOrCreate, FileAccess.ReadWrite);
            StreamReader reader = new StreamReader(userLog);

            try
            {
                string line = "";
                bool append = true;

                do
                {
                    line = reader.ReadLine();
                    if(line != null)
                    {
                        if (line == message)
                        {
                            append = false;
                        }
                    }
                } while (line != null);

                reader.Close();

                StreamWriter writer = new StreamWriter(userLogPath, true);

                if (append == true)
                {
                    writer.WriteLine(message);
                }
                else
                {
                    Logger.Log(LogLevel.INFO, $"User {message} already in file.");
                }

                writer.Close();
            }
            catch (IOException exeption)
            {
                Console.WriteLine("[ERROR] Issue occured when loging in the users file. Expeption message :\n" + exeption);
                Logger.Log(LogLevel.ERROR, "Issue occured when loging in the users file.Expeption message:\n" + exeption);
            }
        }
    }
}
