using System;

namespace DockerEngine
{
    public class DockerException : Exception
    {
        internal DockerException(string message) : base(message)
        {
        }

        internal DockerException(string message, Exception? innerException) : base(message, innerException)
        {
        }
    }
}