using MintPlayer.MVVM.BaseModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace MintPlayer.Xamarin.Forms.Controls.Demo
{
    public class MainVM : BaseModel
    {
        public MainVM()
        {
            StartCounting();
        }

        private int c = 0;
        private async void StartCounting()
        {
            while (true)
            {
                await Task.Delay(1000);
                Console.WriteLine(++c);
                Text = c.ToString();
            }
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
