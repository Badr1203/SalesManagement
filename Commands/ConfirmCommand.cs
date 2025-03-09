using Sales_Management.Model;
using Sales_Management.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Sales_Management.Commands
{
    public class ConfirmCommand : CommandBase
    {
        private ExpensesViewModel _expensesViewModel;
        private AddProductViewModel _addProductViewModel;
        private Window _window;
        public ConfirmCommand(ExpensesViewModel expensesViewModel, AddProductViewModel addProductViewModel, Window window)
        {
            _expensesViewModel = expensesViewModel;
            _addProductViewModel = addProductViewModel;
            _window = window;
        }

        public override void Execute(object? parameter)
        {
            int quantity = Convert.ToInt32(_addProductViewModel.Quantity);
            if (quantity <= Convert.ToInt32(_addProductViewModel.MaxAllowed))
            {
                Product product = _addProductViewModel.TargetProduct;

                Product cartProduct = _expensesViewModel.Cart.FirstOrDefault(p => p.Equals(product));
                if (cartProduct == null)
                {
                    cartProduct = new Product(product.Id, product.Name, product.Price, quantity);
                    _expensesViewModel.Cart.Add(cartProduct);
                }
                else
                {
                    cartProduct.Quantity += quantity;
                }
                _expensesViewModel.RefreshDataGrid();
                product.Quantity -= quantity;
                _window.Close();
            }
            else
                MessageBox.Show("Not enough product.");
        }
    }
}
