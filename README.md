![Static Badge](https://img.shields.io/badge/.net%208.0-green?style=flat)
<a href='https://www.nuget.org/packages/File.Validator/' target="_blank"><img alt='Nuget' src='https://img.shields.io/badge/1.0.1-100000?style=flat&logo=Nuget&logoColor=FFFFFF&labelColor=969696&color=0093BD'/></a>

# About

MagicNumbers is a .NET library for file binary header validation against file extension. 
This package determines if the received file has the original extension or if it has been changed, by matching binary header data for every extension provided by [MagicNumbers wiki](https://www.wikiwand.com/en/Magic_number_(programming)).

| Package name | Description | .NET | NuGet |
| ------------ | ----------- | ---- | ----- |
| File.Validator       | Base file validator for regular use | ![Static Badge](https://img.shields.io/badge/.net%208.0-green?style=flat) | <a href='https://www.nuget.org/packages/File.Validator/' target="_blank"><img alt='Nuget' src='https://img.shields.io/badge/1.0.1-100000?style=flat&logo=Nuget&logoColor=FFFFFF&labelColor=969696&color=0093BD'/></a> |
| File.Validator.Web  |  .NET Core REST API Middleware and annotations for MVC controllers | ![Static Badge](https://img.shields.io/badge/.net%208.0-green?style=flat)     |  <a href='https://www.nuget.org/packages/File.Validator.Web/' target="_blank"><img alt='Nuget' src='https://img.shields.io/badge/1.0.0-100000?style=flat&logo=Nuget&logoColor=FFFFFF&labelColor=969696&color=0093BD'/></a>   |

## Getting started

Base Package
```bash
dotnet add package File.Validator --version 1.0.1
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
| `RejectedExtensions` | If extension IN list, expect unauthorized. (Do not do validation) | `string[]` |

```c#
[AllowedOnlyExtensions(new string[] {"pdf"})]
public IActionResult Index(IFormFile formFile)
{
    return View();
}
```
