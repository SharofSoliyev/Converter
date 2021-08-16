using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Converter.BusinnesLogic.Models
{
   public class CurrencyModel
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public string Ccy { get; set; }
        public string CcyNm_RU { get; set; }
        public string CcyNm_UZ { get; set; }
        public string CcyNm_UZC { get; set; }
        public string CcyNm_EN { get; set; }
        public int Nominal { get; set; }
        public double Rate { get; set; }
        public float Diff { get; set; }
        public string Date { get; set; }
    }
}
