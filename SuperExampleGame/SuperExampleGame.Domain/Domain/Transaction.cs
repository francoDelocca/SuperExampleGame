using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperExampleGame.Domain.Domain
{
    public class Transaction
    {
        public Guid TransactionId { get; set; }
        public decimal TransactionCost { get; set; }
    }
}
