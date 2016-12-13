using System;

namespace Lodash.Net.Workers.Abstract
{
    public interface ILodashNumber
    {
        T Clamp<T>(T number, T lower, T upper) where T : IComparable<T>;

        bool InRange<T>(T number, T start, T upper) where T : IComparable<T>;

        bool InRange<T>(T number, T upper) where T : IComparable<T>;

        double Random(double upper);

        double Random(double lower, double upper);

        double Random(double upper, bool floating);

        double Random(double lower, double upper, bool floating);
    }
}
