using System;
using System.Threading.Tasks;

namespace UWP.LIB.Controls.Button
{
    internal class ButtonApiModel : IButtonApiModel
    {
        public ButtonApiModel()
        {
            CanClick = true;
        }

        public void Click()
        {
            CanClick = false;
            Task.Delay(TimeSpan.FromSeconds(10));
            CanClick = false;
        }

        public bool CanClick { get; set; }
    }
}
