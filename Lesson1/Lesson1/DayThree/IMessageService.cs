using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson1.DayThree
{
    internal interface IMessageService
    {
        void SendMessage(string message);
        void SendAudioMessage(string message);
        void SendVideoMessage(string message);
        void RecieveMessage();
        void DeleteMessage();

    }
    public interface IPayments 
    {
        void Makepayment(float amount);
    }
    internal class WhatsApp : IMessageService, IPayments 
    {
        public void DeleteMessage() 
        {
            Console.WriteLine("Message Deleted");
        }
        public void Makepayment(float amount)
        {
            Console.WriteLine($"Paid Amount{amount}");
        }
        public void RecieveMessage()
        {
            Console.WriteLine("Method Not Implement");
        }
        public void SendAudioMessage(string message) 
        {
            Console.WriteLine("Method Not Implemented");
        }
        public void SendMessage(string message) 
        {
            Console.WriteLine("Method Not Implemented");
        }
        //public abstract void SendVideoMessage
        public void SendVideoMessage(string message)
        {
            Console.WriteLine("Method Not Implemented");
        }
    }
    // End of Class
    public class MessageTester
    {
        public void TestOne()
        {
            IMessageService messageService = new WhatsApp();
            messageService.SendMessage("Hello");
            messageService.RecieveMessage();
        }
        public void TestTwo()
        {

        }
    }
}
