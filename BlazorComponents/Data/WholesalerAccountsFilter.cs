using System;
using System.ComponentModel.DataAnnotations;

namespace BlazorComponents.Data
{
    public class WholesalerAccountsFilter
    {
        public string AccountNumber { get; set; }
        public string Wholesaler { get; set; }
        public string CoveredEntity { get; set; }
        public string Pharmacy { get; set; }
        [Display(Name = "Account Type")]
        public AccountType? AccountType { get; set; }
        public bool? IsDefault { get; set; }
        public bool? IsAutoExported { get; set; }
        public DateTime? NotReceivedSince { get; set; }
        public DateTime? NotExportedSince { get; set; }
    }
}
