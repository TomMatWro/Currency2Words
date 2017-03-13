using Currency2Words.ViewModels;
using System;
using System.Windows.Input;

namespace Currency2Words.Commands
{
    public class ConvertCommand : ICommand
    {
        private readonly ConverterViewModel _viewModel;

        public ConvertCommand(ConverterViewModel viewModel)
        {
            _viewModel = viewModel;
        }

        public bool CanExecute(object parameter)
        {
            return _viewModel.CanConvert;
        }

        public void Execute(object parameter)
        {
            Console.WriteLine("ConvertCommand");
            _viewModel.CurrencyInWords = "aaaaaaaaaa";
        }

        public event EventHandler CanExecuteChanged;
    }
}