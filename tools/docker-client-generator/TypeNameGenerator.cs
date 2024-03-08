using NJsonSchema;

/// <summary>
/// Allows to swap one type name for another, useful for e.g. Task => DockerTask
/// </summary>
class TypeNameGenerator(IReadOnlyDictionary<string, string> replacements) : DefaultTypeNameGenerator
{
    protected override string Generate(JsonSchema schema, string? typeNameHint)
    {
        var typeName = base.Generate(schema, typeNameHint);
        return replacements.GetValueOrDefault(typeName, typeName);
    }
}