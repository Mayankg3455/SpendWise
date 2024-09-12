using ProsperDaily.MVVM.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace ProsperDaily.MVVM.ViewModel
{
    public class TransactionViewModel
    {
        public Transactions Transaction { get; set; } = new Transactions
        {
            OperationDate = DateTime.Now,
        };

        public string SaveTransactions()
        {
            App.TransactionRepo.SaveItem(Transaction);
            return App.TransactionRepo.StatusMessage;
        }

    }
}
