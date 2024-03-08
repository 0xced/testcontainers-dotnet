using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace DockerEngine;

[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.0.3.0 (NJsonSchema v11.0.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class Network
{

    [JsonPropertyName("Name")]
    public string? Name { get; set; } = default!;


    [JsonPropertyName("Id")]
    public string? Id { get; set; } = default!;


    [JsonPropertyName("Created")]
    public string? Created { get; set; } = default!;


    [JsonPropertyName("Scope")]
    public string? Scope { get; set; } = default!;


    [JsonPropertyName("Driver")]
    public string? Driver { get; set; } = default!;


    [JsonPropertyName("EnableIPv6")]
    public bool? EnableIPv6 { get; set; } = default!;


    [JsonPropertyName("IPAM")]
    public IPAM? IPAM { get; set; } = default!;


    [JsonPropertyName("Internal")]
    public bool? Internal { get; set; } = default!;


    [JsonPropertyName("Attachable")]
    public bool? Attachable { get; set; } = default!;


    [JsonPropertyName("Ingress")]
    public bool? Ingress { get; set; } = default!;


    [JsonPropertyName("Containers")]
    public IDictionary<string, NetworkContainer>? Containers { get; set; } = default!;


    [JsonPropertyName("Options")]
    public IDictionary<string, string>? Options { get; set; } = default!;


    [JsonPropertyName("Labels")]
    public IDictionary<string, string>? Labels { get; set; } = default!;


}