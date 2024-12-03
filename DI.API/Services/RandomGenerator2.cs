namespace DI.API.Services
{
    public class RandomGenerator2 : IRandomGenerator2
    {
        private readonly IRandomGenerator _randomGenerator;
        public RandomGenerator2(IRandomGenerator randomGenerator)
        {
            _randomGenerator = randomGenerator;
        }


        public int GenerateRandom1Value()
        {
            return _randomGenerator.RandomValue;
        }
    }
}
