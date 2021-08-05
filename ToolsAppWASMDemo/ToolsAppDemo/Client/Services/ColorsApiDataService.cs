using Microsoft.JSInterop;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

using ToolsAppDemo.Client.Interfaces;
using ToolsAppDemo.Shared;

namespace ToolsAppDemo.Client.Services
{
  public class ColorsApiDataService : IColorsDataService
  {
    private HttpClient _httpClient;

    public IEnumerable<Color> Colors => throw new NotImplementedException();

    public ColorsApiDataService(HttpClient httpClient)
    {
      _httpClient = httpClient;
    }

    [JSInvokable]
    public async Task<IEnumerable<Color>> All()
    {
      return await _httpClient.GetFromJsonAsync<Color[]>("/api/colors");
    }

    public async Task<Color> One(long colorId)
    {
      return await _httpClient.GetFromJsonAsync<Color>(
        $"/api/colors/{Uri.EscapeUriString(colorId.ToString())}");
    }

    public async Task<Color> AddColor(Color color)
    {
      var httpResponseMessage = await _httpClient.PostAsJsonAsync("/api/colors", color);

      return await httpResponseMessage.Content.ReadFromJsonAsync<Color>();
    }
  }
}
