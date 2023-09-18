namespace DotNet.Testcontainers.Tests.Fixtures
{
  using System;
  using System.Threading.Tasks;
  using DotNet.Testcontainers.Builders;
  using DotNet.Testcontainers.Commons;
  using DotNet.Testcontainers.Containers;
  using JetBrains.Annotations;

  [UsedImplicitly]
  public sealed class AlpineFixture : ContainerTest<ContainerBuilder, IContainer>
  {
    private static void AlpineBuilder(ContainerBuilder builder)
    {
      builder.WithImage(CommonImages.Alpine)
        .WithCommand(CommonCommands.SleepInfinity)
        .WithStartupCallback((_, ct) => Task.Delay(TimeSpan.FromMinutes(1), ct));
    }

    public AlpineFixture() : base(AlpineBuilder)
    {
    }
  }
}
