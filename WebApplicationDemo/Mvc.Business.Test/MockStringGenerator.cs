using Mvc.Business.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Mvc.Business.Test
{
    public class MockStringGenerator : IStringGenerator
    {
        public string Format(string number)
        {
            switch (number)
            {
                case "45":
                    return "FOURTY FIVE DOLLARS";
                case "545.52":
                    return "FIVE HUNDRED FOURTY FIVE DOLLARS AND FIVE TWO CENTS";
                case "1.1":
                    return "ONE DOLLAR AND ONE CENT";
                case "-2.45":
                    return "MINUS TWO DOLLARS AND FOUR FIVE CENTS";
                case "0":
                    return "The number in currency fomat is \nZero Only".ToUpper();
                case "1":
                    return "ONE DOLLAR";
                case "0.1":
                    return "ONE CENT";
                case "0.25":
                    return "TWO FIVE CENTS";
                case "-0.25":
                    return "MINUS TWO FIVE CENTS";
                case "100000.25":
                    return "ONE HUNDRED THOUSAND DOLLARS AND TWO FIVE CENTS";
                case "10000000":
                    return "TEN MILLION DOLLARS";
                case "-33333":
                    return "MINUS THIRTY THREE THOUSAND THREE HUNDRED THIRTY THREE DOLLARS";
                default:
                    break;
            }

            return string.Empty;
            //throw new NotImplementedException();
        }
    }
}
