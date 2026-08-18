using System.Text.Json.Serialization;
using Newtonsoft.Json;
using Soenneker.Attributes.PublicOpenApiObject;
using Soenneker.Dtos.IdNameValue;

namespace Soenneker.Responses.FileUpload;

/// <summary>
/// Describes a successfully uploaded file and how the client can identify and access it.
/// </summary>
[PublicOpenApiObject]
public record FileUploadResponse
{
    /// <summary>
    /// Uploaded-file reference whose <c>id</c> is the stable file identifier, <c>name</c> is the original file name, and <c>value</c> is its access URL or path.
    /// </summary>
    [JsonPropertyName("result")]
    [JsonProperty("result")]
    public IdNameValue Result { get; set; } = null!;
}
