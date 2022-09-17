using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Lab8
{
    internal class RotaryDial
    {
        protected string phoneNumber;
        private static Regex symbolsRange = new Regex(@"^[a-zA-Z0-9]*$");

        public RotaryDial(string phoneNumber)
        {
            this.phoneNumber = phoneNumber;
        }

        public virtual void TakeIncomingCall(string number)
        {

        }

        public virtual void Call(string number)
        {
            Console.WriteLine($"Calling {number}...");
        }
    }
}
