using System;
using System.Runtime.CompilerServices;

namespace RayCarrot.Logging
{
    /// <summary>
    /// Extensions methods for <see cref="Exception"/>
    /// </summary>
    public static class ExceptionExtensions
    {
        /// <summary>
        /// Handle a critical <see cref="Exception"/>
        /// </summary>
        /// <param name="exception">The exception to handle</param>
        /// <param name="debugMessage">An optional debug message</param>
        /// <param name="debugObject">An optional debug object</param>
        /// <param name="origin">The caller member name (leave at default for compiler-time value)</param>
        /// <param name="filePath">The caller file path (leave at default for compiler-time value)</param>
        /// <param name="lineNumber">The caller line number (leave at default for compiler-time value)</param>
        public static void HandleCritical(this Exception exception, string debugMessage = null, object debugObject = null, [CallerMemberName] string origin = "", [CallerFilePath] string filePath = "", [CallerLineNumber] int lineNumber = 0)
        {
            RL.ExceptionHandler?.HandleException(exception, debugMessage, ExceptionLevel.Critical, debugObject, origin, filePath, lineNumber);
        }

        /// <summary>
        /// Handle an error <see cref="Exception"/>
        /// </summary>
        /// <param name="exception">The exception to handle</param>
        /// <param name="debugMessage">An optional debug message</param>
        /// <param name="debugObject">An optional debug object</param>
        /// <param name="origin">The caller member name (leave at default for compiler-time value)</param>
        /// <param name="filePath">The caller file path (leave at default for compiler-time value)</param>
        /// <param name="lineNumber">The caller line number (leave at default for compiler-time value)</param>
        public static void HandleError(this Exception exception, string debugMessage = null, object debugObject = null, [CallerMemberName] string origin = "", [CallerFilePath] string filePath = "", [CallerLineNumber] int lineNumber = 0)
        {
            RL.ExceptionHandler?.HandleException(exception, debugMessage, ExceptionLevel.Error, debugObject, origin, filePath, lineNumber);
        }

        /// <summary>
        /// Handle an unexpected <see cref="Exception"/>
        /// </summary>
        /// <param name="exception">The exception to handle</param>
        /// <param name="debugMessage">An optional debug message</param>
        /// <param name="debugObject">An optional debug object</param>
        /// <param name="origin">The caller member name (leave at default for compiler-time value)</param>
        /// <param name="filePath">The caller file path (leave at default for compiler-time value)</param>
        /// <param name="lineNumber">The caller line number (leave at default for compiler-time value)</param>
        public static void HandleUnexpected(this Exception exception, string debugMessage = null, object debugObject = null, [CallerMemberName] string origin = "", [CallerFilePath] string filePath = "", [CallerLineNumber] int lineNumber = 0)
        {
            RL.ExceptionHandler?.HandleException(exception, debugMessage, ExceptionLevel.Unexpected, debugObject, origin, filePath, lineNumber);
        }

        /// <summary>
        /// Handle an expected <see cref="Exception"/>
        /// </summary>
        /// <param name="exception">The exception to handle</param>
        /// <param name="debugMessage">An optional debug message</param>
        /// <param name="debugObject">An optional debug object</param>
        /// <param name="origin">The caller member name (leave at default for compiler-time value)</param>
        /// <param name="filePath">The caller file path (leave at default for compiler-time value)</param>
        /// <param name="lineNumber">The caller line number (leave at default for compiler-time value)</param>
        public static void HandleExpected(this Exception exception, string debugMessage = null, object debugObject = null, [CallerMemberName] string origin = "", [CallerFilePath] string filePath = "", [CallerLineNumber] int lineNumber = 0)
        {
            RL.ExceptionHandler?.HandleException(exception, debugMessage, ExceptionLevel.Expected, debugObject, origin, filePath, lineNumber);
        }
    }
}