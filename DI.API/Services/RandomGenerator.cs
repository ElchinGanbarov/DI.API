namespace DI.API.Services
{
    public class RandomGenerator : IRandomGenerator
    {
        public RandomGenerator()
        {
            RandomValue = new Random().Next(1000);
        }
        public int RandomValue { get; init; }


       /// <summary>
       /// Deconstruct operation
       /// </summary>
       /// <param name="s"></param>
       /// <param name="Item2"></param>
        internal void Deconstruct(out object s, out object Item2)
        {
            s = this.RandomValue;
            Item2 = this.RandomValue;
        }
    }
}
