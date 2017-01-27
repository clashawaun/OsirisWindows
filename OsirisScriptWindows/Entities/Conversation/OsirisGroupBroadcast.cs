// --------------------------------------------------------------------------------------------------------------------
// <copyright file="OsirisGroupBroadcast.cs" company="Shane Craven">
//   
// </copyright>
// <summary>
//   Defines the OsirisGroupBroadcast type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace OsirisWindows.Entities.Conversation
{
    using OsirisWindows.Entities.Script;

    /// <summary>
    /// The osiris group broadcast.
    /// </summary>
    public class OsirisGroupBroadcast
    {
        /// <summary>
        /// Gets or sets the group name.
        /// </summary>
        public string GroupName { get; set; }

        /// <summary>
        /// Gets or sets the message.
        /// </summary>
        public string Message { get; set; }

        /// <summary>
        /// Gets or sets the method to invoke.
        /// </summary>
        public CustomOsirisMethod MethodToInvoke { get; set; }
    }
}
