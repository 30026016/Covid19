using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Covid19.Models
{
    public class CountryWiseTotalCasesByDay
    {
        public long CaseId { get; set; }
        public string ContryName { get; set; }
        public Nullable<int> Day { get; set; }
        public Nullable<long> TotalCases { get; set; }
    }
}