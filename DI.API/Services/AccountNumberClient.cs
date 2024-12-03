namespace DI.API.Services
{
    public class AccountNumberClient : IAccountNumberClient
    {
        private readonly Guid _guid;
        public AccountNumberClient()
        {
            _guid = Guid.NewGuid();
        }

        public Guid GenerateAccountNumber()
        {
            return _guid;
        }
    }
}
