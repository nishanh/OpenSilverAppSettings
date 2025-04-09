using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;
using Microsoft.Extensions.Configuration;
using OpenSilver.WebAssembly;

namespace OpenSilverAppSettings.Browser.Pages
{
    [Route("/")]
    public class Index : ComponentBase
    {
        protected override void BuildRenderTree(RenderTreeBuilder __builder)
        {
        }

        protected async override Task OnInitializedAsync()
        {
            await base.OnInitializedAsync();
            await Runner.RunApplicationAsync<OpenSilverAppSettings.App>(() => new OpenSilverAppSettings.App(Configuration));
        }
        [Inject]
        private IConfiguration Configuration { get; set; }
    }
}