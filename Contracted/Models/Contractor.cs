namespace Contracted.Models
{
    public class Contractor
    {
        public int Id { get; set; }
        public int Name { get; set; }
    }

    public class ContractorCompanieViewModel : Contractor
    {
        public int ContractCompanieId { get; set; }
    }
}