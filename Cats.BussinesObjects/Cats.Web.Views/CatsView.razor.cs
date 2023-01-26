
using Microsoft.AspNetCore.Components;

namespace Cats.Web.Views
{
    public partial class CatsView : ICatsView
    {
        [Inject]
        public ICatsViewModels viewModel { get; set; }

        protected override async Task OnInitializedAsync()
        {
            await RenderCatsAsync();
        }
        public async Task RenderCatsAsync()
        {
            await viewModel.GetCatsAsync();
            StateHasChanged();
        }
    }
}
