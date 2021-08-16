using Converter.Core.Entities.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Converter.Core.Entities
{
    public class Currency : Entity<int>
    {
        public string  Code { get; set; }
        public string Ccy { get; set; }
        public string CcyNm_RU { get; set; }
        public string CcyNm_UZ { get; set; }
        public string CcyNm_UZC { get; set; }
        public string CcyNm_EN { get; set; }
        public int Nominal { get; set; }
        public double Rate { get; set; }
        public float Diff { get; set; }
        public DataType Date { get; set; }
    }
}