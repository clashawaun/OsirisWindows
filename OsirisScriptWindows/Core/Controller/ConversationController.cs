// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ConversationController.cs" company="Shane Craven">
//   Copyright (c) Shane Craven. All rights reserved.
// </copyright>
// <summary>
//   The conversation controller.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace OsirisWindows.Core.Controller
{
    using System;
    using System.Threading.Tasks;

    using OrionWindows;
    using OrionWindows.Core.Controller;

    using OsirisWindows.Entities.Conversation;
    using OsirisWindows.Entities.Script;

    /// <summary>
    /// The conversation controller.
    /// </summary>
    public class ConversationController : IController
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ConversationController"/> class.
        /// </summary>
        /// <param name="context">
        /// The context.
        /// </param>
        public ConversationController(IOrion context)
        {
            this.Context = context;
        }

        /// <summary>
        /// Gets or sets the context.
        /// </summary>
        public IOrion Context { get; set; }

        /// <summary>
        /// Invoke custom Osiris method on target canvas.
        /// </summary>
        /// <param name="methodToInvoke">
        /// The method to invoke.
        /// </param>
        /// <returns>
        /// The <see cref="Task"/>.
        /// </returns>
        public async Task CallCustomOsirisClientMethodAsync(CustomOsirisMethod methodToInvoke)
        {
            await this.Context.Communicator.Post(methodToInvoke, "Conversation/Invoke/Custom/Method");
        }

        /// <summary>
        /// Invoke custom Osiris method on target canvas.
        /// </summary>
        /// <param name="methodToInvoke">
        /// The method to invoke.
        /// </param>
        public void CallCustomOsirisClientMethod(CustomOsirisMethod methodToInvoke)
        {
            var task = Task.Run(() => this.CallCustomOsirisClientMethodAsync(methodToInvoke));
            task.Wait();
        }

        /// <summary>
        /// Send broadcast to user's in target Osiris group.
        /// </summary>
        /// <param name="groupBroadcast">
        /// The group broadcast.
        /// </param>
        /// <returns>
        /// The <see cref="Task"/>.
        /// </returns>
        public async Task SubmitOsirisGroupBrodcastAsync(OsirisGroupBroadcast groupBroadcast)
        {
            await this.Context.Communicator.Post(groupBroadcast, "Conversation/Invoke/Group");
        }

        /// <summary>
        /// Send broadcast to user's in target Osiris group.
        /// </summary>
        /// <param name="groupBroadcast">
        /// The group broadcast.
        /// </param>
        public void SubmitOsirisGroupBroadcast(OsirisGroupBroadcast groupBroadcast)
        {
            var task = Task.Run(() => this.SubmitOsirisGroupBrodcastAsync(groupBroadcast));
            task.Wait();
        }

        /// <summary>
        /// Assign user to Osiris group for future broadcasts.
        /// </summary>
        /// <param name="conversationId">
        /// The conversation id.
        /// </param>
        /// <param name="groupName">
        /// The group name.
        /// </param>
        /// <param name="orionKey">
        /// The user's orion key.
        /// </param>
        /// <returns>
        /// The <see cref="Task"/>.
        /// </returns>
        public async Task AssignUserToGroupAsync(int conversationId, string groupName, string orionKey)
        {
            await this.Context.Communicator.Get($"Conversation/{conversationId}/Group/{groupName}/Assign/{orionKey}");
        }

        /// <summary>
        /// Assign user to Osiris group for future broadcasts.
        /// </summary>
        /// <param name="groupBroadcast">
        /// The group broadcast.
        /// </param>
        public void AssignUserToGroup(OsirisGroupBroadcast groupBroadcast)
        {
            var task = Task.Run(() => this.SubmitOsirisGroupBrodcastAsync(groupBroadcast));
            task.Wait();
        }
    }
}
