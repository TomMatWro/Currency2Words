using Currency2Words.Annotations;
using Currency2Words.Commands;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using System.Windows.Input;
using GalaSoft.MvvmLight.Command;

namespace Currency2Words.ViewModels
{
    public class ConverterViewModel : IConverterViewModel, INotifyPropertyChanged
    {
        private string _currencyInWords;
        private string _input;
        private bool _canConvert;
        private RelayCommand _convertCommand;

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
                OnPropertyChanged("Input");
            }
        }

        public string CurrencyInWords
        {
            get { return _currencyInWords; }
            set
            {
                _currencyInWords = value;
                OnPropertyChanged("CurrencyInWords");
            }
        }

        public RelayCommand ConvertCommand
        {
            get
            {
                return _convertCommand
                    ?? (_convertCommand = new RelayCommand(
                    async () =>
                    {
                        await Convert2Words();
                    }));
            }
        }

        private async Task Convert2Words()
        {
            throw new System.NotImplementedException();
        }
    }
}