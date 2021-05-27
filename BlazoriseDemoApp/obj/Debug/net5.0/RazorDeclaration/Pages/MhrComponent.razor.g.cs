// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace BlazoriseDemoApp.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Pouriya\Desktop\BlazoriseDemoApp\BlazoriseDemoApp\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Pouriya\Desktop\BlazoriseDemoApp\BlazoriseDemoApp\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Pouriya\Desktop\BlazoriseDemoApp\BlazoriseDemoApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Pouriya\Desktop\BlazoriseDemoApp\BlazoriseDemoApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Pouriya\Desktop\BlazoriseDemoApp\BlazoriseDemoApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Pouriya\Desktop\BlazoriseDemoApp\BlazoriseDemoApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Pouriya\Desktop\BlazoriseDemoApp\BlazoriseDemoApp\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Pouriya\Desktop\BlazoriseDemoApp\BlazoriseDemoApp\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Pouriya\Desktop\BlazoriseDemoApp\BlazoriseDemoApp\_Imports.razor"
using BlazoriseDemoApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Pouriya\Desktop\BlazoriseDemoApp\BlazoriseDemoApp\_Imports.razor"
using BlazoriseDemoApp.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\Pouriya\Desktop\BlazoriseDemoApp\BlazoriseDemoApp\_Imports.razor"
using Blazorise.Charts;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\Pouriya\Desktop\BlazoriseDemoApp\BlazoriseDemoApp\_Imports.razor"
using Blazorise.Charts.Streaming;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\Pouriya\Desktop\BlazoriseDemoApp\BlazoriseDemoApp\_Imports.razor"
using Blazorise.Bootstrap;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\Pouriya\Desktop\BlazoriseDemoApp\BlazoriseDemoApp\_Imports.razor"
using BlazoriseDemoApp.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\Users\Pouriya\Desktop\BlazoriseDemoApp\BlazoriseDemoApp\_Imports.razor"
using BlazoriseDemoApp.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "C:\Users\Pouriya\Desktop\BlazoriseDemoApp\BlazoriseDemoApp\_Imports.razor"
using IgniteUI.Blazor.Controls;

#line default
#line hidden
#nullable disable
    public partial class MHRComponent : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 14 "C:\Users\Pouriya\Desktop\BlazoriseDemoApp\BlazoriseDemoApp\Pages\MHRComponent.razor"
      
    ConvertModel model = new ConvertModel();
    int skipMHR = 0;
    LineChart<LiveDataPoint> MHRChart;

    public struct LiveDataPoint
    {
        public object X { get; set; }

        public object Y { get; set; }
    }

    object MHRChartOptions = new
    {
        Title = new
        {
            Display = true,
            Text = "Mother Heart Rate"
        },

        Scales = new
        {
            YAxes = new object[]
            {
                new {
                    ScaleLabel = new {
                    Display = true, LabelString = "value"},
                }
                        },

        },
        Tooltips = new
        {
            Mode = "nearest",
            Intersect = false
        },
        Hover = new
        {
            Mode = "nearest",
            Intersect = false
        }
    };

    protected override async Task OnAfterRenderAsync(bool firstRender)
    {
        if (firstRender)
        {
            await Task.WhenAll(
                HandleRedraw(MHRChart, GetLineChartDataset1));
        }
    }

    async Task HandleRedraw<TDataSet, TItem, TOptions, TModel>(BaseChart<TDataSet, TItem, TOptions, TModel> chart, params Func<TDataSet>[] getDataSets)
        where TDataSet : ChartDataset<TItem>
        where TOptions : ChartOptions
        where TModel : ChartModel
    {
        await chart.Clear();

        await chart.AddLabelsDatasetsAndUpdate(Labels, getDataSets.Select(x => x.Invoke()).ToArray());
    }

    LineChartDataset<LiveDataPoint> GetLineChartDataset1()
    {
        return new LineChartDataset<LiveDataPoint>
        {
            Data = new List<LiveDataPoint>(),
            Label = "MHR",
            BackgroundColor = backgroundColors[0],
            BorderColor = borderColors[0],
            Fill = false,
            LineTension = 0,
            BorderDash = new List<int> { 8, 4 },
        };
    }


    async Task OnMHRRefreshed(ChartStreamingData<LiveDataPoint> data)
    {

        model = await clientChartService.GetData(skipMHR);


        data.Value = new LiveDataPoint
        {
            X = DateTime.Now,
            Y = model.MHR
        };
        skipMHR++;

    }

    string[] Labels = { };
    List<string> backgroundColors =
        new List<string> {
            ChartColor.FromRgba(255, 99, 132, 0.2f),
            ChartColor.FromRgba(54, 162, 235, 0.2f),
            ChartColor.FromRgba(255, 206, 86, 0.2f),
            ChartColor.FromRgba(75, 192, 192, 0.2f),
            ChartColor.FromRgba(153, 102, 255, 0.2f),
            ChartColor.FromRgba(255, 159, 64, 0.2f) };
    List<string> borderColors = new List<string> {
        ChartColor.FromRgba(255, 99, 132, 1f),
        ChartColor.FromRgba(54, 162, 235, 1f),
        ChartColor.FromRgba(255, 206, 86, 1f),
        ChartColor.FromRgba(75, 192, 192, 1f),
        ChartColor.FromRgba(153, 102, 255, 1f),
        ChartColor.FromRgba(255, 159, 64, 1f) };


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IClinetChartService clientChartService { get; set; }
    }
}
#pragma warning restore 1591
