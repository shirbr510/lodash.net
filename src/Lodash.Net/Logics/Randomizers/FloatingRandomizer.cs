using Lodash.Net.Logics.Randomizers.Abstract;

namespace Lodash.Net.Logics.Randomizers
{
    public class FloatingRandomizer : IRandomizer<double>
    {
        private readonly System.Random _random;

        public FloatingRandomizer()
        {
            _random = new System.Random();
        }

        public double Random() => _random.NextDouble();
    }
}
