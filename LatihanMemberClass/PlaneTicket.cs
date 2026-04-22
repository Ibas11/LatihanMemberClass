using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LatihanMemberClass
{
    internal class PlaneTicket
    {
        private string _Origin;
        private string _Destination;
        private int _Cost;
        private string _Currency;

        public string Origin
        {
            get { return _Origin; }
            set { _Origin = value; }
        }

        public string Destination
        {
            get { return _Destination; }
            set { _Destination = value; }
        }

        public int Cost
        {
            get { return _Cost; }
            set { _Cost = value; }
        }

        public string Currency
        {
            get { return _Currency; }
            set { _Currency = value; }
        }


        public void PrintSummary()
        {
            Console.WriteLine("Origin: {0}", _Origin);
            Console.WriteLine("Destination: {0}", _Destination);
            Console.WriteLine("Cost: {0} ({1})", _Cost, _Currency);

            if (_Currency == "USD")
            {
                int convertToRupiah = _Cost * 15000;
                Console.WriteLine("Convert to Rupiah: {0}", convertToRupiah);
            }
            else if (_Currency == "IDR")
            {
                int convertToDolar = _Cost / 15000;
                Console.WriteLine("Convert to Dolar: {0}", convertToDolar);
            }
            Console.WriteLine();
        }
    }
}
