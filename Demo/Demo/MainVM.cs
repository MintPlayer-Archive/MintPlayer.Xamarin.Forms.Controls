using MintPlayer.MVVM.BaseModel;
using Xamarin.Forms;

namespace MintPlayer.Xamarin.Forms.Controls.Demo
{
    public class MainVM : BaseModel
    {
        #region Build 2 demo fonts
        private static Style labelStyle1;
        private static Style labelStyle2;
        static MainVM()
        {
            labelStyle1 = new Style(typeof(Label));
            labelStyle1.Setters.Add(new Setter { Property = Label.FontFamilyProperty, Value = "Roboto" });
            labelStyle1.Setters.Add(new Setter { Property = Label.FontAttributesProperty, Value = FontAttributes.Bold });
            labelStyle2 = new Style(typeof(Label));
            labelStyle2.Setters.Add(new Setter { Property = Label.FontFamilyProperty, Value = "Wingdings 3" });
            labelStyle2.Setters.Add(new Setter { Property = Label.FontAttributesProperty, Value = FontAttributes.Italic });

        }
        #endregion

        public MainVM()
        {
        }

        #region PanelsVisible
        private bool panelsVisible;
        public bool PanelsVisible
        {
            get => panelsVisible;
            set
            {
                SetProperty(ref panelsVisible, value);

                // Proof that the labelstyle can be bound
                LabelStyle = value ? labelStyle1 : labelStyle2;
            }
        }
        #endregion

        #region LabelStyle
        private Style labelStyle;
        public Style LabelStyle
        {
            get => labelStyle;
            set => SetProperty(ref labelStyle, value);
        }
        #endregion

        #region Text
        private string text;
        public string Text
        {
            get => text;
            set => SetProperty(ref text, value);
        }
        #endregion
    }
}
