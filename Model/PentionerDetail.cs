using System;
namespace PentionerDetailMicroservice.Model
{
    public class PentionerDetail
    {
        public string Name { get; set; }
        public DateTime Dateofbirth { get; set; }
        public string Pan { get; set; }
        public int SalaryEarned { get; set; }
        public int Allowances { get; set; }
        public string AadharNumber { get; set; }
        public PensionTypeValue PensionType { get; set; }
        public string BankName { get; set; }
        public string AccountNumber { get; set; }
        public BankType BankType { get; set; }


    }

    public enum PensionTypeValue
    {
        Self,
        Family
    }
    public enum BankType
    {
        Public,
        Private
    }
}
