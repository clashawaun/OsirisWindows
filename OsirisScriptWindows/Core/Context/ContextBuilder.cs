// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ContextBuilder.cs" company="Shane Craven">
//   Copyright (c) Shane Craven. All rights reserved.
// </copyright>
// <summary>
//   The context builder.
//   This context builder is more light weight then the java version. Thats because the java version has methods invoked by the conversation router. This is not needed in this version
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace OsirisWindows.Core.Context
{
    using System;
    using System.IO;

    using Newtonsoft.Json;

    using OsirisWindows.Entities.Script;

    /// <summary>
    /// The context builder.
    /// This context builder is more light weight then the java version. That's because the java version has methods invoked by the conversation router. This is not needed in this version
    /// </summary>
    public class ContextBuilder
    {
        /// <summary>
        /// Get current working context.
        /// </summary>
        /// <returns>
        /// The <see cref="ScriptContext"/>.
        /// </returns>
        /// <exception cref="Exception">
        /// Throws exception is working context can't be found or is corrupted.
        /// </exception>
        public ScriptContext GetCurrentWorkingContext()
        {
            string contextString = null;

            try
            {
                contextString = File.ReadAllText("working_context.json");
            }
            catch (Exception)
            {
               throw new Exception("Failed to load context file");
            }

            if (contextString == null)
            {
                throw new Exception("Failed to load context file");
            }

            return JsonConvert.DeserializeObject<ScriptContext>(contextString);
        }

        /// <summary>
        /// Create script result file for conversation router.
        /// </summary>
        /// <param name="result">
        /// The result.
        /// </param>
        public void CreateScriptResultFile(ScriptResult result)
        {
            if (File.Exists("working_script_result.json"))
            {
                File.Delete("working_script_result.json");
            }

            try
            {
                File.WriteAllText("working_script_result.json", JsonConvert.SerializeObject(result));
            }
            catch (Exception)
            {
                return;
            }
        }
    }
}
