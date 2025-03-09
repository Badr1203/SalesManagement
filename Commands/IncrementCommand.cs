using Sales_Management.ViewModel;
using System;

namespace Sales_Management.Commands
{
    public class IncrementCommand : CommandBase
    {
        private AddProductViewModel _addProductViewModel;
        public IncrementCommand(AddProductViewModel addProductViewModel)
        {
            _addProductViewModel = addProductViewModel;
        }

        public override void Execute(object? parameter)
        {
            try
            {
                int quantity = Convert.ToInt32(_addProductViewModel.Quantity);
                int max = Convert.ToInt32(_addProductViewModel.MaxAllowed);
                if (quantity < max)
                {
                    _addProductViewModel.Quantity = (quantity + 1).ToString();
                }
            }
            catch
            {

            }
      
        }
    }
}
