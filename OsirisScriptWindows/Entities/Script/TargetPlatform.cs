// --------------------------------------------------------------------------------------------------------------------
// <copyright file="TargetPlatform.cs" company="Shane Craven">
//   Copyright (c) Shane Craven. All rights reserved.
// </copyright>
// <summary>
//   The target platform.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace OsirisWindows.Entities.Script
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    /// <summary>
    /// The target platform.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum TargetPlatform
    {
        /// <summary>
        /// The windows.
        /// </summary>
        Windows,

        /// <summary>
        /// The linux.
        /// </summary>
        Linux
    }
}
