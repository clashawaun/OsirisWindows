// --------------------------------------------------------------------------------------------------------------------
// <copyright file="WebhookController.cs" company="Shane Craven">
//   Copyright (c) Shane Craven. All rights reserved.
// </copyright>
// <summary>
//   Defines the WebhookController type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace OsirisWindows.Core.Controller
{
    using System;
    using System.Threading.Tasks;

    using OrionWindows;
    using OrionWindows.Core.Controller;

    using OsirisWindows.Entities.Script;

    /// <summary>
    /// The webhook controller.
    /// </summary>
    public class WebhookController : IController
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookController"/> class.
        /// </summary>
        /// <param name="context">
        /// The context.
        /// </param>
        public WebhookController(IOrion context)
        {
            this.Context = context;
        }

        /// <summary>
        /// Gets or sets the context.
        /// </summary>
        public IOrion Context { get; set; }

        /// <summary>
        /// Send conversation response to Osiris from web hook conversation script.
        /// </summary>
        /// <param name="passedContext">
        /// The passed context.
        /// </param>
        /// <param name="generatedResult">
        /// The conversation script result.
        /// </param>
        /// <returns>
        /// The <see cref="Task"/>.
        /// </returns>
        public async Task<bool> SendWebhookResponseAsync(ScriptContext passedContext, ScriptResult generatedResult)
        {
            var result = await this.Context.Communicator.Post(generatedResult, $"Conversation/{passedContext.ConversationId}/Result");
            try
            {
                result.IsOk(true);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        /// <summary>
        /// Send conversation response to Osiris from web hook conversation script.
        /// </summary>
        /// <param name="passedContext">
        /// The passed context.
        /// </param>
        /// <param name="generatedResult">
        /// The conversation script result.
        /// </param>
        /// <returns>
        /// The <see cref="bool"/>.
        /// </returns>
        public bool SendWebhookResponse(ScriptContext passedContext, ScriptResult generatedResult)
        {
            var task = Task.Run(() => this.SendWebhookResponseAsync(passedContext, generatedResult));
            task.Wait();
            return task.Result;
        }
    }
}
