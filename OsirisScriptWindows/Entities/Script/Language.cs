// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Language.cs" company="Shane Craven">
//   Copyright (c) Shane Craven. All rights reserved.
// </copyright>
// <summary>
//   The language.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace OsirisWindows.Entities.Script
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    /// <summary>
    /// The language.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum Language
    {
        /// <summary>
        /// The c sharp.
        /// </summary>
        CSharp,

        /// <summary>
        /// The java.
        /// </summary>
        Java,

        /// <summary>
        /// The python.
        /// </summary>
        Python
    }
}
