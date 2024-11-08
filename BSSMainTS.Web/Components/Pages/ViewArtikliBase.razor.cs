using Blazorise.DataGrid;
using Microsoft.AspNetCore.Components;

namespace BSSMainTS.Web.Components.Pages
{
    public partial class ViewArtikliBase : ComponentBase
    {
        private Artikal[]? artikli;
        private int totalItems;

        private async Task OnReadData(DataGridReadDataEventArgs<Artikal> e)
        {
            if (!e.CancellationToken.IsCancellationRequested)
            {
                List<Artikal> response = null;

                if (e.ReadDataMode is DataGridReadDataMode.Virtualize)
                {
                    response = (await apiService.GetArtikliAsync()).Skip(e.VirtualizeOffset).Take(e.VirtualizeCount).ToList();
                }
                else if (e.ReadDataMode is DataGridReadDataMode.Paging)
                {
                    response = (await apiService.GetArtikliAsync()).Skip((e.Page - 1) * e.PageSize).Take(e.PageSize).ToList();
                }
                else
                {
                    throw new Exception("Unhandled ReadDataMode");
                }

                if (!e.CancellationToken.IsCancellationRequested)
                {
                    totalItems = (await apiService.GetArtikliAsync()).Length;
                    artikli = response.ToArray(); // an actual data for the current page
                }
            }
        }

        protected override async Task OnInitializedAsync()
        {
            artikli = await apiService.GetArtikliAsync();
        }
    }
}