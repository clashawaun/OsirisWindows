// --------------------------------------------------------------------------------------------------------------------
// <copyright file="OsirisContext.cs" company="Shane Craven">
//   Copyright (c) Shane Craven. All rights reserved.
// </copyright>
// <summary>
//   The osiris context.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace OsirisWindows
{
    using System.Collections.Generic;

    using OrionWindows;
    using OrionWindows.Core.Communication;
    using OrionWindows.Entities.Authentication;
    using OrionWindows.Logging;
    using OrionWindows.Utils;

    using OsirisWindows.Core.Controller;
    using OsirisWindows.Logging;

    /// <summary>
    /// The osiris context.
    /// </summary>
    public class OsirisContext : IOrion
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OsirisContext"/> class.
        /// </summary>
        public OsirisContext()
        {
            this.Config = new Config(this.SetConfigWithDefaults);
            this.Communicator = new ApiCommunicator(this);
            this.Logger = new Logger();
        }


        /// <summary>
        /// Initializes a new instance of the <see cref="OsirisContext"/> class.
        /// </summary>
        /// <param name="logger">
        /// The logger.
        /// </param>
        public OsirisContext(ILogger logger)
        {
            this.Config = new Config(this.SetConfigWithDefaults);
            this.Communicator = new ApiCommunicator(this);
            this.Logger = logger;
        }


        /// <summary>
        /// Initializes a new instance of the <see cref="OsirisContext"/> class.
        /// </summary>
        /// <param name="setupConfigMethod">
        /// The setup config method.
        /// </param>
        public OsirisContext(SetUpConfig setupConfigMethod)
        {
            this.Config = new Config(setupConfigMethod);
            this.Communicator = new ApiCommunicator(this);
            this.Logger = new Logger();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OsirisContext"/> class.
        /// </summary>
        /// <param name="setupConfigMethod">
        /// The setup config method.
        /// </param>
        /// <param name="authenticator">
        /// The authenticator.
        /// </param>
        public OsirisContext(SetUpConfig setupConfigMethod, IAuthenticator authenticator)
        {
            this.Config = new Config(setupConfigMethod);
            this.Communicator = new ApiCommunicator(this) { ApiAuthenticator = authenticator };
            this.Logger = new Logger();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OsirisContext"/> class.
        /// </summary>
        /// <param name="config">
        /// The config.
        /// </param>
        public OsirisContext(IConfig config)
        {
            this.Config = config;
            this.Communicator = new ApiCommunicator(this);
            this.Logger = new Logger();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OsirisContext"/> class.
        /// </summary>
        /// <param name="config">
        /// The config.
        /// </param>
        /// <param name="authenticator">
        /// The authenticator.
        /// </param>
        public OsirisContext(IConfig config, IAuthenticator authenticator)
        {
            this.Config = config;
            this.Communicator = new ApiCommunicator(this) { ApiAuthenticator = authenticator };
            this.Logger = new Logger();
        }

        /// <summary>
        /// Gets or sets the config.
        /// </summary>
        public IConfig Config { get; set; }

        /// <summary>
        /// Gets or sets the communicator.
        /// </summary>
        public ICommunicator Communicator { get; set; }

        /// <summary>
        /// Gets or sets the logger.
        /// </summary>
        public ILogger Logger { get; set; }

        /// <summary>
        /// Method to set up config file with default values
        /// </summary>
        /// <param name="config">
        /// The config.
        /// </param>
        public void SetConfigWithDefaults(IConfig config)
        {
            config.ActiveLogTypes = new List<string>() { LogType.Info, LogType.Critical, LogType.Debug, LogType.Error, LogType.Warning };
            config.ApiEndpoint = "http://api.osiris-net.com";
            config.LogFolder = string.Empty;
            config.Parser = new JsonParser();

        }

        /// <summary>
        /// Create conversation controller with current context.
        /// </summary>
        /// <returns>
        /// The <see cref="ConversationController"/>.
        /// </returns>
        public ConversationController CreateConversationController()
        {
            return new ConversationController(this);
        }

    }
}
