namespace Lodash.Net.Randomizers.Abstract
{
    public interface IRandomizer<out T>
    {
        T Random();
    }
}
