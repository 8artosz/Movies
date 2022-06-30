// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace MovieApp.Client.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "/Users/bartoszwasilewski/Desktop/MovieApp/MovieApp/Client/_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/bartoszwasilewski/Desktop/MovieApp/MovieApp/Client/_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/Users/bartoszwasilewski/Desktop/MovieApp/MovieApp/Client/_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/Users/bartoszwasilewski/Desktop/MovieApp/MovieApp/Client/_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "/Users/bartoszwasilewski/Desktop/MovieApp/MovieApp/Client/_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "/Users/bartoszwasilewski/Desktop/MovieApp/MovieApp/Client/_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "/Users/bartoszwasilewski/Desktop/MovieApp/MovieApp/Client/_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "/Users/bartoszwasilewski/Desktop/MovieApp/MovieApp/Client/_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "/Users/bartoszwasilewski/Desktop/MovieApp/MovieApp/Client/_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "/Users/bartoszwasilewski/Desktop/MovieApp/MovieApp/Client/_Imports.razor"
using MovieApp.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "/Users/bartoszwasilewski/Desktop/MovieApp/MovieApp/Client/_Imports.razor"
using MovieApp.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "/Users/bartoszwasilewski/Desktop/MovieApp/MovieApp/Client/_Imports.razor"
using MovieApp.Shared.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "/Users/bartoszwasilewski/Desktop/MovieApp/MovieApp/Client/_Imports.razor"
using MovieApp.Client.Helpers;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "/Users/bartoszwasilewski/Desktop/MovieApp/MovieApp/Client/_Imports.razor"
using MovieApp.Shared.DTOs;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/movie/{MovieId:int}")]
    public partial class MovieDetails : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 46 "/Users/bartoszwasilewski/Desktop/MovieApp/MovieApp/Client/Shared/MovieDetails.razor"
       
    [Parameter] public int MovieId { get; set; }
    public Movie movie;
    protected override async Task OnInitializedAsync()
    {
        var responseHTTP = await httpClient.GetAsync("https://localhost:44311/api/movies/details/" + MovieId);

        if (responseHTTP.IsSuccessStatusCode)
        {
            var responseString = await responseHTTP.Content.ReadAsStringAsync();
            movie = System.Text.Json.JsonSerializer.Deserialize<Movie>(responseString, new System.Text.Json.JsonSerializerOptions() { PropertyNameCaseInsensitive = true });
        }

    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient httpClient { get; set; }
    }
}
#pragma warning restore 1591
