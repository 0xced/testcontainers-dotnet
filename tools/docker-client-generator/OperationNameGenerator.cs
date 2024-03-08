using NSwag;
using NSwag.CodeGeneration.OperationNameGenerators;

/// <summary>
/// For nice method names: client.Container.ListAsync() instead of client.Container.ContainerListAsync()
/// </summary>
class OperationNameGenerator : MultipleClientsFromFirstTagAndOperationNameGenerator
{
    public override string GetOperationName(OpenApiDocument document, string path, string httpMethod, OpenApiOperation operation)
    {
        var operationName = base.GetOperationName(document, path, httpMethod, operation);
        var tag = operation.Tags.FirstOrDefault();
        if (tag != null && operationName.StartsWith(tag) && operationName.Length > tag.Length)
        {
            return operationName[tag.Length..];
        }

        return operationName;
    }
}