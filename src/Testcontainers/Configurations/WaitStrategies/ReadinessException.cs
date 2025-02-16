using System;

namespace DotNet.Testcontainers.Configurations
{
  public sealed class ReadinessException : Exception
  {
    public ReadinessException(string message)
      : base(message)
    {
    }
  }
}
