using Sales_Management.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sales_Management.Commands
{
    public class Remove : CommandBase
    {
        private readonly ExpensesViewModel _expensesViewModel;

        public Remove(ExpensesViewModel expensesViewModel)
        {
            _expensesViewModel = expensesViewModel;
        }

        public override void Execute(object? parameter)
        {
            if (_expensesViewModel.Received.Length == 1)
            {
                _expensesViewModel.Received = "0";
            }
            else if (_expensesViewModel.Received.Length > 0)
            {
                _expensesViewModel.Received = _expensesViewModel.Received.Remove(_expensesViewModel.Received.Length - 1, 1);
            }
        }
    }
}
