namespace Lodash.Net.Logics.Randomizers.Abstract
{
    public interface IRandomizer<out T>
    {
        T Random();
    }
}
