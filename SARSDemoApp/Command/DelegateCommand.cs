﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace SARSDemoApp.Command
{
    public class DelegateCommand : ICommand
    {
        private readonly Action<object> _execute;
        private readonly Func<object, bool>? _canExecute;
        public DelegateCommand(Action<object?> execute, Func<object?, bool>? canExecute=null)
        {
            if(execute == null)
            {
                throw new ArgumentNullException(nameof(execute), "Can't be null.");
            }
            this._execute = execute;
           this._canExecute = canExecute;
        }
        public event EventHandler CanExecuteChanged;

        public void RaiseCanExecuteChanged()
        {
            CanExecuteChanged?.Invoke(this, EventArgs.Empty);
        }
        public bool CanExecute(object? parameter)
        {
            return _canExecute is null ? true : _canExecute(parameter);
        }

        public void Execute(object? parameter)
        {
            _execute(parameter);
        }
    }
}
