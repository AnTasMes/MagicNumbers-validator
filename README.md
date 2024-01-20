![Static Badge](https://img.shields.io/badge/.net%208.0-green?style=flat)
![Static Badge](https://img.shields.io/badge/nuget%20main-v1.0.0-blue?link=https%3A%2F%2Fwww.nuget.org%2Fpackages%2FFile.Validator%2F)
![Static Badge](https://img.shields.io/badge/nuget%20web-v1.0.0-blue?link=https%3A%2F%2Fwww.nuget.org%2Fpackages%2FFile.Validator.Web%2F)

# About

MagicNumbers is a .NET library for file binary header validation against file extension. 
This package determines if the received file has the original extension or if it has been changed, by matching binary header data for every extension provided by [MagicNumbers wiki](https://www.wikiwand.com/en/Magic_number_(programming)).

| Package name | Description | .NET | NuGet |
| ------------ | ----------- | ---- | ----- |
| File.Validator       | Base file validator for regular use | ![Static Badge](https://img.shields.io/badge/.net%208.0-green?style=flat)     |  ![Static Badge](https://img.shields.io/badge/nuget%20-v1.0.0-blue?link=https%3A%2F%2Fwww.nuget.org%2Fpackages%2FFile.Validator%2F)     |
| File.Validator.Web  |  .NET Core REST API Middleware and annotations for MVC controllers | ![Static Badge](https://img.shields.io/badge/.net%208.0-green?style=flat)     |  ![Static Badge](https://img.shields.io/badge/nuget%20-v1.0.0-blue?link=https%3A%2F%2Fwww.nuget.org%2Fpackages%2FFile.Validator.Web%2F)   |

## Getting started

Base Package
```bash
dotnet add package File.Validator --version 1.0.0
```
.NET MVC
```bash
dotnet add package File.Validator.Web --version 1.0.0
```

## Usage

## Base package

Using `isValidExtension` from the _FileValidator_ class required `File.Validator` package. By providing the binary stream, and expected extension, you can determine whether file data matches, that extension.

```c#
var extension = "exe";
var stream = new MemoryStream();

bool isValid = FileValidator.isValidExtension(stream, extension);
```

### MVC REST API

`File.Validator.Web` provides one additional middleware for automatic file validation before request finalization. `IApplicationBuilder` interface extension from `FileExtensionValidatorMiddlewareExtension` should be used to register the middleware with `UseFileValidation`. 

> [!NOTE] 
> To use annotations, middleware should be registered after endpoing routing middleware. 

```c#
// Program.cs
app.UseRouting();
app.UseFileValidation();
```

Using controller annotations requires `File.Validator.Web.Annotations`.

| Annotation | Description | Parameter |
| ---------- | ----------- | --------- | 
| `AllowedOnlyExtensions` | If extension NOT IN list, expect unauthorized. (still do validation) | `string[]` |
| `IgnoredExtensions` | If extension in list, skip file validation | `string[]` |
| `RejectedExtensions` | If extension IN list, expect unauthorized. (still do validation) | `string[]` |

```c#
[AllowedOnlyExtensions(new string[] {"pdf"})]
public IActionResult Index(IFormFile formFile)
{
    return View();
}
```
