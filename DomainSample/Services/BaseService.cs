using DomainSample.Enums;
using DomainSample.Resources;
using Newtonsoft.Json;
using System;
using System.Configuration;
using System.IO;
using System.Text;

namespace DomainSample.Services
{
    public class BaseService
    {
        protected readonly DatabaseSampleContext _context;
        public BaseService()
        {
            _context = new DatabaseSampleContext();
        }

        public string InvokingMethodName(int offset = 1)
        {
            return (new System.Diagnostics.StackTrace()).GetFrame(offset).GetMethod().Name;
        }

        public void EntryLog(LogArea logArea, object logData = null)
        {
            var entryTextFormat = logData == null ? TextResources.CodeEnteredX : TextResources.RequestReceivedInX;

            Log(logArea, LogType.Info, string.Format(entryTextFormat, InvokingMethodName(2)), logData);
        }

        public void ErrorLog(LogArea logArea, Exception ex)
        {
            Log(logArea, ex is ArgumentException ? LogType.Warning : LogType.Error, string.Format(TextResources.ErrorOccurredInXY, InvokingMethodName(2), ex.Message), ex);
        }

        public void Log(LogArea logArea, LogType logType, string message, object logData = null)
        {
            try
            {
                var logDirectory = ConfigurationManager.AppSettings["LoggingDirectory"];

                if (string.IsNullOrWhiteSpace(logDirectory)) return;

                if (!Directory.Exists(logDirectory))
                {
                    Directory.CreateDirectory(logDirectory);
                }

                var now = DateTime.Now;

                var fileName = string.Format("{0}_Log_{1}.txt", now.ToString("yyyyMMdd"), logArea);

                var fullPath = Path.Combine(logDirectory, fileName);

                var sb = new StringBuilder();

                sb.AppendLine(string.Format("{0} [{1}] {2}", now.ToString("yyyy/MM/dd HH:mm:ss"), logType.ToString(), message));

                if (logData != null)
                {
                    var json = JsonConvert.SerializeObject(logData, Formatting.Indented);

                    sb.AppendLine("Data: ");
                    sb.AppendLine("-------------");
                    sb.AppendLine(json);
                    sb.AppendLine("-------------");
                    sb.AppendLine();
                }

                File.AppendAllText(fullPath, sb.ToString());
            }
            catch { }
        }
    }
}
