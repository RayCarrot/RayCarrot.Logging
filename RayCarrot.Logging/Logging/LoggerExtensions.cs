﻿using Microsoft.Extensions.Logging;
using System;
using System.IO;
using System.Runtime.CompilerServices;

namespace RayCarrot.Logging
{
    /// <summary>
    /// Extensions for <see cref="ILogger"/> loggers
    /// </summary>
    public static class LoggerExtensions
    {
        /// <summary>
        /// Logs a message, including the source of the log
        /// </summary>
        /// <param name="logger">The logger</param>
        /// <param name="message">The message</param>
        /// <param name="logLevel">The level of the log</param>
        /// <param name="eventId">The event ID for the log</param>
        /// <param name="exception">The <see cref="Exception"/>, if any, for the log</param>
        /// <param name="origin">The callers member/function name</param>
        /// <param name="filePath">The source code file path</param>
        /// <param name="lineNumber">The line number in the code file of the caller</param>
        public static void LogSource(this ILogger logger, string message, LogLevel logLevel, EventId eventId = new EventId(), Exception exception = null,
            [CallerMemberName] string origin = "", [CallerFilePath] string filePath = "", [CallerLineNumber] int lineNumber = 0)
            => logger.Log(logLevel, eventId,
                new object[]
                {
                    origin,
                    filePath,
                    lineNumber,
                    message
                }, exception, Format);

        /// <summary>
        /// Logs a critical message, including the source of the log
        /// </summary>
        /// <param name="logger">The logger</param>
        /// <param name="message">The message</param>
        /// <param name="eventId">The event ID for the log</param>
        /// <param name="exception">The <see cref="Exception"/>, if any, for the log</param>
        /// <param name="origin">The callers member/function name</param>
        /// <param name="filePath">The source code file path</param>
        /// <param name="lineNumber">The line number in the code file of the caller</param>
        public static void LogCriticalSource(this ILogger logger, string message, EventId eventId = new EventId(), Exception exception = null,
            [CallerMemberName] string origin = "", [CallerFilePath] string filePath = "", [CallerLineNumber] int lineNumber = 0)
            => logger.Log(LogLevel.Critical, eventId,
                new object[]
                {
                    origin,
                    filePath,
                    lineNumber,
                    message
                }, exception, Format);

        /// <summary>
        /// Logs a verbose trace message, including the source of the log
        /// </summary>
        /// <param name="logger">The logger</param>
        /// <param name="message">The message</param>
        /// <param name="eventId">The event ID for the log</param>
        /// <param name="exception">The <see cref="Exception"/>, if any, for the log</param>
        /// <param name="origin">The callers member/function name</param>
        /// <param name="filePath">The source code file path</param>
        /// <param name="lineNumber">The line number in the code file of the caller</param>
        public static void LogTraceSource(this ILogger logger, string message, EventId eventId = new EventId(), Exception exception = null,
            [CallerMemberName] string origin = "", [CallerFilePath] string filePath = "", [CallerLineNumber] int lineNumber = 0)
            => logger.Log(LogLevel.Trace, eventId,
                new object[]
                {
                    origin,
                    filePath,
                    lineNumber,
                    message
                }, exception, Format);

        /// <summary>
        /// Logs a debug message, including the source of the log
        /// </summary>
        /// <param name="logger">The logger</param>
        /// <param name="message">The message</param>
        /// <param name="eventId">The event ID for the log</param>
        /// <param name="exception">The <see cref="Exception"/>, if any, for the log</param>
        /// <param name="origin">The callers member/function name</param>
        /// <param name="filePath">The source code file path</param>
        /// <param name="lineNumber">The line number in the code file of the caller</param>
        public static void LogDebugSource(this ILogger logger, string message, EventId eventId = new EventId(), Exception exception = null,
            [CallerMemberName] string origin = "", [CallerFilePath] string filePath = "", [CallerLineNumber] int lineNumber = 0)
            => logger.Log(LogLevel.Debug, eventId,
                new object[]
                {
                    origin,
                    filePath,
                    lineNumber,
                    message
                }, exception, Format);

        /// <summary>
        /// Logs an error message, including the source of the log
        /// </summary>
        /// <param name="logger">The logger</param>
        /// <param name="message">The message</param>
        /// <param name="eventId">The event ID for the log</param>
        /// <param name="exception">The <see cref="Exception"/>, if any, for the log</param>
        /// <param name="origin">The callers member/function name</param>
        /// <param name="filePath">The source code file path</param>
        /// <param name="lineNumber">The line number in the code file of the caller</param>
        public static void LogErrorSource(this ILogger logger, string message, EventId eventId = new EventId(), Exception exception = null,
            [CallerMemberName] string origin = "", [CallerFilePath] string filePath = "", [CallerLineNumber] int lineNumber = 0)
            => logger.Log(LogLevel.Error, eventId,
                new object[]
                {
                    origin,
                    filePath,
                    lineNumber,
                    message
                }, exception, Format);

        /// <summary>
        /// Logs an informative message, including the source of the log
        /// </summary>
        /// <param name="logger">The logger</param>
        /// <param name="message">The message</param>
        /// <param name="eventId">The event ID for the log</param>
        /// <param name="exception">The <see cref="Exception"/>, if any, for the log</param>
        /// <param name="origin">The callers member/function name</param>
        /// <param name="filePath">The source code file path</param>
        /// <param name="lineNumber">The line number in the code file of the caller</param>
        public static void LogInformationSource(this ILogger logger, string message, EventId eventId = new EventId(), Exception exception = null,
            [CallerMemberName] string origin = "", [CallerFilePath] string filePath = "", [CallerLineNumber] int lineNumber = 0)
            => logger.Log(LogLevel.Information, eventId,
                new object[]
                {
                    origin,
                    filePath,
                    lineNumber,
                    message
                }, exception, Format);

        /// <summary>
        /// Logs a warning message, including the source of the log
        /// </summary>
        /// <param name="logger">The logger</param>
        /// <param name="message">The message</param>
        /// <param name="eventId">The event ID for the log</param>
        /// <param name="exception">The <see cref="Exception"/>, if any, for the log</param>
        /// <param name="origin">The callers member/function name</param>
        /// <param name="filePath">The source code file path</param>
        /// <param name="lineNumber">The line number in the code file of the caller</param>
        public static void LogWarningSource(this ILogger logger, string message, EventId eventId = new EventId(), Exception exception = null,
            [CallerMemberName] string origin = "", [CallerFilePath] string filePath = "", [CallerLineNumber] int lineNumber = 0)
            => logger.Log(LogLevel.Warning, eventId, new object[]
            {
                origin,
                filePath,
                lineNumber,
                message
            }, exception, Format);

        /// <summary>
        /// Formats the message including the source information pulled out of the state
        /// </summary>
        /// <param name="state">The state information about the log</param>
        /// <param name="exception">The exception</param>
        /// <returns></returns>
        internal static string Format(object[] state, Exception exception)
        {
            // Get the values from the state
            var origin = (string)state[0];
            var filePath = (string)state[1];
            var lineNumber = (int)state[2];
            var message = (string)state[3];

            // Get any exception message
            var exceptionMessage = exception?.ToString();

            // Check if there is an exception
            if (exception != null)
                // Add a new line between message and exception
                exceptionMessage = Environment.NewLine + exception;

            // Format the message string
            return $"{message} [{Path.GetFileName(filePath)} > {origin}() > Line {lineNumber}]{exceptionMessage}";
        }
    }
}