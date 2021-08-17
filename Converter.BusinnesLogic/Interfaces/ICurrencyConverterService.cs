using Converter.BusinnesLogic.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Converter.BusinnesLogic.Interfaces
{
    public interface ICurrencyConverterService
    {
        public List<ConverterModel> ConverterModels();
        public void AddConverterData(ConverterModel currencyModel);
    }
}
