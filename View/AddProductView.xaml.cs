using Sales_Management.Model;
using Sales_Management.ViewModel;
using System;
using System.Linq;
using System.Windows;

namespace Sales_Management.View
{
    /// <summary>
    /// Interaction logic for AddProductView.xaml
    /// </summary>
    public partial class AddProductView : Window
    {
        public AddProductView(Product product, ExpensesViewModel expensesViewModel)
        {
            InitializeComponent();
            DataContext = new AddProductViewModel(product, this, expensesViewModel);
        }
    }
}
