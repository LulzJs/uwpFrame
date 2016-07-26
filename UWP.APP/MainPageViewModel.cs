using System.Collections.ObjectModel;
using UWP.LIB;
using UWP.LIB.Controls;
using UWP.LIB.Controls.Button;
using UWP.LIB.Controls.TextBox;

namespace UWP.APP
{
    class MainPageViewModel : ViewModelBase
    {
        ObservableCollection<IControlviewModel> controls = new ObservableCollection<IControlviewModel> { new ButtonViewModel(), new TextBoxViewModel()};
        public ObservableCollection<IControlviewModel> Controls
        {
            get { return controls; }
            set { SetValue(ref controls, value); }
        }
    }
}
