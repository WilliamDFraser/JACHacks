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
        private decimal _intrestRate;
        private decimal _minimumPayment;

        public DebtType(string type_, decimal debtAmount,decimal intrestRate_ ) 

            {
                _type = type_;
            _debtAmount = debtAmount;
            _minimumPayment = intrestRate_;
            _intrestRate = intrestRate_;
            }


        public string Type 
        {
            get { return _type; }

            set 
            {
                
                _type = value; 
            }
        }
        public string DebtAmount
        {
            get { return _type; }

            set
            {

                _type = value;
            }
        }
    }
}
