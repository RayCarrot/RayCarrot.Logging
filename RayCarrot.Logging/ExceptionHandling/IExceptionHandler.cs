using System;
using System.Runtime.CompilerServices;

namespace RayCarrot.Logging
{
    /// <summary>
    /// Used for exception handlers
    /// </summary>
    public interface IExceptionHandler
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
        void HandleException(Exception exception, string debugMessage, ExceptionLevel exceptionLevel, object debugObject = null, [CallerMemberName] string origin = "", [CallerFilePath] string filePath = "", [CallerLineNumber] int lineNumber = 0);
    }
}