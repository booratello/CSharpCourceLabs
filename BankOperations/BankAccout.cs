using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace BankOperations
{
    internal class BankAccout
    {
        public string Owner { get; }
        public decimal Balance { get; private set; }

        private string Currency;

        public BankAccout(string owner, decimal startBalance)
        {
            this.Owner = owner;
            this.Balance = startBalance;
            this.Currency = "parrots";
        }

        public void Deposite(decimal summa)
        {
            if (summa > 0) Balance += summa;
        }

        public bool Withdraw(decimal summa)
        {
            if (summa > 0 && summa <= Balance)
            {
                Balance -= summa;
                return true;
            }
            else return false;
        }

        public static bool Transfer(BankAccout source, BankAccout dest, decimal summa)
        {
            if (source.Withdraw(summa))
            {
                dest.Deposite(summa);
                return true;
            }
            else return false;
        }

        public override string ToString()
        {
            return $"{Owner}: {Balance} {Currency}";
        }
    }
}
