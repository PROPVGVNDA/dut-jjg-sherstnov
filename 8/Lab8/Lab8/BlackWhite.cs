using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Lab8
{
    internal class BlackWhite : Cellphone
    {
        private static Regex symbolsRange = new Regex("^[]*$");

        protected bool screenDividable = true;

        protected int height;
        protected int width;
        protected Lab8.Color color;
        public BlackWhite(string phoneNumber, int width, int height, Color color) : base(phoneNumber)
        {
            this.color = color;
            this.height = height;
            this.width = width;
        }

        public virtual void ReceiveSMS(string number, string text)
        {
            Console.WriteLine($"SMS from {number}...");
            Console.WriteLine(text);
        }

        public virtual void SendSMS(string number, string text)
        {
            Console.WriteLine($"Sending SMS to {number}.");
        }
    }
    
}
