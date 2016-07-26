using System.Windows.Input;

namespace UWP.LIB.Controls.Button
{
    public class ButtonViewModel : ViewModelBase, IControlviewModel
    {
        public IButtonApiModel ButtonApiModel { get; set; }
        public ICommand OnClickCommand { get; set; }

        public ButtonViewModel(): this(new ButtonApiModel())
        {
        }

        internal ButtonViewModel(IButtonApiModel buttonApiModel)
        {
            ButtonApiModel = buttonApiModel;
            OnClickCommand = new DelegateCommand(OnClick, OnCanClick);
        }

        private void OnClick(object parameters)
        {
            ButtonApiModel.Click();
        }

        public bool OnCanClick(object parameters)
        {
            return ButtonApiModel.CanClick;
        }
    }
}
