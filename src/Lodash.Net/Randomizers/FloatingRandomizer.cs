using Lodash.Net.Randomizers.Abstract;

namespace Lodash.Net.Randomizers
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
