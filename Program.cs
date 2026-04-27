using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaymentSystem
{
  
    // Base Class (Abstraction + Polymorphism)
   
    class Payment
    {
        // Virtual method 
        public virtual void ProcessPayment()
        {
            Console.WriteLine("Processing generic payment...");
        }

        
        // Overloading (Polymorphism)
        

        // Method 1
        public void Pay(double amount)
        {
            Console.WriteLine($"Paying {amount}");
        }

        // Method 2 (Overloaded)
        public void Pay(double amount, string currency)
        {
            Console.WriteLine($"Paying {amount} {currency}");
        }
    }

    
    // Derived Class: Cash
    
    class Cash : Payment
    {
        // Override method
        public override void ProcessPayment()
        {
            Console.WriteLine("Processing cash payment...");
        }
    }

    
    // Derived Class: Credit Card
   
    class CreditCard : Payment
    {
        private int securityCode;

        // Constructor 
        public CreditCard(int code)
        {
            securityCode = code;
        }

        // Override method
        public override void ProcessPayment()
        {
            Console.WriteLine("Processing credit card payment...");
            Console.WriteLine($"Security Code: {securityCode}");
        }
    }

    
    class Program
    {
        static void Main(string[] args)
        {
            
            // Cash Payment
            Payment cash = new Cash();
            cash.ProcessPayment();   // Polymorphism
            cash.Pay(100);           // Overloading
            cash.Pay(100, "USD");

            Console.WriteLine("------------------");

            // Credit Card Payment
            Payment card = new CreditCard(567);
            card.ProcessPayment();   // Polymorphism
            card.Pay(700);
            card.Pay(700, "JOD");
        }
    }
}
        