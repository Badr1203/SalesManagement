using OfficeOpenXml;
using Sales_Management.Commands;
using Sales_Management.Model;
using System;
using System.Collections.ObjectModel;
using System.IO;
using System.Windows.Input;

namespace Sales_Management.ViewModel
{
    public class ExpensesViewModel : ViewModelBase
    {

        private string total;
        public string Total
        {
            get
            {
                return total;
            }
            set
            {
                total = value;
                OnPropertyChanged(nameof(Total));
            }
        }

        private string received;
        public string Received
        {
            get
            {
                return received;
            }
            set
            {
                received = value;
                OnPropertyChanged(nameof(Received));
            }
        }

        private string change;
        public string Change
        {
            get
            {
                return change;
            }
            set
            {
                change = value;
                OnPropertyChanged(nameof(Change));
            }
        }

        private string productId;
        public string ProductId
        {
            get
            {
                return productId;
            }
            set
            {
                productId = value;
                OnPropertyChanged(nameof(ProductId));
            }
        }

        private string cardId;
        public string CardId
        {
            get
            {
                return cardId;
            }
            set
            {
                cardId = value;
                OnPropertyChanged(nameof(CardId));
            }
        }

        private ObservableCollection<Product> _products;
        public ObservableCollection<Product> Products
        {
            get
            {
                return _products;
            }
            set
            {
                _products = value;
                OnPropertyChanged(nameof(Products));
            }
        }

        private ObservableCollection<Product> _cart;
        public ObservableCollection<Product> Cart
        {
            get
            {
                return _cart;
            }
            set
            {
                _cart = value;
                OnPropertyChanged(nameof(Cart));
            }
        }

        private void LoadProductsFromExcel()
        {
            string filePath = "ExcelSheets/Products.xlsx";

            if (File.Exists(filePath))
            {
                ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
                using ExcelPackage package = new ExcelPackage(new FileInfo(filePath));
                ExcelWorksheet sheet = package.Workbook.Worksheets["Sheet1"];
                int rowCount = sheet.Dimension.Rows;

                for (int row = 1; row <= rowCount; row++)
                {
                    int Id = Convert.ToInt32(sheet.Cells[row, 1].Value);
                    string Name = sheet.Cells[row, 2].Value.ToString();
                    double Price = Convert.ToDouble(sheet.Cells[row, 3].Value);
                    int Quantity = Convert.ToInt32(sheet.Cells[row, 4].Value);
                    Product p = new(Id, Name, Price, Quantity);
                    Products.Add(p);

                }
            }
        }

        public ICommand DisplayNumberCommand { get;  }
        public ICommand CloseCommand { get; }
        public ICommand OKCommand { get; }
        public ICommand RemoveCommand { get; }
        public ICommand SearchProduct { get; }


        public ExpensesViewModel()
        {
            DisplayNumberCommand = new DisplayNumber(this);
            CloseCommand = new Close();
            OKCommand = new OKCommand(this);
            RemoveCommand = new Remove(this);
            Products = new ObservableCollection<Product>();
            Cart = new ObservableCollection<Product>();
            SearchProduct = new SearchProduct(this);
            Received = "0";
            Total = "0";
            Change = "0";
            LoadProductsFromExcel();
        }

        public void RefreshDataGrid()
        {
            Cart = new ObservableCollection<Product>(Cart);
            double total = 0;
            foreach (Product p in Cart)
            {
                total += p.TotalPrice;
            }
            Total = total.ToString();
        }
    }
}
