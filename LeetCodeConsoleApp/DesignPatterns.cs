using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeConsoleApp
{
    internal class DesignPatterns
    {
        //Fix this and make it extendable
        public void ProcessPayment(string type)
        {
            if (type == "CreditCard")
            {
                Console.WriteLine("Processing credit card payment");
            }
            else if (type == "PayPal")
            {
                Console.WriteLine("Processing PayPal payment");
            }
            else
            {
                Console.WriteLine("Invalid payment type");
            }
        }
    }

    public interface IPaymentProcessor
    {
        void ProcessPayment();
    }


    public class ProcessPaymentImproved
    {

        IPaymentProcessor paymentProcessor;

        public ProcessPaymentImproved(IPaymentProcessor paymentProcessor) {
            this.paymentProcessor = paymentProcessor;
        }
        public void ProcessPayment()
        {
            paymentProcessor.ProcessPayment();
        }

    }




    public class CreditCardPayment : IPaymentProcessor
    {
        public IPaymentProcessor paymentProcessor;

        public void ProcessPayment()
        {
            Console.WriteLine("CREDIT CARD BRO!!");
        
        }


    }



    public class PaypalPayment : IPaymentProcessor
    {
        public void ProcessPayment()
        {
            Console.WriteLine("PAYPAL PAYMENT!!!");
        }
    }

    
}
