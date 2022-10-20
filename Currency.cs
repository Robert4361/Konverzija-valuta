using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Konverzija_valuta
{
    public class Currency
    {
        public double Exchange { get; set; }
        public string Type { get; set; }

        static Dictionary<string, double> Currencies;

        static Currency()
        {
            Currencies = new Dictionary<string, double>();
            Currencies.Add("HRK", 1);
            Currencies.Add("EUR", 7.4);
            Currencies.Add("USD", 6.5);
            Currencies.Add("GBP", 8.4);
            Currencies.Add("CAD", 4.9);

        }
        public Currency(string type)
        {
            Type = type;
            Exchange = Currencies[type];
        }

        internal double ConvertTo(Currency currency, int amount)
        {
            return amount * Exchange / currency.Exchange;
        }
    }
}
