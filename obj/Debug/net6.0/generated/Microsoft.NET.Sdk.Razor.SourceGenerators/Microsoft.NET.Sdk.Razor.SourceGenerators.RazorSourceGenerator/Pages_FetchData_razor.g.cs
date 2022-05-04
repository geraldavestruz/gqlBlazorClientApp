﻿#pragma checksum "C:\Users\Administrator\ClientApp\Pages\FetchData.razor" "{8829d00f-11b8-4213-878b-770e8597ac16}" "180288d6301d6f4e1e4b1e9de051375938b02ad215ff2e3192daa1053dc051bc"
// <auto-generated/>
#pragma warning disable 1591
namespace ClientApp.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Administrator\ClientApp\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Administrator\ClientApp\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Administrator\ClientApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Administrator\ClientApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Administrator\ClientApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Administrator\ClientApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Administrator\ClientApp\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Administrator\ClientApp\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Administrator\ClientApp\_Imports.razor"
using ClientApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Administrator\ClientApp\_Imports.razor"
using ClientApp.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\Administrator\ClientApp\_Imports.razor"
using ClientApp.CakeSchema;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\Administrator\ClientApp\_Imports.razor"
using ClientApp.Dtos;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/fetchdata")]
    public partial class FetchData : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Web.PageTitle>(0);
            __builder.AddAttribute(1, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddContent(2, "Weather forecast");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(3, "\r\n\r\n");
            __builder.AddMarkupContent(4, "<h1>Weather forecast</h1>\r\n\r\n");
            __builder.AddMarkupContent(5, "<p>This component demonstrates fetching data from the server.</p>");
#nullable restore
#line 10 "C:\Users\Administrator\ClientApp\Pages\FetchData.razor"
 if (forecasts == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(6, "<p><em>Loading...</em></p>");
#nullable restore
#line 13 "C:\Users\Administrator\ClientApp\Pages\FetchData.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(7, "table");
            __builder.AddAttribute(8, "class", "table");
            __builder.AddMarkupContent(9, "<thead><tr><th>Date</th>\r\n                <th>Temp. (C)</th>\r\n                <th>Temp. (F)</th>\r\n                <th>Summary</th></tr></thead>\r\n        ");
            __builder.OpenElement(10, "tbody");
#nullable restore
#line 26 "C:\Users\Administrator\ClientApp\Pages\FetchData.razor"
             foreach (var forecast in forecasts)
            {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(11, "tr");
            __builder.OpenElement(12, "td");
#nullable restore
#line (29,26)-(29,59) 25 "C:\Users\Administrator\ClientApp\Pages\FetchData.razor"
__builder.AddContent(13, forecast.Date.ToShortDateString());

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(14, "\r\n                    ");
            __builder.OpenElement(15, "td");
#nullable restore
#line (30,26)-(30,47) 25 "C:\Users\Administrator\ClientApp\Pages\FetchData.razor"
__builder.AddContent(16, forecast.TemperatureC);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(17, "\r\n                    ");
            __builder.OpenElement(18, "td");
#nullable restore
#line (31,26)-(31,47) 25 "C:\Users\Administrator\ClientApp\Pages\FetchData.razor"
__builder.AddContent(19, forecast.TemperatureF);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(20, "\r\n                    ");
            __builder.OpenElement(21, "td");
#nullable restore
#line (32,26)-(32,42) 25 "C:\Users\Administrator\ClientApp\Pages\FetchData.razor"
__builder.AddContent(22, forecast.Summary);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 34 "C:\Users\Administrator\ClientApp\Pages\FetchData.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 37 "C:\Users\Administrator\ClientApp\Pages\FetchData.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 39 "C:\Users\Administrator\ClientApp\Pages\FetchData.razor"
       
    private WeatherForecast[]? forecasts;

    protected override async Task OnInitializedAsync()
    {
        forecasts = await Http.GetFromJsonAsync<WeatherForecast[]>("sample-data/weather.json");
    }

    public class WeatherForecast
    {
        public DateTime Date { get; set; }

        public int TemperatureC { get; set; }

        public string? Summary { get; set; }

        public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
#pragma warning restore 1591
