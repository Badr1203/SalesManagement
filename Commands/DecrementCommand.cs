using Sales_Management.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sales_Management.Commands
{
    public class DecrementCommand : CommandBase
    {
        private AddProductViewModel _addProductViewModel;
        public DecrementCommand(AddProductViewModel addProductViewModel)
        {
            _addProductViewModel = addProductViewModel;
        }

        public override void Execute(object? parameter)
        {
            int quantity = Convert.ToInt32(_addProductViewModel.Quantity);
            if (quantity > 1)
            {
                _addProductViewModel.Quantity = (quantity - 1).ToString();
            }
        }
    }
}
