using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _2.BankSystem
{
    public interface ICustomerable
    {
        Customer Customer { get; set; }
    }
}
