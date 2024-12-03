namespace DI.API.Services
{
    public class AccountService
    {
        private readonly IAccountNumberClient _accountNumberClient;
        public AccountService([FromKeyedServices("1")]IAccountNumberClient accountNumberClient)
        {
            _accountNumberClient = accountNumberClient;
        }

        public Guid GetAccountClientNumber()
        {
            return _accountNumberClient.GenerateAccountNumber();
        }
    }
}
