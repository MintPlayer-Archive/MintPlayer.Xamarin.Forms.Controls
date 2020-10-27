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
