using Forge.Logging.Abstraction;
using Microsoft.Extensions.Logging;
using System;

namespace Forge.Logging.Microsoft
{

    /// <summary>Log wrapper implementation</summary>
    /// <seealso cref="ILog" />
    public class MSLog : ILog
    {

        private readonly ILogger mLog;

        /// <summary>Initializes a new instance of the <see cref="MSLog" /> class.</summary>
        /// <param name="log">The log.</param>
        public MSLog(ILogger log)
        {
            if (log == null) throw new ArgumentNullException("log");
            mLog = log;
        }

        /// <summary>Gets a value indicating whether this instance is fatal enabled.</summary>
        /// <value>
        ///   <c>true</c> if this instance is fatal enabled; otherwise, <c>false</c>.</value>
        public bool IsFatalEnabled { get { return mLog.IsEnabled(LogLevel.Critical); } }

        /// <summary>Gets a value indicating whether this instance is warn enabled.</summary>
        /// <value>
        ///   <c>true</c> if this instance is warn enabled; otherwise, <c>false</c>.</value>
        public bool IsWarnEnabled { get { return mLog.IsEnabled(LogLevel.Warning); } }

        /// <summary>Gets a value indicating whether this instance is information enabled.</summary>
        /// <value>
        ///   <c>true</c> if this instance is information enabled; otherwise, <c>false</c>.</value>
        public bool IsInfoEnabled { get { return mLog.IsEnabled(LogLevel.Information); } }

        /// <summary>Gets a value indicating whether this instance is debug enabled.</summary>
        /// <value>
        ///   <c>true</c> if this instance is debug enabled; otherwise, <c>false</c>.</value>
        public bool IsDebugEnabled { get { return mLog.IsEnabled(LogLevel.Debug); } }

        /// <summary>Gets a value indicating whether this instance is error enabled.</summary>
        /// <value>
        ///   <c>true</c> if this instance is error enabled; otherwise, <c>false</c>.</value>
        public bool IsErrorEnabled { get { return mLog.IsEnabled(LogLevel.Error); } }

        /// <summary>Gets a value indicating whether this instance is trace enabled.</summary>
        /// <value>
        ///   <c>true</c> if this instance is trace enabled; otherwise, <c>false</c>.</value>
        public bool IsTraceEnabled { get { return mLog.IsEnabled(LogLevel.Trace); } }

        /// <summary>Logs the specified message as a debug entry</summary>
        /// <param name="message">The message.</param>
        public void Debug(string message)
        {
            mLog.LogDebug(message);
        }

        /// <summary>Logs the specified message as a debug entry</summary>
        /// <param name="message">The message.</param>
        /// <param name="exception">The exception.</param>
        public void Debug(string message, Exception exception)
        {
            mLog.LogDebug(message, exception);
        }

        /// <summary>Logs the specified message as a error entry</summary>
        /// <param name="message">The message.</param>
        public void Error(string message)
        {
            mLog.LogError(message);
        }

        /// <summary>Logs the specified message as a error entry</summary>
        /// <param name="message">The message.</param>
        /// <param name="exception">The exception.</param>
        public void Error(string message, Exception exception)
        {
            mLog.LogError(message, exception);
        }

        /// <summary>Logs the specified message as a fatal/critical entry</summary>
        /// <param name="message">The message.</param>
        public void Fatal(string message)
        {
            mLog.LogCritical(message);
        }

        /// <summary>Logs the specified message as a fatal/critical entry</summary>
        /// <param name="message">The message.</param>
        /// <param name="exception">The exception.</param>
        public void Fatal(string message, Exception exception)
        {
            mLog.LogCritical(message, exception);
        }

        /// <summary>Logs the specified message as a info entry</summary>
        /// <param name="message">The message.</param>
        public void Info(string message)
        {
            mLog.LogInformation(message);
        }

        /// <summary>Logs the specified message as a info entry</summary>
        /// <param name="message">The message.</param>
        /// <param name="exception">The exception.</param>
        public void Info(string message, Exception exception)
        {
            mLog.LogInformation(message, exception);
        }

        /// <summary>Logs the specified message as a trace entry</summary>
        /// <param name="message">The message.</param>
        public void Trace(string message)
        {
            mLog.LogTrace(message);
        }

        /// <summary>Logs the specified message as a trace entry</summary>
        /// <param name="message">The message.</param>
        /// <param name="exception">The exception.</param>
        public void Trace(string message, Exception exception)
        {
            mLog.LogTrace(message, exception);
        }

        /// <summary>Logs the specified message as a warning entry</summary>
        /// <param name="message">The message.</param>
        public void Warn(string message)
        {
            mLog.LogWarning(message);
        }

        /// <summary>Logs the specified message as a warning entry</summary>
        /// <param name="message">The message.</param>
        /// <param name="exception">The exception.</param>
        public void Warn(string message, Exception exception)
        {
            mLog.LogWarning(message, exception);
        }

    }

    /// <summary>Log wrapper implementation</summary>
    public class MSLog<TLoggerType> : MSLog, ILog<TLoggerType>
    {

        /// <summary>Initializes a new instance of the <see cref="MSLog" /> class.</summary>
        /// <param name="log">The log.</param>
        public MSLog(ILogger log) : base(log)
        {
        }

    }

}
