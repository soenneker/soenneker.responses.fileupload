[![](https://img.shields.io/nuget/v/soenneker.responses.fileupload.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.responses.fileupload/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.responses.fileupload/publish-package.yml?style=for-the-badge)](https://github.com/soenneker/soenneker.responses.fileupload/actions/workflows/publish-package.yml)
[![](https://img.shields.io/nuget/dt/soenneker.responses.fileupload.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.responses.fileupload/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.responses.fileupload/codeql.yml?label=CodeQL&style=for-the-badge)](https://github.com/soenneker/soenneker.responses.fileupload/actions/workflows/codeql.yml)

# Soenneker.Responses.FileUpload

A small response contract for returning an uploaded file's identifier, original name, and locator.

## Installation

```bash
dotnet add package Soenneker.Responses.FileUpload
```

## Usage

Return `FileUploadResponse` after persisting an uploaded file:

```csharp
using Soenneker.Dtos.IdNameValue;
using Soenneker.Responses.FileUpload;

var response = new FileUploadResponse
{
    Result = new IdNameValue
    {
        Id = storedFile.Id,
        Name = uploadedFile.FileName,
        Value = storedFile.DownloadUrl
    }
};

return Results.Ok(response);
```

The response serializes with either `System.Text.Json` or Newtonsoft.Json:

```json
{
  "result": {
    "id": "file_01J6A3M4YX",
    "name": "invoice.pdf",
    "value": "https://files.example.com/file_01J6A3M4YX"
  }
}
```

`Result.Id` and `Result.Name` are required by the underlying `IdNameValue` DTO. `Result.Value` is nullable; use it for the URL, path, or other application-defined locator returned to the client.

