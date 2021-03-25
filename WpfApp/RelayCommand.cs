using System;
using System.Windows.Input;

namespace WpfApp
{
	public class RelayCommand<T> : ICommand
	{
		private Action<T> m_Execute;
		private Predicate<T> m_canExecute;

		public event EventHandler CanExecuteChanged
		{
			add { CommandManager.RequerySuggested += value; }
			remove { CommandManager.RequerySuggested -= value; }
		}

		public RelayCommand(Action<T> execute) : this(x => true, execute) { }

		public RelayCommand(Predicate<T> canExecute, Action<T> execute)
		{
			m_Execute = execute;
			m_canExecute = canExecute;
		}

		public bool CanExecute(object parameter)
		{
			return m_canExecute((T)parameter);
		}

		public void Execute(object parameter)
		{
			m_Execute((T)parameter);
		}
	}
}
