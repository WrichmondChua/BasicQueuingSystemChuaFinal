using System;
using System.Collections.Generic;
using System.Text;

namespace BasicQueuingSystemChuaFinal
{
    class CashierClass
    {
        private int x;
        public static string getNumberInQueue = "";
        public static Queue<string> CashierQueue;

        public CashierClass()
        {
            x = 1000;
            CashierQueue = new Queue<string>();

        }
        public string CashierGeneratedNumber(string CashierNumber)
        {
            x++;
            CashierNumber = CashierNumber + x.ToString();
            return CashierNumber;
        }
    }

}
