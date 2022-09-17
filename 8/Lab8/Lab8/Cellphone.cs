using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Lab8
{
    internal class Cellphone : RotaryDial
    {
        private static Regex symbolsRange = new Regex("^[a-zA-Z0-9*#]*$");
        public Cellphone(string phoneNumber) : base(phoneNumber)
        {

        }

        public override void TakeIncomingCall(string number)
        {
            Console.WriteLine(number + " is calling you...");
        }
    }
}
