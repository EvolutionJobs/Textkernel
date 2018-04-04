# Textkernel Service
.NET Core service to send CVs to Textkernel's Extract service. 

Contact [Textkernel](https://www.textkernel.com/hr-software/extract-cv-parsing/) to access their CV Extract API.

This serialises the result to .NET structured objects, see [Model](Models).


## Startup Injection

To add this service:

``` c#
// Don't hard code these - use https://docs.microsoft.com/en-us/aspnet/core/security/app-secrets?tabs=visual-studio
string address = $"https://{textkernelService}";
string account = "your account";
string username = "your username";
string password = "your secret password";

services.AddTextkernelParser(address, account, username, password);
```

## Using the CV Parsing Service

Then this service is available as `ITextkernelParser`, for instance as a Web API action:

``` c#
[HttpPost("parseCV")]
public async Task<IEnumerable<Profile>> ParseCV(
    [FromServices] ITextkernelParser parser,     // Get the parser from the injected services 
    [FromForm] IEnumerable<IFormFile> files) // CV files posted from an HTML form
{
    var result = new List<Profile>();
    foreach (var f in files)
    {
        if (f.Length == 0)
             continue;

        using (var s = new MemoryStream())
        {
            await f.CopyToAsync(s);
            var parsed = await parser.Parse(s.ToArray(), f.FileName);
            result.Add(parsed);
        }
    }

    return result;
}
```

## Request Details

Requests to the Textkernel service are sent and recieved as SOAP.