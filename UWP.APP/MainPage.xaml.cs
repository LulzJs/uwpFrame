using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Threading.Tasks;
using UWP.LIB.MemoryLeaks;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace UWP.APP
{
    
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public event EventHandler DoLeak;
        public MainPage()
        {
            DataContext = new MainPageViewModel();
            this.InitializeComponent();
            //Memory leak
            /*Task.Run(() =>
            {
                LeakEvent ml;
                while (true)
                {
                    ml = new LeakEvent();
                    DoLeak += ml.DoLeak;
                }
            });*/
            //No memory Leak
            /*Task.Run(() =>
            {
                NoLeakEvent ml;
                while (true)
                {
                    ml = new NoLeakEvent((object obj, EventArgs args) => { });
                }
            });*/
        }
    }
}
