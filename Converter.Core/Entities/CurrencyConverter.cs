using Converter.Core.Entities.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Converter.Core.Entities
{
    public class CurrencyConverter: Entity<int>
    {
        public int FirstCurrencyId { get; set; }
        public int SecondCurrencyId { get; set; }

        public double FirstSum { get; set; }

        public double SecondSum { get; set; }

        public DateTime Data { get; set; }

        public Currency Currency { get; set; }
    }
}
