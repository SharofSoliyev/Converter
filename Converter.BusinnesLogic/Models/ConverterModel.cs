using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Converter.BusinnesLogic.Models
{
   public class ConverterModel
    {
        public string FirstCurrency { get; set; }
        public string SecondCurrency { get; set; }
        public double FirstSum { get; set; }
        public double SecondSum { get; set; }
        public DateTime Date { get; set; }

    }
}
