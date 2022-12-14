using Forge.Logging.Abstraction;
using Microsoft.Extensions.Logging;
using System;

namespace Forge.Logging.Microsoft
{

    /// <summary>Log4Net wrapper implementation</summary>
    /// <seealso cref="ILoggerWrapper" />
    public class MSManager : ILoggerWrapper
    {

        private ILoggerFactory _loggerFactory;

        /// <summary>Initializes a new instance of the <see cref="MSManager" /> class.</summary>
        /// <param name="loggerFactory">The logger factory.</param>
        public MSManager(ILoggerFactory loggerFactory)
        {
            _loggerFactory = loggerFactory;
            LogManager.LOGGER = this;
        }

        /// <summary>Gets the logger.</summary>
        /// <param name="name">The name.</param>
        /// <returns></returns>
        public ILog GetLogger(string name)
        {
            return new MSLog(_loggerFactory.CreateLogger(name));
        }

        /// <summary>Gets the logger.</summary>
        /// <returns>ILog</returns>
        public ILog GetLogger()
        {
            return new MSLog(_loggerFactory.CreateLogger("[]"));
        }

        /// <summary>Gets the logger.</summary>
        /// <typeparam name="TLoggerType">The type of the logger type.</typeparam>
        /// <returns>ILog</returns>
        public ILog<TLoggerType> GetLogger<TLoggerType>()
        {
            return new MSLog<TLoggerType>(_loggerFactory.CreateLogger(typeof(TLoggerType).FullName));
        }

        /// <summary>Gets the logger.</summary>
        /// <param name="type">The category type.</param>
        /// <returns>ILog</returns>
        public ILog GetLogger(Type type)
        {
            return new MSLog(_loggerFactory.CreateLogger(type.FullName));
        }

    }

}
