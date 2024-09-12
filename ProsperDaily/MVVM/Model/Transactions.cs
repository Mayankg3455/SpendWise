using ProsperDaily.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProsperDaily.MVVM.Model
{
    public class Transactions : TableData
    {
        public string Name { get; set; }
        
        public decimal Amount { get; set; }

        public bool IsIncome { get; set; }

        public DateTime OperationDate { get; set; }
    }
}
