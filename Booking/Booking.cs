using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Booking
{
    enum AccountSide
    {
        Debit = 0,
        Credit = 1
    }

    class Booking
    {
        public uint ID { get; set; }
        public uint OperationID { get; set; }
        public uint AccountID { get; set; }
        public AccountSide Side { get; set; }
        public decimal Amount { get; set; }
        public uint Group { get; set; }
    }
}
