using Sales_Management.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sales_Management.Commands
{
    public class DisplayNumber : CommandBase
    {
        private readonly ExpensesViewModel _expensesView;

        public DisplayNumber(ExpensesViewModel expensesViewModel)
        {
            _expensesView = expensesViewModel;
        }

        public override void Execute(object? parameter)
        {
            _expensesView.Received += parameter.ToString();
        }
    }
}
