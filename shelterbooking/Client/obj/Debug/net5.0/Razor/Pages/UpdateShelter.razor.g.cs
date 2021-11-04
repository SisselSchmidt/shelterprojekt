#pragma checksum "C:\Users\sisse\Documents\GitHub\shelterbooking\shelterbooking\shelterbooking\Client\Pages\UpdateShelter.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e2f3250714c932f4cc0b96aca4919d629ddc61a0"
// <auto-generated/>
#pragma warning disable 1591
namespace shelterbooking.Client.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\sisse\Documents\GitHub\shelterbooking\shelterbooking\shelterbooking\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\sisse\Documents\GitHub\shelterbooking\shelterbooking\shelterbooking\Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\sisse\Documents\GitHub\shelterbooking\shelterbooking\shelterbooking\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\sisse\Documents\GitHub\shelterbooking\shelterbooking\shelterbooking\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\sisse\Documents\GitHub\shelterbooking\shelterbooking\shelterbooking\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\sisse\Documents\GitHub\shelterbooking\shelterbooking\shelterbooking\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\sisse\Documents\GitHub\shelterbooking\shelterbooking\shelterbooking\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\sisse\Documents\GitHub\shelterbooking\shelterbooking\shelterbooking\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\sisse\Documents\GitHub\shelterbooking\shelterbooking\shelterbooking\Client\_Imports.razor"
using shelterbooking.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\sisse\Documents\GitHub\shelterbooking\shelterbooking\shelterbooking\Client\_Imports.razor"
using shelterbooking.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\sisse\Documents\GitHub\shelterbooking\shelterbooking\shelterbooking\Client\Pages\UpdateShelter.razor"
using shelterbooking.Shared;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/shelter/edit/{shelId}")]
    public partial class UpdateShelter : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>Edit</h3>\r\n");
            __builder.OpenComponent<shelterbooking.Client.Pages.Form2>(1);
            __builder.AddAttribute(2, "ButtonText", "Update");
            __builder.AddAttribute(3, "shel", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<shelterbooking.Shared.Shelter>(
#nullable restore
#line 8 "C:\Users\sisse\Documents\GitHub\shelterbooking\shelterbooking\shelterbooking\Client\Pages\UpdateShelter.razor"
                                  shel

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(4, "OnValidSubmit", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, 
#nullable restore
#line 9 "C:\Users\sisse\Documents\GitHub\shelterbooking\shelterbooking\shelterbooking\Client\Pages\UpdateShelter.razor"
                      EditShelter

#line default
#line hidden
#nullable disable
            )));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 10 "C:\Users\sisse\Documents\GitHub\shelterbooking\shelterbooking\shelterbooking\Client\Pages\UpdateShelter.razor"
       
    [Parameter] public string shelId { get; set; }
    public Shelter shel = new Shelter();

    protected async override Task OnParametersSetAsync()
    {
        shel = await Http.GetFromJsonAsync<Shelter>($"api/shelters/{shelId}");

    }
 
    async Task EditShelter()
    {
        await Http.PutAsJsonAsync($"api/shelters/{shelId}", shel);
        await js.InvokeVoidAsync("alert", $"Updated Successfully!");
        uriHelper.NavigateTo("pedelside");
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager uriHelper { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime js { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
#pragma warning restore 1591
