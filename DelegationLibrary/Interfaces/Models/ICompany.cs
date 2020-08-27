namespace DelegationLibrary.Model
{
    public interface ICompany
    {
        IAddress Address { get; set; }
        int CompanyID { get; set; }
        string Name { get; set; }
    }
}