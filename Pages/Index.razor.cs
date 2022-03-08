using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;

namespace BlazorIJSStreamReferenceError.Pages
{
    public partial class Index
    {
        [Inject] private IJSRuntime JSRuntime { get; set; } = default!;
        [Inject] private ILogger<Index> Logger { get; set; } = default!;

        public async Task RetrieveBlobAsync()
        {
            Logger.LogInformation("RetrieveBlobAsync clicked");

            await using var streamReference = await JSRuntime.InvokeAsync<IJSStreamReference>("retrieveBlob");
            await using var stream = await streamReference.OpenReadStreamAsync();
            await using var tempOutputStream = new MemoryStream();

            Logger.LogInformation("Before copying IJSStreamReference's Stream to MemoryStream");

            await stream.CopyToAsync(tempOutputStream);

            Logger.LogInformation("After copying IJSStreamReference's Stream to MemoryStream");
        }
    }
}
