using MintPlayer.MVVM.BaseModel;

namespace MintPlayer.Xamarin.Forms.Controls.Demo
{
    public class MainVM : BaseModel
    {
        public MainVM()
        {
        }

        private bool panelsVisible;
        public bool PanelsVisible
        {
            get => panelsVisible;
            set => SetProperty(ref panelsVisible, value);
        }

        private string text;
        public string Text
        {
            get => text;
            set => SetProperty(ref text, value);
        }
    }
}
