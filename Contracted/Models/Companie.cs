namespace Contracted.Models
{
    public class Company
    {
        public int Id { get; set; }
        public int Name { get; set; }
    }

    public class CompanieContractorViewModel : Company
    {
        public int ContractCompanieId { get; set; }
    }
}