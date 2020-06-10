using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Covid19.Models
{
    public class CountryWiseCases
    {
        public int CountryId { get; set; }
        public string ContryName { get; set; }
        public Nullable<decimal> TotalCasesPercentage { get; set; }
        public Nullable<long> TotalCases { get; set; }
    }
}