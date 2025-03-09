using System;
using System.Windows.Input;

namespace Sales_Management.Commands
{
    public abstract class CommandBase : ICommand
    {
        public event EventHandler? CanExecuteChanged;

        public virtual bool CanExecute(object? parameter)
        {
            return true;
        }

        public abstract void Execute(object? parameter);

        protected void OnCanExecuteChaged()
        {
            CanExecuteChanged?.Invoke(this, new EventArgs());
        }
    }
}
