using Sales_Management.Model;
using Sales_Management.View;
using Sales_Management.ViewModel;
using System;
using System.Linq;
using System.Windows;

namespace Sales_Management.Commands
{
    public class SearchProduct : CommandBase
    {
        private readonly ExpensesViewModel expensesViewModel;

        public SearchProduct(ExpensesViewModel expensesViewModel)
        {
            this.expensesViewModel = expensesViewModel;
        }

        public override void Execute(object? parameter)
        {
            Product pd = expensesViewModel.Products.FirstOrDefault(p => p.Id == Convert.ToInt32(expensesViewModel.ProductId));
            if (pd == null)
                MessageBox.Show("Product not found");
            else
            {
                AddProductView addProductView = new AddProductView(pd, expensesViewModel);
                addProductView.ShowDialog();
            }
        }
    }
}
