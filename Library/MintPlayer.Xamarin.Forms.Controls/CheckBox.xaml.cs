using System;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MintPlayer.Xamarin.Forms.Controls
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CheckBox : ContentView
    {
        public CheckBox()
        {
            InitializeComponent();
            BindingContext = this;

            //var counter = 0;
            //Task.Run(async () =>
            //{
            //    while (true)
            //    {
            //        await Task.Delay(1000);
            //        Console.WriteLine(++counter);
            //        Text = counter.ToString();
            //    }
            //});
        }

        #region IsChecked
        public static readonly BindableProperty IsCheckedProperty = BindableProperty.Create("IsChecked", typeof(bool), typeof(CheckBox), false, BindingMode.TwoWay, propertyChanged: (bindable, oldValue, newValue) =>
        {
            //global::Xamarin.Forms.CheckBox c;c.CheckedChanged
        });

        //public bool IsChecked
        //{
        //    get => (bool)GetValue(IsCheckedProperty);
        //    set
        //    {
        //        SetValue(IsCheckedProperty, value);
        //        OnPropertyChanged();
        //    }
        //}

        private bool tada;
        public bool Tada
        {
            get { return tada; }
            set
            {
                tada = value;
                OnPropertyChanged();
            }
        }
        #endregion

        #region Text
        public static readonly BindableProperty TextProperty = BindableProperty.Create("Text", typeof(string), typeof(CheckBox), "", BindingMode.OneWay, propertyChanged: (bindable, oldValue, newValue) =>
        {
                
        });

        public string Text
        {
            get => (string)GetValue(TextProperty);
            set => SetValue(TextProperty, value);
        }
        #endregion

        private void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
            //IsChecked = !IsChecked;
        }
    }
}