using System.Text;
using NJsonSchema.CodeGeneration;
using NJsonSchema.CodeGeneration.CSharp;
using NSwag;
using NSwag.CodeGeneration;
using NSwag.CodeGeneration.CSharp;
using NSwag.CodeGeneration.CSharp.Models;

/// <summary>
/// For writing clients + models in different files since this is not supported by NSwag.
/// See https://github.com/RicoSuter/NSwag/issues/1398
/// </summary>
class MultiFilesCSharpClientGenerator(OpenApiDocument document, CSharpClientGeneratorSettings settings) : CSharpClientGenerator(document, settings)
{
    public void GenerateFiles(string outputDirectory)
    {
        var clientsDirectory = Path.Combine(outputDirectory, "Clients");
        Directory.CreateDirectory(clientsDirectory);
        foreach (var client in GenerateAllClientTypes())
        {
            var fileName = $"{client.TypeName}.cs";
            File.WriteAllText(Path.Combine(clientsDirectory, client.Category == CodeArtifactCategory.Contract ? "I" + fileName : fileName), client.Code);
        }

        var modelsDirectory = Path.Combine(outputDirectory, "Models");
        Directory.CreateDirectory(modelsDirectory);
        var typeNames = new Dictionary<string, int>(StringComparer.OrdinalIgnoreCase);
        // Unfortunately Class.Annotations.liquid goes _under_ [System.CodeDom.Compiler.GeneratedCode]
        var annotations = new StringBuilder();
        annotations.AppendLine("using System;");
        annotations.AppendLine("using System.Collections.Generic;");
        annotations.AppendLine("using System.Text.Json.Serialization;");
        annotations.AppendLine();
        annotations.AppendLine($"namespace {Settings.CSharpGeneratorSettings.Namespace};");
        annotations.AppendLine();
        foreach (var dto in GenerateDtoTypes())
        {
            // counting because of RootFS + Rootfs models which differ only by case
            var count = typeNames.GetValueOrDefault(dto.TypeName, 1);
            var fileName = count == 1 ? $"{dto.TypeName}.cs" : $"{dto.TypeName}{count}.cs";
            File.WriteAllText(Path.Combine(modelsDirectory, fileName), annotations + dto.Code);
            typeNames[dto.TypeName] = count + 1;
        }
    }

    protected override CSharpOperationModel CreateOperationModel(OpenApiOperation operation, ClientGeneratorBaseSettings settings)
    {
        return new SlimCSharpOperationModel(operation, (CSharpGeneratorBaseSettings)settings, this, (CSharpTypeResolver)Resolver);
    }

    /// <summary>
    /// Reduce noise (System.Threading.Tasks + System.Collections.Generic + System.IO)
    /// </summary>
    private class SlimCSharpOperationModel(OpenApiOperation operation, CSharpGeneratorBaseSettings settings, CSharpGeneratorBase generator, CSharpTypeResolver resolver)
        : CSharpOperationModel(operation, settings, generator, resolver)
    {
        public override string ResultType
            => base.ResultType.Replace("System.Threading.Tasks.", "");

        protected override string ResolveParameterType(OpenApiParameter parameter)
            => base.ResolveParameterType(parameter).Replace("System.Collections.Generic.", "").Replace("System.IO.", "");
    }
}