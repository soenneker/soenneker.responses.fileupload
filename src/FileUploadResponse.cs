using System.Text.Json.Serialization;
using Newtonsoft.Json;
using Soenneker.Dtos.IdNameValue;

namespace Soenneker.Responses.FileUpload;

/// <summary>
/// A record DTO type for common file upload functionality
/// </summary>
public record FileUploadResponse
{
    /// <summary>
    /// Id = The unique identifier for the uploaded file
    /// Name = The original name of the uploaded file
    /// Value = The URL or path to access the uploaded file
    /// </summary>
    [JsonPropertyName("result")]
    [JsonProperty("result")]
    public IdNameValue Result { get; set; } = null!;
}