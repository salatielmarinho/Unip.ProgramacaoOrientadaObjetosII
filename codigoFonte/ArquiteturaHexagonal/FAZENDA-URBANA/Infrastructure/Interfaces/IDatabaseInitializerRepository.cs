namespace Infrastructure.Interfaces
{
    public interface IDatabaseInitializerRepository
    {
        void ExecuteNonQuery(string commandText);
    }
}