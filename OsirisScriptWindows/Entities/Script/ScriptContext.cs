// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ScriptContext.cs" company="Shane Craven">
//   Copyright (c) Shane Craven. All rights reserved.
// </copyright>
// <summary>
//   The script context.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace OsirisWindows.Entities.Script
{
    /// <summary>
    /// The script context.
    /// </summary>
    public class ScriptContext
    {
        /// <summary>
        /// Gets or sets the conversation script.
        /// </summary>
        public ConversationScript ConversationScript { get; set; }

        /// <summary>
        /// Gets or sets the working directory.
        /// </summary>
        public string WorkingDirectory { get; set; }

        /// <summary>
        /// Gets or sets the orion verification key.
        /// </summary>
        public string OrionVerificationKey { get; set; }

        /// <summary>
        /// Gets or sets the user input.
        /// </summary>
        public string UserInput { get; set; }

        /// <summary>
        /// Gets or sets the conversation ID.
        /// </summary>
        public int ConversationId { get; set; }
    }
}
