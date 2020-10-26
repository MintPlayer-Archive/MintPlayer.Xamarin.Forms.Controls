using MintPlayer.MVVM.BaseModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace MintPlayer.Xamarin.Forms.Controls
{
    internal class CheckBoxVM : BaseModel
    {
        #region Text
        private string text = "Hello world";
        public string Text
        {
            get => text;
            set => SetProperty(ref text, value);
        }
        #endregion
    }
}
