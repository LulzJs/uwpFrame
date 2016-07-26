
namespace UWP.LIB.Controls.TextBox
{
    public class TextBoxViewModel : ViewModelBase, IControlviewModel
    {
        private string text;

        public TextBoxViewModel(): this(new TextBoxApiModel())
        {
        }

        internal TextBoxViewModel(ITextBoxApiModel buttonApiModel)
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
