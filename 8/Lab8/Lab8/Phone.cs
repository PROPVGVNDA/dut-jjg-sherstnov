using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Lab8
{
    internal class Phone : BlackWhite
    {
        private static Regex symbolsRange = new Regex("^[]*$");

        protected int colorNumber;
        protected string secondPhoneNumber;
        private string numberInUse;
        public Phone(string phoneNumber, int width, int height, Color color, int colorNumber, string secondPhoneNumber) : base(phoneNumber, width, height, color)
        {
            this.colorNumber = colorNumber;
            this.secondPhoneNumber = secondPhoneNumber;
            this.numberInUse = phoneNumber;
        }

        public override void TakeIncomingCall(string number)
        {
            Console.WriteLine(number + " is calling you...");
            Console.WriteLine($"Number used: {numberInUse}");
        }

        public override void Call(string number)
        {
            Console.WriteLine($"Calling {number}");
            Console.WriteLine($"Number used: {numberInUse}");
        }
        public override void ReceiveSMS(string number, string text)
        {
            Console.WriteLine($"Number used: {numberInUse}");
            Console.WriteLine($"SMS from {number}...");
            Console.WriteLine(text);
        }

        public override void SendSMS(string number, string text)
        {
            Console.WriteLine($"Sending SMS to {number}.");
            Console.WriteLine($"Number used: {numberInUse}");
        }

        public virtual void SendMMS(string number, string media)
        {
            Console.WriteLine($"Sending MMS to {number}.");
            Console.WriteLine($"Number used: {numberInUse}");
        }
        public virtual void ReceiveMMS(string number, string media)
        {
            Console.WriteLine($"Number used: {numberInUse}");
            Console.WriteLine($"MMS from {number}...");
            Console.WriteLine(media);
        }
        public virtual void SwitchNumber(ushort sim)
        {
            if (sim == 1) numberInUse = phoneNumber;
            else if (sim == 2) numberInUse = secondPhoneNumber;
        }
    }
}
