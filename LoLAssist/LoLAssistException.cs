using System;

namespace LoLAssist
{
    /// <summary>
    /// RiotSharp exception.
    /// </summary>
    public class LoLAssistException : Exception
    {
        public LoLAssistException()
        {
        }

        public LoLAssistException(string message)
            : base(message) { }

        public LoLAssistException(string message, Exception inner)
            : base(message, inner) { }
    }
}