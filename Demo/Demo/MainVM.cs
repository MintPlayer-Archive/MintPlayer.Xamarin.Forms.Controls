using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;

namespace MintPlayer.Xamarin.Forms.Controls.Demo
{
    public class MainVM : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged([CallerMemberName] string propertyName = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }

        private bool panelsVisible;

        public bool PanelsVisible
        {
            get => panelsVisible;
            set
            {
                panelsVisible = value;
                OnPropertyChanged();
            }
        }
    }
}
