using Currency2Words.Annotations;
using Currency2Words.Commands;
using Currency2Words.Models;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;

namespace Currency2Words.ViewModels
{
    public class ConverterViewModel : INotifyPropertyChanged
    {
        private string _words;
        private string _input;
        private bool _canConvert;
        private ICommand _convertCommand;

        public ConverterViewModel()
        {
            _input = "";
            _words = "no input";
            ConvertCommand = new ConvertCommand(this);
            CanConvert = true;
            Model = new ConverterModel();
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

        public ConverterModel Model { get; set; }

        public string Words
        {
            get { return _words; }
            set
            {
                _words = value;
                OnPropertyChanged("Words");
            }
        }

        public bool CanConvert
        {
            get { return _canConvert; }
            set
            {
                if (Input.Length >= 1)
                {
                    _canConvert = true;
                }
                else
                {
                    _canConvert = true;
                }
                OnPropertyChanged("CanConvert");
            }
        }

        public ICommand ConvertCommand
        {
            get { return _convertCommand; }
            set { _convertCommand = value; }
        }
    }
}