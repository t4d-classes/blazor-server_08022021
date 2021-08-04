# Setup Blazorise

1. Install the following Nuget Packages:

- ToolsApp.Web Project
    - Blazorise.Bootstrap
    - Blazorise.Icons.FontAwesome
- ToolsApp.Components Project
    - Blazorise.Bootstrap
    - Blazorise.Icons.FontAwesome
    - Blazorise.Components
    - Blazorise.DataGrid

2. Update the `_Host.cshtml` file:

In the `style` block:

```html
<link href="_content/Blazorise/blazorise.css" rel="stylesheet" />
<link href="_content/Blazorise.Bootstrap/blazorise.bootstrap.css" rel="stylesheet" />
```

At the bottom of the `body` block:

```html
<script src="https://code.jquery.com/jquery-3.5.1.slim.min.js" integrity="sha384-DfXdz2htPH0lsSSs5nCTpuj/zy4C+OGpamoFVy38MVBnE+IbbVYUew+OrCXaRkfj" crossorigin="anonymous"></script>
<script src="https://cdn.jsdelivr.net/npm/popper.js@1.16.1/dist/umd/popper.min.js" integrity="sha384-9/reFTGAW83EW2RDu2S0VKaIzap3H66lZH81PoYlFhbGU+6BZp6G7niu735Sk7lN" crossorigin="anonymous"></script>
<script src="https://cdn.jsdelivr.net/npm/bootstrap@4.6.0/dist/js/bootstrap.min.js" integrity="sha384-+YQ4JLhjyBLPDQt//I+STsc9iw4uQqACwlvpslubQzn4u2UU2UFM80nGisd026JF" crossorigin="anonymous"></script>

<script src="_content/Blazorise/blazorise.js"></script>
<script src="_content/Blazorise.Bootstrap/blazorise.bootstrap.js"></script>
</body>
```

3. Add the following code to the `_Imports.razor` file in the `ToolsApp.Web` project:

```csharp
@using Blazorise
```

4. Add the following code to the `_Imports.razor` file in the `ToolsApp.Components` project:

```csharp
@using Blazorise
@using Blazorise.Components
@using Blazorise.DataGrid
```

5. Add the following code to the `Startup.cs` file.

Add this in the `using`s block of code:

```
using Blazorise;
using Blazorise.Bootstrap;
using Blazorise.Icons.FontAwesome;
```

Add this in the `ConfigureServices` method:

```csharp
services
  .AddBlazorise(options =>
    {
    options.ChangeTextOnKeyPress = true; // optional
    })
  .AddBootstrapProviders()
  .AddFontAwesomeIcons();
```
