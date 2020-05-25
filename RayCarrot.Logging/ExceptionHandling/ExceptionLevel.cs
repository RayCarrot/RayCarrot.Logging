namespace RayCarrot.Logging
{
    /// <summary>
    /// The level, indicating the severity of the exception
    /// </summary>
    public enum ExceptionLevel
    {
        /// <summary>
        /// An expected exception which is handled by the method it appeared in
        /// </summary>
        Expected,

        /// <summary>
        /// An unexpected, but not severe, exception which is handled by the method it appeared in
        /// </summary>
        Unexpected,

        /// <summary>
        /// An exception indicating an error, crashing the current method
        /// </summary>
        Error,

        /// <summary>
        /// A critical exception, crashing the application
        /// </summary>
        Critical,

        /// <summary>
        /// Used for indicating none of the above levels
        /// </summary>
        None
    }
}