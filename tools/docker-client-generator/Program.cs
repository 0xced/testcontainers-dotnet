using System.Runtime.CompilerServices;
using NJsonSchema.CodeGeneration.CSharp;
using NSwag;
using NSwag.CodeGeneration.CSharp;

var url = new Uri(args.Length > 0 ? args[0] : "https://docs.docker.com/reference/engine/v1.44.yaml");
var openApiDocument = await GetOpenApiDocumentAsync(url);
GenerateClientFiles(openApiDocument);

Console.WriteLine("Done");

return 0;

static async Task<OpenApiDocument> GetOpenApiDocumentAsync(Uri url)
{
    var file = new FileInfo(Path.Combine(GetOpenApiCacheDirectory(), url.Segments.Last()));
    if (!file.Exists)
    {
        Console.WriteLine($"Downloading the Docker Engine OpenAPI from {url} into {file}");
        using var httpClient = new HttpClient();
        await using var src = await httpClient.GetStreamAsync(url);
        await using var dst = new FileStream(file.FullName, FileMode.Create);
        await src.CopyToAsync(dst);
    }

    Console.WriteLine($"Reading the Docker Engine OpenAPI from {file}");
    return await OpenApiYamlDocument.FromFileAsync(file.FullName);
}

static void GenerateClientFiles(OpenApiDocument document)
{
    var settings = new CSharpClientGeneratorSettings
    {
        ClassName = "Docker{controller}Client",
        ExceptionClass = "DockerApiException",
        HttpClientType = "HttpClient",
        ResponseArrayType = "ICollection",
        ResponseDictionaryType = "IDictionary",
        ParameterArrayType = "IEnumerable",
        ParameterDictionaryType = "IDictionary",
        InjectHttpClient = true,
        GenerateClientInterfaces = true,
        GenerateBaseUrlProperty = false,
        GenerateOptionalParameters = true,
        GenerateClientClasses = true,
        UseBaseUrl = false,
        OperationNameGenerator = new OperationNameGenerator(),
        CSharpGeneratorSettings =
        {
            Namespace = "DockerEngine",
            JsonLibrary = CSharpJsonLibrary.SystemTextJson,
            TemplateDirectory = GetTemplateDirectory(),
            GenerateNullableReferenceTypes = true,
            GenerateOptionalPropertiesAsNullable = false,
            GenerateDataAnnotations = false,
            TypeNameGenerator = new TypeNameGenerator(new Dictionary<string, string>
            {
                ["Task"] = "DockerTask",
            }),
        }
    };

    var generator = new MultiFilesCSharpClientGenerator(document, settings);
    generator.GenerateFiles(GetOutputDirectory());
}

static string GetOutputDirectory() => Path.Combine(GetThisDirectoryPath(), "..", "..", "src", "DockerEngine");

static string GetOpenApiCacheDirectory() => Path.Combine(GetThisDirectoryPath(), "openapi");

static string GetTemplateDirectory() => Path.Combine(GetThisDirectoryPath(), "Templates");

static string GetThisDirectoryPath([CallerFilePath] string path = "") => Path.GetDirectoryName(path)!;