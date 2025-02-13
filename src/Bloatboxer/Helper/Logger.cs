using System;
using System.Collections.Generic;
using System.Drawing;

namespace Bloatboxer
{
    public class Logger
    {
        private static LoggerForm loggerFormInstance;
        private static readonly List<(string Message, Color Color)> logBuffer = new List<(string, Color)>();

        // Set the LoggerView instance dynamically
        public static void SetLoggerForm(LoggerForm loggerForm)
        {
            if (loggerForm == null)
            {
                throw new ArgumentNullException(nameof(loggerForm), "LoggerForm cannot be null.");
            }

            loggerFormInstance = loggerForm;

            // If there were logs buffered before the view was set, flush them now
            foreach (var log in logBuffer)
            {
                loggerFormInstance.AddLog(log.Message, log.Color);
            }

            // Clear the buffer after flushing
            logBuffer.Clear();
        }

        // Log a message with color and timestamp
        public void Log(string message, Color color)
        {
            string timestampedMessage = $"{DateTime.Now:HH:mm:ss} - {message}";

            // Log to the LoggerForm if it's open
            if (loggerFormInstance != null)
            {
                loggerFormInstance.AddLog(timestampedMessage, color);
            }
            else
            {
                // If LoggerView isn't open, buffer the log for future display
                logBuffer.Add((timestampedMessage, color));
            }
        }
    }
}