using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace DockerEngine;

// Adapted from https://github.com/dotnet/runtime/issues/74385#issuecomment-1705083109
internal sealed class JsonEnumMemberConverter<[DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.PublicFields)] TEnum>()
    : JsonStringEnumConverter(namingPolicy: ResolveNamingPolicy())
    where TEnum : struct, Enum
{
    private static JsonNamingPolicy? ResolveNamingPolicy()
    {
        var map = typeof(TEnum).GetFields(BindingFlags.Public | BindingFlags.Static)
            .Select(f => (f.Name, AttributeName: f.GetCustomAttribute<EnumMemberAttribute>()?.Value))
            .Where(pair => pair.AttributeName != null)
            .ToDictionary(e => e.Name, e => e.AttributeName!);

        return map.Count > 0 ? new EnumMemberNamingPolicy(map) : null;
    }

    private sealed class EnumMemberNamingPolicy(Dictionary<string, string> map) : JsonNamingPolicy
    {
        public override string ConvertName(string name) => map.GetValueOrDefault(name, name);
    }
}