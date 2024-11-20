using System.Text.Json.Serialization;

namespace Soenneker.Responses.FileUpload;

/// <summary>
/// A record DTO type for common file upload functionality
/// </summary>
public record FileUploadResponse
{
    [JsonPropertyName("uri")]
    public string? Uri { get; set; }
}