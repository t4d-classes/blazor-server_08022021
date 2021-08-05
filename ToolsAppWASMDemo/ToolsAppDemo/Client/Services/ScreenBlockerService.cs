using Microsoft.JSInterop;
using System.Threading.Tasks;

namespace ToolsAppDemo.Client.Services
{
  public class ScreenBlockerService
  {

    private readonly IJSRuntime _js;

    public ScreenBlockerService(IJSRuntime js)
    {
      _js = js;
    }

    public async Task BlockScreen()
    {
       await _js.InvokeVoidAsync("$.blockUI");
    }

    public async Task UnblockScreen()
    {
      await _js.InvokeVoidAsync("$.unblockUI");
    }
  }
}
