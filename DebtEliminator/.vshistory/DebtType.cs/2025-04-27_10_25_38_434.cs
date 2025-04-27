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

        public DebtType(string type_, decimal debtAmount_,decimal intrestRate_,decimal minimunPayment_ ) 

            {
                _type = type_;
            _debtAmount = debtAmount_;
            _minimumPayment = minimunPayment_;
<<<<<<< HEAD
=======
            if (debtAmount_ <= 0) throw new ArgumentException("Debt amount must be positive .");
            if (intrestRate_ <= 0) throw new ArgumentException("Interest rate cannot be nagative .");
            if (minimunPayment_ <= 0) throw new ArgumentException("Minimum payment must be positive .");
>>>>>>> f2c1ba39e48d60b70e4a04f6179dbe4eddc5147e
            _intrestRate = intrestRate_;
            }


        public string Type 
        {
            get { return _type; }

            set 
            {
                if (!string.IsNullOrWhiteSpace(value))
                _type = value; 
            }
        }
        public decimal DebtAmount
        {
            get { return _debtAmount; }

            set
            {
                if (value > 0)
                {
                    _debtAmount = value;
                }
            }
        }
        public decimal IntrestRate
        {
            get { return _intrestRate; }

            set
            {
                if (value >= 0)
                {
                    _intrestRate = value;
                }
            }
        }
        public decimal MinimumPayment
        {
            get { return _minimumPayment; }

            set
            {
                if (value > 0)
                {
                    _minimumPayment = value;
                }
            }
        }        
    }
}
