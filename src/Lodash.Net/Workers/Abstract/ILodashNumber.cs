namespace Lodash.Net.Workers.Abstract
{
    public interface ILodashNumber
    {
 double Clamp(double number, double lower, double upper);

bool InRange(double number, double start, double upper);

bool InRange(double number, double upper);

double Random(double lower=0,double upper=1, bool floating=false);
    }
}
