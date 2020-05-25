using System;
using System.Runtime.CompilerServices;
using Microsoft.Extensions.Logging;

namespace RayCarrot.Logging
{
    /// <summary>
    /// A default exception handler which logs the exception details
    /// </summary>
    public class DefaultExceptionHandler : IExceptionHandler
    {
        /// <summary>
        /// Handles an exception
        /// </summary>
        /// <param name="exception">The exception to handle</param>
        /// <param name="debugMessage">An optional debug message</param>
        /// <param name="exceptionLevel">The level of the exception</param>
        /// <param name="debugObject">An optional debug object</param>
        /// <param name="origin">The caller member name (leave at default for compiler-time value)</param>
        /// <param name="filePath">The caller file path (leave at default for compiler-time value)</param>
        /// <param name="lineNumber">The caller line number (leave at default for compiler-time value)</param>
        public virtual void HandleException(Exception exception, string debugMessage, ExceptionLevel exceptionLevel, object debugObject = null, [CallerMemberName] string origin = "", [CallerFilePath] string filePath = "", [CallerLineNumber] int lineNumber = 0)
        {
            string logMessage = $"An exception has occurred with the debug message of \"{debugMessage}\" and the level of {exceptionLevel}.";

            LogLevel logLevel = LogLevel.None;

            switch (exceptionLevel)
            {
                case ExceptionLevel.Expected:
                    logLevel = LogLevel.Debug;
                    break;

                case ExceptionLevel.Unexpected:
                    logLevel = LogLevel.Warning;
                    break;

                case ExceptionLevel.Error:
                    logLevel = LogLevel.Error;
                    break;

                case ExceptionLevel.Critical:
                    logLevel = LogLevel.Critical;
                    break;
            }

            if (logLevel != LogLevel.None)
                RL.Logger?.LogSource(logMessage, logLevel, exception: exception, origin: origin, filePath: filePath, lineNumber: lineNumber);
        }
    }
}