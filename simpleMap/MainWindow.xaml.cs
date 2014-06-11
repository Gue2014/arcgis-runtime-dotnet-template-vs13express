using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Esri.ArcGISRuntime.Geometry;

namespace simpleMap
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : System.Windows.Window
    {

        private async void Button_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            // Change the title of the application to "Hello Montana"
            this.Title = "Hello Montana";

            // Create an envelope with the extent (i.e. bounding box) to Montana.
            Envelope myEnvelope = new Envelope(-12957383, 5467568, -11561177, 6404397);

            // Zoom the MapView to envelope's extent.
            await MyMapView.SetViewAsync(myEnvelope);
        }

    }
}
