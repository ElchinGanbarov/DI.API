namespace DI.API.Services
{
    public class TransactionService
    {
        private readonly IAccountNumberClient _accountNumberClient;

        public TransactionService([FromKeyedServices("2")]IAccountNumberClient accountNumberClient)
        {
            _accountNumberClient = accountNumberClient;
        }


        public Guid GetAccountClientNumber()
        {
            return _accountNumberClient.GenerateAccountNumber();
        }
    }
}
