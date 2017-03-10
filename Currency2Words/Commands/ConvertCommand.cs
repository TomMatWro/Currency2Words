using System;
using System.Windows.Input;
using Currency2Words.ViewModels;

namespace Currency2Words.Commands
{
    public class ConvertCommand : ICommand
    {
        private ConverterViewModel _viewModel;
        private Predicate<object> _canExecute;
        private ICommand _toggleExecutionCommand;

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
            _viewModel.Words = "aaaaaaaaaa";
            _viewModel.Model.Convert2Words();
        }

        public event EventHandler CanExecuteChanged;
    }
}