namespace UWP.LIB.Controls.Button
{
    public interface IButtonApiModel
    {
        void Click();
        bool CanClick { get; set; }
    }
}