#pragma checksum "/Users/bartoszwasilewski/Desktop/MovieApp/MovieApp/Client/Shared/GenericList.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "dbbb7b5ab94bce0f7ecde04cb64fa966440f6242"
// <auto-generated/>
#pragma warning disable 1591
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
    public partial class GenericList<TItem> : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
#nullable restore
#line 3 "/Users/bartoszwasilewski/Desktop/MovieApp/MovieApp/Client/Shared/GenericList.razor"
 if (List == null)
{
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "/Users/bartoszwasilewski/Desktop/MovieApp/MovieApp/Client/Shared/GenericList.razor"
     if (NullTemplate != null)
    {
        

#line default
#line hidden
#nullable disable
            __builder.AddContent(0, 
#nullable restore
#line 7 "/Users/bartoszwasilewski/Desktop/MovieApp/MovieApp/Client/Shared/GenericList.razor"
         NullTemplate

#line default
#line hidden
#nullable disable
            );
#nullable restore
#line 7 "/Users/bartoszwasilewski/Desktop/MovieApp/MovieApp/Client/Shared/GenericList.razor"
                     
    }
    else
    {
        // Default Content

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(1, "<img src=\"https://media.giphy.com/media/3oEjI6SIIHBdRxXI40/giphy.gif\">");
#nullable restore
#line 13 "/Users/bartoszwasilewski/Desktop/MovieApp/MovieApp/Client/Shared/GenericList.razor"
    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "/Users/bartoszwasilewski/Desktop/MovieApp/MovieApp/Client/Shared/GenericList.razor"
     
}
else if (List.Count == 0)
{
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "/Users/bartoszwasilewski/Desktop/MovieApp/MovieApp/Client/Shared/GenericList.razor"
     if (EmptyTemplate != null)
    {
        

#line default
#line hidden
#nullable disable
            __builder.AddContent(2, 
#nullable restore
#line 19 "/Users/bartoszwasilewski/Desktop/MovieApp/MovieApp/Client/Shared/GenericList.razor"
         EmptyTemplate

#line default
#line hidden
#nullable disable
            );
#nullable restore
#line 19 "/Users/bartoszwasilewski/Desktop/MovieApp/MovieApp/Client/Shared/GenericList.razor"
                      
    }
    else
    {
        // Default Content
        

#line default
#line hidden
#nullable disable
            __builder.AddContent(3, "There are no records to show");
#nullable restore
#line 24 "/Users/bartoszwasilewski/Desktop/MovieApp/MovieApp/Client/Shared/GenericList.razor"
                                                 
    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 25 "/Users/bartoszwasilewski/Desktop/MovieApp/MovieApp/Client/Shared/GenericList.razor"
     
}
else
{
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 29 "/Users/bartoszwasilewski/Desktop/MovieApp/MovieApp/Client/Shared/GenericList.razor"
     if (ElementTemplate != null)
    {
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 31 "/Users/bartoszwasilewski/Desktop/MovieApp/MovieApp/Client/Shared/GenericList.razor"
         foreach (var element in List)
        {
            

#line default
#line hidden
#nullable disable
            __builder.AddContent(4, 
#nullable restore
#line 33 "/Users/bartoszwasilewski/Desktop/MovieApp/MovieApp/Client/Shared/GenericList.razor"
             ElementTemplate(element)

#line default
#line hidden
#nullable disable
            );
#nullable restore
#line 33 "/Users/bartoszwasilewski/Desktop/MovieApp/MovieApp/Client/Shared/GenericList.razor"
                                     
        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 34 "/Users/bartoszwasilewski/Desktop/MovieApp/MovieApp/Client/Shared/GenericList.razor"
         
    }
    else
    {
        

#line default
#line hidden
#nullable disable
            __builder.AddContent(5, 
#nullable restore
#line 38 "/Users/bartoszwasilewski/Desktop/MovieApp/MovieApp/Client/Shared/GenericList.razor"
         WholeListTemplate

#line default
#line hidden
#nullable disable
            );
#nullable restore
#line 38 "/Users/bartoszwasilewski/Desktop/MovieApp/MovieApp/Client/Shared/GenericList.razor"
                          
    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 39 "/Users/bartoszwasilewski/Desktop/MovieApp/MovieApp/Client/Shared/GenericList.razor"
     
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 42 "/Users/bartoszwasilewski/Desktop/MovieApp/MovieApp/Client/Shared/GenericList.razor"
       
    [Parameter] public RenderFragment NullTemplate { get; set; }
    [Parameter] public RenderFragment EmptyTemplate { get; set; }
    [Parameter] public RenderFragment<TItem> ElementTemplate { get; set; }
    [Parameter] public RenderFragment WholeListTemplate { get; set; }
    [Parameter] public List<TItem> List { get; set; }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591