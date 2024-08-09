using System;
using System.Linq;
using System.Xml;

static class LogLine
{
    public static string Message(string logLine)
    {
        if(logLine.Contains("[ERROR]:"))
        {
            string removeLevel = logLine.Replace("[ERROR]:", "");
            string removeSpaces  = removeLevel.Trim();         
            return removeSpaces;
        }
        else if (logLine.Contains("[WARNING]:"))
        {
            string removeLevel = logLine.Replace("[WARNING]:", "");
            string removeSpaces  = removeLevel.Trim();             
            return removeSpaces;    
        }
        else if (logLine.Contains("[INFO]:"))
        {
            string removeLevel = logLine.Replace("[INFO]:", "");
            string removeSpaces  = removeLevel.Trim();
            return removeSpaces;         
            }
        else
        {
            throw new ArgumentException("ERRO");
        }

    }

    public static string LogLevel(string logLine)
    {
        if (logLine.Contains("[ERROR]:"))
        {
            
            return "error";
        }
        else if (logLine.Contains("[WARNING]:"))
        {
            return "warning";
        }
        else if (logLine.Contains("[INFO]:"))
        {
            return "info";
        }
        else
        {
            throw new ArgumentException("invalid");
        }
    }

    public static string Reformat(string logLine)
    {
        string logLevel = LogLevel(logLine);
        string message = logLine.Substring(logLine.IndexOf(':') + 1).Trim();
        
        return string.Format("{0} ({1})", message, logLevel);
    }
}
