using Converter.BusinnesLogic.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Converter.View.ViewModels
{
    public class HomeIndexViewModel
    {
        public IEnumerable<CurrencyModel> CurrencyModels { get; set; }
        public List<ConverterModel> ConverterModels { get; set; }
    }
}
