using UnityEngine;

namespace ServiceLocatorExample
{
    public interface ILogger : IService //Note: the service binding happens with the interface.
    {
        void Log(string channel, string msg);
    }

    /// <summary>
    ///     Class that logs a message based in a channel.
    /// </summary>
    public class ServiceLogger : ILogger
    {
        private const string OpenBrackets = "[";
        private const string CloseBrackets = "] ";

        public void Log(string channel, string msg)
        {
            Debug.Log(string.Join(string.Empty, OpenBrackets, channel, CloseBrackets, msg));
        }
    }
}