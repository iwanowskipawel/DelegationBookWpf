namespace DelegationLibrary.Model
{
    public interface IAddress
    {
        int AddressID { get; set; }
        string City { get; set; }
        string Number { get; set; }
        string PostalCode { get; set; }
        string Street { get; set; }
    }
}