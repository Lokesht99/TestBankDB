//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TestBank.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class LoanAccountDetail
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public LoanAccountDetail()
        {
            this.LoanEMIDetails = new HashSet<LoanEMIDetail>();
        }
    
        public int AccNum { get; set; }
        public string IFSCcode { get; set; }
        public Nullable<decimal> BalanceAmount { get; set; }
        public Nullable<int> BranchCode { get; set; }
        public decimal Principle { get; set; }
        public decimal RateOfInterest { get; set; }
        public int LoanDuration { get; set; }
        public decimal TotalLoanAmount { get; set; }
        public decimal MonthlyPayment { get; set; }
        public string LoanAccountType { get; set; }
        public Nullable<System.DateTime> LoanIssuedDate { get; set; }
        public Nullable<System.DateTime> LoanPayDate { get; set; }
    
        public virtual CustomerAccount CustomerAccount { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LoanEMIDetail> LoanEMIDetails { get; set; }
    }
}
