using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Sales_Management.Commands
{
    public class Close : CommandBase
    {
        public override void Execute(object? parameter)
        {
            if (MessageBox.Show
                (
                "Do you want to close this window?",
                "Confirmation",
                MessageBoxButton.YesNo) == MessageBoxResult.Yes
                )
            {
                Environment.Exit(0);
            }
        }
    }
}
