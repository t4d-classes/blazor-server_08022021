// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace ToolsAppDemo.Client.ColorTool
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\ericwgreene\source\repos\blazor-server_08022021\ToolsAppWASMDemo\ToolsAppDemo\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\ericwgreene\source\repos\blazor-server_08022021\ToolsAppWASMDemo\ToolsAppDemo\Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\ericwgreene\source\repos\blazor-server_08022021\ToolsAppWASMDemo\ToolsAppDemo\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\ericwgreene\source\repos\blazor-server_08022021\ToolsAppWASMDemo\ToolsAppDemo\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\ericwgreene\source\repos\blazor-server_08022021\ToolsAppWASMDemo\ToolsAppDemo\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\ericwgreene\source\repos\blazor-server_08022021\ToolsAppWASMDemo\ToolsAppDemo\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\ericwgreene\source\repos\blazor-server_08022021\ToolsAppWASMDemo\ToolsAppDemo\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\ericwgreene\source\repos\blazor-server_08022021\ToolsAppWASMDemo\ToolsAppDemo\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\ericwgreene\source\repos\blazor-server_08022021\ToolsAppWASMDemo\ToolsAppDemo\Client\_Imports.razor"
using ToolsAppDemo.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\ericwgreene\source\repos\blazor-server_08022021\ToolsAppWASMDemo\ToolsAppDemo\Client\_Imports.razor"
using ToolsAppDemo.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\ericwgreene\source\repos\blazor-server_08022021\ToolsAppWASMDemo\ToolsAppDemo\Client\_Imports.razor"
using ToolsAppDemo.Client.ColorTool;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\ericwgreene\source\repos\blazor-server_08022021\ToolsAppWASMDemo\ToolsAppDemo\Client\_Imports.razor"
using ToolsAppDemo.Client.CarTool;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\ericwgreene\source\repos\blazor-server_08022021\ToolsAppWASMDemo\ToolsAppDemo\Client\ColorTool\ColorForm.razor"
using ToolsAppDemo.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\ericwgreene\source\repos\blazor-server_08022021\ToolsAppWASMDemo\ToolsAppDemo\Client\ColorTool\ColorForm.razor"
using ColorFormView = ToolsAppDemo.Client.ViewModels.ColorForm;

#line default
#line hidden
#nullable disable
    public partial class ColorForm : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 29 "C:\Users\ericwgreene\source\repos\blazor-server_08022021\ToolsAppWASMDemo\ToolsAppDemo\Client\ColorTool\ColorForm.razor"
       

  [Parameter]
  public string ButtonText { get; set; } = "Submit Color";

  [Parameter]
  public EventCallback<Color> OnSubmitColor { get; set; }

  private ColorFormView colorForm = new ColorFormView();

  [Parameter]
  public ElementReference DefaultControl { get; set; }

  [Parameter]
  public EventCallback<ElementReference> OnDefaultControlChanged { get; set; }

  private ElementReference defaultControl { get; set; }

  protected override async Task OnAfterRenderAsync(bool firstRender)
  {
    if (firstRender)
    {
      DefaultControl = defaultControl;
      await OnDefaultControlChanged.InvokeAsync(DefaultControl);
    }
  }

  private async Task submitColor()
  {

    var color = new Color()
    {
      Name = colorForm.Name,
      HexCode = colorForm.HexCode,
    };

    await OnSubmitColor.InvokeAsync(color);

    colorForm = new ColorFormView();
  }


#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
