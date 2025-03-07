using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Charp_Pro_HomeWork4_3
{
    internal class CreditСard
    {
        private int CVC { get; set; }
        public int accountBalance { get; set; }

        public CreditСard(int cvc, int accountBalance)
        {
            this.CVC = cvc;
            this.accountBalance = accountBalance;
        }

        public static CreditСard operator +(CreditСard a, int b)
        {
            return new CreditСard(a.CVC, a.accountBalance + b);
        }
        public static CreditСard operator -(CreditСard a, int b)
        {
            return new CreditСard(a.CVC, a.accountBalance - b);
        }
        public static bool operator ==(CreditСard balance1, CreditСard balance2)
        {
            return balance1.CVC == balance2.CVC;
        }
        public static bool operator !=(CreditСard balance1, CreditСard balance2)
        {
            return balance1.CVC != balance2.CVC;
        }
        public static bool operator >(CreditСard balance1, CreditСard balance2)
        {
            return balance1.accountBalance > balance2.accountBalance;
        }
        public static bool operator <(CreditСard balance1, CreditСard balance2)
        {
            return balance1.accountBalance < balance2.accountBalance;
        }
    }
}
