// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Logger.cs" company="Shane Craven">
//   Copyright (c) Shane Craven. All rights reserved.
// </copyright>
// <summary>
//   The logger.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace OsirisWindows.Logging
{
    using OrionWindows.Logging;

    /// <summary>
    /// The logger (This logger does not perform logging. Developer can implement ILogger interface to integrate custom logging into library).
    /// </summary>
    public class Logger : ILogger
    {
        /// <summary>
        /// The log info.
        /// </summary>
        /// <param name="message">
        /// The message.
        /// </param>
        public void LogInfo(string message)
        {
            return;
        }

        /// <summary>
        /// The log error.
        /// </summary>
        /// <param name="message">
        /// The message.
        /// </param>
        public void LogError(string message)
        {
            return;
        }

        /// <summary>
        /// The log critical.
        /// </summary>
        /// <param name="message">
        /// The message.
        /// </param>
        public void LogCritical(string message)
        {
            return;
        }

        /// <summary>
        /// The log debug.
        /// </summary>
        /// <param name="message">
        /// The message.
        /// </param>
        public void LogDebug(string message)
        {
            return;
        }

        /// <summary>
        /// The log warning.
        /// </summary>
        /// <param name="message">
        /// The message.
        /// </param>
        public void LogWarning(string message)
        {
            return;
        }
    }
}
