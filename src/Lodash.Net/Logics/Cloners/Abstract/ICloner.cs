namespace Lodash.Net.Logics.Cloners.Abstract
{
    public interface ICloner
    {
        object Clone(object source);

        T Clone<T>(T source);
    }
}
