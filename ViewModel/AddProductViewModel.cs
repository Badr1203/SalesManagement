using Sales_Management.Commands;
using Sales_Management.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace Sales_Management.ViewModel
{
    public class AddProductViewModel : ViewModelBase
    {
        private string productData;
        public string ProductData
        {
            get
            {
                return productData;
            }
            set
            {
                productData = value;
                OnPropertyChanged(nameof(ProductData));
            }
        }
        
        private string quantity;
        public string Quantity
        {
            get
            {
                return quantity;
            }
            set
            {
                quantity = value;
                OnPropertyChanged(nameof(Quantity));
            }
        }
        
        private string maxAllowed;
        public string MaxAllowed
        {
            get
            {
                return maxAllowed;
            }
            set
            {
                maxAllowed = value;
                OnPropertyChanged(nameof(MaxAllowed));
            }
        }

        private Product targetProduct;
        public Product TargetProduct
        {
            get
            {
                return targetProduct;
            }
            set
            {
                targetProduct = value;
                OnPropertyChanged(nameof(TargetProduct));
            }
        }

        public ICommand CancelCommand { get; }
        public ICommand ConfirmCommand { get; }
        public ICommand IncrementCommand { get; }
        public ICommand DecrementCommand { get; }

        public AddProductViewModel(Product product, Window window, ExpensesViewModel expensesViewModel)
        {
            CancelCommand = new CancelCommand(window);
            ConfirmCommand = new ConfirmCommand(expensesViewModel, this, window);
            IncrementCommand = new IncrementCommand(this);
            DecrementCommand = new DecrementCommand(this);

            TargetProduct = product;
            Quantity = "1";
            MaxAllowed = product.Quantity.ToString();
            ProductData = product.Id.ToString() + " " + product.Name + " Price: " + product.Price;
        }
    }
}
