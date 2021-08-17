using Converter.Core.Entities.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Converter.Core.Entities
{
    public class CurrencyConverter: EntityBase
    {
        public string FirstCurrency { get; set; }
        public string SecondCurrency { get; set; }
        public double FirstSum { get; set; }
        public double SecondSum { get; set; }
        public string Date { get; set; }



    }
}
