using DI.API.Services;
using Microsoft.AspNetCore.Mvc;
using System.Net.WebSockets;

namespace DI.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class SomeController : ControllerBase
    {
        private readonly AccountService _accountservice;

        private readonly TransactionService _transatcionservice;


        public SomeController(AccountService accountService, 
                              TransactionService transatcionservice)
        {
            _accountservice = accountService;
            _transatcionservice = transatcionservice;

        }


        [HttpGet]
        public IActionResult Get()
        {
            var accountNumber = _accountservice.GetAccountClientNumber();

            var transactionAccountNumber = _transatcionservice.GetAccountClientNumber();

            return Ok($"{accountNumber};  {transactionAccountNumber}");
        }

        private bool Test(string obj)
        {


            RandomGenerator randomGenerator = new RandomGenerator();


            var original = new MyClass("Value1", 42);
            var modified = original with { Property1 = "New Value" };




            var (s,_) = randomGenerator;

            return obj == "Elchin";


            
        }



    }

    public record MyClass(string Property1, int Property2);

}
