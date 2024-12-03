namespace DI.API.Services
{
    public record struct  SimpleRecord(string a, string b)
    {

        public  string  a { get; init; } =  a != string.Empty ? throw new ArgumentException(""): a;
        public SimpleRecord() : this(string.Empty,"a")
        {

        }
    }
}
