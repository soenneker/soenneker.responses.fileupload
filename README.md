[![](https://img.shields.io/nuget/v/soenneker.responses.fileupload.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.responses.fileupload/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.responses.fileupload/publish-package.yml?style=for-the-badge)](https://github.com/soenneker/soenneker.responses.fileupload/actions/workflows/publish-package.yml)
[![](https://img.shields.io/nuget/dt/soenneker.responses.fileupload.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.responses.fileupload/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.responses.fileupload/codeql.yml?label=CodeQL&style=for-the-badge)](https://github.com/soenneker/soenneker.responses.fileupload/actions/workflows/codeql.yml)

# Soenneker.Responses.FileUpload

Describes a successfully uploaded file and how the client can identify and access it.

## Install

```bash
dotnet add package Soenneker.Responses.FileUpload
```

## What you get

- `FileUploadResponse` — Describes a successfully uploaded file and how the client can identify and access it.

## API at a glance

| API | What it does | Result / important behavior |
| --- | --- | --- |
| `FileUploadResponse.Result` | Uploaded-file reference whose `id` is the stable file identifier, `name` is the original file name, and `value` is its access URL or path. | Uploaded-file reference whose `id` is the stable file identifier, `name` is the original file name, and `value` is its access URL or path. |
