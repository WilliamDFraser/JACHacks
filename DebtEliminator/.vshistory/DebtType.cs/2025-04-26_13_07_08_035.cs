using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DebtEliminator
{
    internal class DebtType
    {
        private string _type;
        private decimal _debtAmount;
        public decimal _intrestRate;


        public DebtType(string type_, decimal debtAmount,decimal intrestRate_ ) 

            {
                _type = type_;
            _debtAmount = debtAmount;
            }
    }
}
