using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab17
{
    class Program
    {
        static void Main(string[] args)
        {
            BankAccount<int> bankAccount1 = new BankAccount<int>();
            bankAccount1.InfoAccountNumber = 123456789;
            bankAccount1.InfoBalans = 30000;
            bankAccount1.InfoName = "Иванов И.И.";
            Console.WriteLine("Номер счета: " + bankAccount1.InfoAccountNumber);
            Console.WriteLine("Баланс: " + bankAccount1.InfoBalans);
            Console.WriteLine("ФИО: " + bankAccount1.InfoName);
            Console.WriteLine();
            BankAccount<char>bankAccount2 = new BankAccount<char>();
            bankAccount2.InfoAccountNumber ='U';
            bankAccount2.InfoBalans = 70000;
            bankAccount2.InfoName = "Петров П.П.";
            Console.WriteLine("Номер счета: " + bankAccount2.InfoAccountNumber);
            Console.WriteLine("Баланс: " + bankAccount2.InfoBalans);
            Console.WriteLine("ФИО: " + bankAccount2.InfoName);
            Console.WriteLine();
            BankAccount<string> bankAccount3 = new BankAccount<string>();
            bankAccount3.InfoAccountNumber = "PU123456";
            bankAccount3.InfoBalans = 170000;
            bankAccount3.InfoName = "Сидоров С.С.";
            Console.WriteLine("Номер счета: " + bankAccount3.InfoAccountNumber);
            Console.WriteLine("Баланс: " + bankAccount3.InfoBalans);
            Console.WriteLine("ФИО: " + bankAccount3.InfoName);
            Console.ReadKey();
        }
    }
    class BankAccount<T>
    {
        private T AccountNumber;
        private decimal Balanse;
        private string Name;
        public T InfoAccountNumber 
        {
            get
            {
                return AccountNumber;
            }
            set 
            {
                AccountNumber = value;
            }
            
        }
        public decimal InfoBalans
        {
            get 
            {
                return Balanse;
            }
            set 
            {
                Balanse = value;
            }
        }
        public string InfoName 
        {
            get 
            {
                return Name;
            }
            set 
            {
                Name = value;
            }
        }

        
     }
}
        


