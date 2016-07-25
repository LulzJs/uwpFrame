
namespace UWP.LIB.Controls.TextBox
{
    public class TextBoxViewModel : ViewModelBase
    {
        private string text;

        public TextBoxViewModel(ITextBoxApiModel buttonApiModel)
        {
            ButtonApiModel = buttonApiModel;
        }

        public string Text {
            get { return text; }
            set { SetValue(ref text, value); }
        }

        public ITextBoxApiModel ButtonApiModel { get; set; }
    }
}
