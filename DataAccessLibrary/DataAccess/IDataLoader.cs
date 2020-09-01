namespace DelegationLibrary.DataAccess
{
    public interface IDataLoader
    {
        IDataCollection Load();
        bool Save(IDataCollection collection);

    }
}