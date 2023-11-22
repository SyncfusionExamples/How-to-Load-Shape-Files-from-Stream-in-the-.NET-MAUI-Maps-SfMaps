using Syncfusion.Maui.Maps;
using System.Reflection;

namespace LoadFromStream;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();
        
        Assembly assembly = Application.Current?.GetType().GetTypeInfo().Assembly;
        var jsonStream = assembly?.GetManifestResourceStream("australia.json");
        layer.ShapesSource = MapSource.FromStream(jsonStream);
        //this.Layer = layer;
        //this.Content = map;
    }
}