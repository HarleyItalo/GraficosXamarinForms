using System.Collections.Generic;
using Xamarin.Forms;
using SkiaSharp;
using Microcharts.Forms;

namespace Graph
{
    public partial class GraphPage : ContentPage
    {

        public List<Microcharts.Entry> Data = new List<Microcharts.Entry>
        {
             new Microcharts.Entry(200)
            {
                Label = "Janeiro",
                ValueLabel = "200",
                Color = SKColor.Parse("#266489")
            },
            new Microcharts.Entry(250)
            {
                Label = "Fevereiro",
                ValueLabel = "250",
                Color = SKColor.Parse("#68B9C0")
            },
            new Microcharts.Entry(100)
            {
                Label = "Março",
                ValueLabel = "100",
                Color = SKColor.Parse("#90D585")
            },
            new Microcharts.Entry(10)
            {
                Label = "Abril",
                ValueLabel = "10",
                Color = SKColor.Parse("#e77e23")
            }
        };


        public GraphPage()
        {
            InitializeComponent();
            var stack = Container;

            stack.Children.Add(new ChartView()
            {
                Chart = new Microcharts.DonutChart()
                {
                    Entries = Data
                },
                HeightRequest = 150

            });
            stack.Children.Add(new ChartView()
            {
                Chart = new Microcharts.LineChart()
                {
                    Entries = Data
                }
                ,
                HeightRequest = 150
            });
            stack.Children.Add(new ChartView()
            {
                Chart = new Microcharts.RadialGaugeChart()
                {
                    Entries = Data
                }
                ,
                HeightRequest = 150
            });

            stack.Children.Add(new ChartView()
            {
                Chart = new Microcharts.PointChart()
                {
                    Entries = Data
                }
                ,
                HeightRequest = 150
            });

            Grafico.Chart = new Microcharts.BarChart()
            {
                Entries = Data
            };
        }
    }
}
