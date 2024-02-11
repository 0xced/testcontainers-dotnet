namespace Testcontainers;

public class ContainerRestartTest
{
    [Theory]
    [ClassData(typeof(ContainerBuilderTheoryData))]
    public async Task RestartMultipleTimes(Type containerBuilderType)
    {
        var builder = Activator.CreateInstance(containerBuilderType);
        var container = ((IContainer)builder!.GetType().GetMethod("Build")!.Invoke(builder, parameters: null))!;
        try
        {
            // Given
            var timeoutSource = new CancellationTokenSource(TimeSpan.FromMinutes(5));

            // When
            var exception = await RestartAsync(container, timeoutSource.Token);

            // Then
            Assert.Null(exception);
        }
        finally
        {
            await container.DisposeAsync();
        }
    }

    private static async Task<Exception> RestartAsync(IContainer container, CancellationToken cancellationToken)
    {
        for (var i = 0; i < 3; i++)
        {
            var exception = await Record.ExceptionAsync(async () =>
            {
                await container.StartAsync(cancellationToken);
                await container.StopAsync(cancellationToken);
            });

            if (exception != null)
            {
                return exception;
            }
        }

        return null;
    }

    private class ContainerBuilderTheoryData : TheoryData<Type>
    {
        public ContainerBuilderTheoryData()
        {
            var containerBuilderTypes = Directory.GetFiles(".", "Testcontainers.*.Tests.dll", SearchOption.TopDirectoryOnly)
                .Select(Path.GetFullPath)
                .Select(Assembly.LoadFrom)
                .SelectMany(assembly => assembly.GetReferencedAssemblies().Where(a => a.Name != null && a.Name.StartsWith("Testcontainers.") && !a.Name.StartsWith("Testcontainers.Commons")))
                .Select(Assembly.Load)
                .SelectMany(referencedAssembly => referencedAssembly.ExportedTypes)
                .Where(type => type.BaseType?.IsGenericType == true && type.BaseType.GetGenericTypeDefinition() == typeof(ContainerBuilder<,,>))
                .OrderBy(type => type.Name)
                .ToArray();
            AddRange(containerBuilderTypes);
        }
    }
}