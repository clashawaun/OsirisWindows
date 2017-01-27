// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ConversationScript.cs" company="Shane Craven">
//   Copyright (c) Shane Craven. All rights reserved.
// </copyright>
// <summary>
//   The conversation script.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace OsirisWindows.Entities.Script
{
    /// <summary>
    /// The conversation script.
    /// </summary>
    public class ConversationScript
    {
        /// <summary>
        /// Gets or sets the id.
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the target platform.
        /// </summary>
        public TargetPlatform TargetPlatform { get; set; }

        /// <summary>
        /// Gets or sets the language.
        /// </summary>
        public Language Language { get; set; }

        /// <summary>
        /// Gets or sets the version.
        /// </summary>
        public string Version { get; set; }

        /// <summary>
        /// Gets or sets the path.
        /// </summary>
        public string Path { get; set; }

        /// <summary>
        /// Gets or sets the command line.
        /// </summary>
        public string CommandLine { get; set; }

        /// <summary>
        /// Gets or sets the script provider.
        /// </summary>
        public ScriptProvider ScriptProvider { get; set; }
    }
}
