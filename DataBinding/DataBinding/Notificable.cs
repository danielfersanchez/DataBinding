﻿
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace DataBinding
{
    class Notificable : INotifyPropertyChanged
    {
        #region Implementacion

        #endregion
        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}