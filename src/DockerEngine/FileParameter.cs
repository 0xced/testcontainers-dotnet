using System.IO;

namespace DockerEngine;

public class FileParameter
{
    public FileParameter(Stream data, string? fileName = null, string? contentType = null)
    {
        Data = data;
        FileName = fileName;
        ContentType = contentType;
    }

    public Stream Data { get; private set; }

    public string? FileName { get; private set; }

    public string? ContentType { get; private set; }
}
