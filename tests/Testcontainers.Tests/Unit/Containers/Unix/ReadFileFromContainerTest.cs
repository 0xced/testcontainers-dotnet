namespace DotNet.Testcontainers.Tests.Unit
{
  using System;
  using System.IO;
  using System.Text;
  using System.Threading.Tasks;
  using DotNet.Testcontainers.Builders;
  using DotNet.Testcontainers.Commons;
  using DotNet.Testcontainers.Containers;
  using Xunit;

  public sealed class ReadFileFromContainerTest : ContainerTest<ContainerBuilder, IContainer>
  {
    public ReadFileFromContainerTest() : base(builder => builder.WithImage("alpine").WithEntrypoint(CommonCommands.SleepInfinity))
    {
    }

    [Fact]
    public async Task ReadExistingFile()
    {
      // Given
      const string dayOfWeekFilePath = "/tmp/dayOfWeek";

      var dayOfWeek = DateTime.UtcNow.DayOfWeek.ToString();

      // When
      _ = await Container.ExecAsync(new[] { "/bin/sh", "-c", $"echo {dayOfWeek} > {dayOfWeekFilePath}" })
        .ConfigureAwait(false);

      var fileContent = await Container.ReadFileAsync(dayOfWeekFilePath)
        .ConfigureAwait(false);

      // Then
      Assert.Equal(dayOfWeek, Encoding.Default.GetString(fileContent).TrimEnd());
    }

    [Fact]
    public Task AccessNotExistingFileThrowsFileNotFoundException()
    {
      return Assert.ThrowsAsync<FileNotFoundException>(() => Container.ReadFileAsync("/tmp/fileNotFound"));
    }

    [Fact]
    public Task AccessDirectoryThrowsInvalidOperationException()
    {
      return Assert.ThrowsAsync<InvalidOperationException>(() => Container.ReadFileAsync("/tmp"));
    }
  }
}
