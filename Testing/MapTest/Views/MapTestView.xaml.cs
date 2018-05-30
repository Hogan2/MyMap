using GMap.NET;
using GMap.NET.MapProviders;
using System.Windows.Controls;
using System.Windows.Input;

namespace MapTest.Views
{
    /// <summary>
    /// MapTestView.xaml 的交互逻辑
    /// </summary>
    public partial class MapTestView : UserControl
    {
        public MapTestView()
        {
            InitializeComponent();
            GMapCtrl.CacheLocation = @"D:\LOG\ProgramFiles\MapDownloader\MapCache"; //@"D:\LOG\CODE\MapDB"
            GMapCtrl.MapProvider = GMapProviders.AMapSateliteMap;

            GMapCtrl.Manager.Mode = AccessMode.CacheOnly;
            GMapCtrl.Position = new PointLatLng(30.6898, 103.9468);            
            GMapCtrl.MaxZoom = 18;
            GMapCtrl.MinZoom = 5;
            GMapCtrl.Zoom = 14;
            GMapCtrl.MouseWheelZoomType = MouseWheelZoomType.MousePositionWithoutCenter;
            GMapCtrl.ShowCenter = false;
            GMapCtrl.DragButton = MouseButton.Left;
            GMapCtrl.ShowTileGridLines = false;
        }
    }
}
