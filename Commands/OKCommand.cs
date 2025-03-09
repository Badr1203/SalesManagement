using Sales_Management.ViewModel;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sales_Management.Commands
{
    public class OKCommand : CommandBase
    {
        private readonly ExpensesViewModel _expensesViewModel;

        public OKCommand(ExpensesViewModel expensesViewModel)
        {
            _expensesViewModel = expensesViewModel;
        }

        public override void Execute(object? parameter)
        {
            if (_expensesViewModel.Received != "")
            {
                double change = 0;
                change = double.Parse(_expensesViewModel.Received, CultureInfo.InvariantCulture) - double.Parse(_expensesViewModel.Total, CultureInfo.InvariantCulture);
                _expensesViewModel.Change = change.ToString();
            }
        }
    }
}
