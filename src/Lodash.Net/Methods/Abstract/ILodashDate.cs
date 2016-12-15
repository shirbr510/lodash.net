namespace Lodash.Net.Methods.Abstract
{
    public interface ILodashDate
    {
        /// <summary>
        /// Gets the timestamp of the number of milliseconds that have elapsed since the Unix epoch (1 January 1970 00:00:00 UTC).
        /// </summary>
        /// <since>2.4.0</since>
        /// <returns>Returns the timestamp.</returns>
        long Now();
    }
}
