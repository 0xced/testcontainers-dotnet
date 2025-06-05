namespace DockerEngine;

internal sealed class JsonEnumMemberConverter<[DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.PublicFields)] TEnum> : JsonConverter<TEnum>
    where TEnum : struct, Enum
{
    private static readonly Dictionary<string, TEnum> StringToEnum;
    private static readonly Dictionary<TEnum, string> EnumToString;

    static JsonEnumMemberConverter()
    {
        StringToEnum = typeof(TEnum).GetFields(BindingFlags.Public | BindingFlags.Static)
            .Select(f => (Value: (TEnum)f.GetValue(null)!, f.Name, AttributeName: f.GetCustomAttribute<EnumMemberAttribute>()?.Value))
            .ToDictionary(e => e.AttributeName ?? e.Name, e => e.Value);

        EnumToString = StringToEnum.ToDictionary(e => e.Value, e => e.Key);
    }

    public override TEnum Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        var text = reader.GetString();
        if (text != null && StringToEnum.TryGetValue(text, out var value))
        {
            return value;
        }

        throw new JsonException($"Can't convert {text} to enum {typeof(TEnum)}");
    }

    public override void Write(Utf8JsonWriter writer, TEnum value, JsonSerializerOptions options)
    {
        var stringValue = EnumToString.TryGetValue(value, out var text) ? text : value.ToString();
        writer.WriteStringValue(stringValue);
    }
}