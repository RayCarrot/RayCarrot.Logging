using Microsoft.Extensions.Logging;
using System;

namespace RayCarrot.Logging
{
    /// <summary>
    /// Provides access to basic logging and exception handling
    /// </summary>
    public static class RL
    {
        /// <summary>
        /// Sets up the logging by providing a logger
        /// </summary>
        /// <param name="loggerFunc">The function which provides the logger to use for logging</param>
        public static void Setup(Func<ILogger> loggerFunc)
        {
            if (LoggerFunc != null)
                Logger?.LogInformationSource($"The current logger is being replaced by a new one");

            // Set the logger
            LoggerFunc = loggerFunc;

            Logger?.LogInformationSource($"Logger has been setup");
        }

        /// <summary>
        /// Sets up the exception handling by providing a handler
        /// </summary>
        /// <param name="exceptionHandlerFunc">The function which provides the exception handler</param>
        public static void Setup(Func<IExceptionHandler> exceptionHandlerFunc)
        {
            if (ExceptionHandlerFunc != null)
                Logger?.LogInformationSource($"The current exception handler is being replaced by a new one");

            // Set the logger
            ExceptionHandlerFunc = exceptionHandlerFunc;

            Logger?.LogInformationSource($"Exception handler has been setup");
        }

        private static Func<ILogger> LoggerFunc { get; set; }

        private static Func<IExceptionHandler> ExceptionHandlerFunc { get; set; }

        /// <summary>
        /// The logger for logging, can be null
        /// </summary>
        public static ILogger Logger => LoggerFunc?.Invoke();

        /// <summary>
        /// The exception handling for handling exceptions, will return default implementation if null
        /// </summary>
        public static IExceptionHandler ExceptionHandler => ExceptionHandlerFunc?.Invoke() ?? new DefaultExceptionHandler();
    }
}