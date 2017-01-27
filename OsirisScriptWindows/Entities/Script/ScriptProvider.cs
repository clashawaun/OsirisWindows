// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ScriptProvider.cs" company="Shane Craven">
//   Copyright (c) Shane Craven. All rights reserved.
// </copyright>
// <summary>
//   The script provider.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace OsirisWindows.Entities.Script
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    /// <summary>
    /// The script provider.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum ScriptProvider
    {
        /// <summary>
        /// The osiris hosted.
        /// </summary>
        OsirisHosted,

        /// <summary>
        /// The s 3.
        /// </summary>
        S3,

        /// <summary>
        /// The local file system.
        /// </summary>
        LocalFileSystem,

        /// <summary>
        /// The network share.
        /// </summary>
        NetworkShare,

        /// <summary>
        /// The one drive.
        /// </summary>
        OneDrive
    }
}
