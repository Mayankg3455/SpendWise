using PropertyChanged;
using ProsperDaily.MVVM.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProsperDaily.MVVM.ViewModel
{
    [AddINotifyPropertyChangedInterface]
    public class DashboardViewModel
    {
        public ObservableCollection<Transactions> Transactions { get; set; }

        public decimal Balance { get; set; } 
        public decimal Income { get; set; }
        public decimal Expenses { get; set; }
        public DashboardViewModel()
        {
            FillData();
        }

        public void FillData()
        {
            var transactionns = App.TransactionRepo.GetItems();
            transactionns = transactionns.OrderByDescending(x => x.OperationDate).ToList();

            Transactions = new ObservableCollection<Transactions>(transactionns);

            Balance = 0;
            Income = 0;
            Expenses = 0;

            foreach(var transaction in transactionns)
            {
                if(transaction.IsIncome == true)
                {
                    Income += transaction.Amount;
                }
                else
                {
                    Expenses += transaction.Amount;
                }
            }

            Balance = Income - Expenses;

        }
    }


}
