﻿using Currency2Words.Annotations;
using Currency2Words.Commands;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;

namespace Currency2Words.ViewModels
{
    public class ConverterViewModel : IConverterViewModel, INotifyPropertyChanged
    {
        private string _currencyInWords;
        private string _input;

        public ConverterViewModel()
        {
            _input = "";
            _currencyInWords = "no input";
            ConvertCommand = new ConvertCommand(this);
        }

        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public string Input
        {
            get { return _input; }
            set
            {
                _input = value;
                OnPropertyChanged();
            }
        }

        public string CurrencyInWords
        {
            get { return _currencyInWords; }
            set
            {
                _currencyInWords = value;
                OnPropertyChanged();
            }
        }

        public ICommand ConvertCommand { get; set; }


        public ChildViewModel Child { get; set; }
    }

    public class ChildViewModel
    {
    }
}