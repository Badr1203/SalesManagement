using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sales_Management.Commands
{
    public abstract class AsyncCommandBase : CommandBase
    {
        private bool isExecuting;
        private bool IsExecuting
        {
            get { return isExecuting; }
            set { isExecuting = value; OnCanExecuteChaged(); }

        }
        public override bool CanExecute(object parameter)
        {
            return !IsExecuting && base.CanExecute(parameter);
        }

        public override async void Execute(object parameter)
        {
            IsExecuting = true;

            try
            {
                await ExecuteAsync(parameter);
            }
            finally
            {
                IsExecuting = false;
            }

        }


        public abstract Task ExecuteAsync(object parameter);
    }
}
