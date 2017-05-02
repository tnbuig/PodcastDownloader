using System;

namespace OG.PD.Common
{
    /// <summary>
    /// Exception to be thrown in case of a record or instance were not found
    /// and According to the Business logic should exist.
    /// </summary>
    public class NotFoundException : ApplicationException
    {
        public NotFoundException(string message)
            : base(message)
        {
        }

        public NotFoundException(string message, Exception exception)
            : base(message, exception)
        {
        }
    }
}