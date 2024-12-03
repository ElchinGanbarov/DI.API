
namespace DI.API.Services
{
    public class DefaultAccountNumber : IAccountNumberClient
    {
        public Guid GenerateAccountNumber()
        {
            return Guid.Parse("1f7e68f7-6a79-4dab-827f-dbf7567a1ce8");
        }
    }
}
