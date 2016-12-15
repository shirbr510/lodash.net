using Lodash.Net.Methods.Abstract;

namespace Lodash.Net.Data.Instance.Abstract
{
    public interface ILodashInstance :
        ILodashArray, ILodashCollection, ILodashDate, ILodashFunction, ILodashLang, ILodashMath, ILodashMethods,
        ILodashNumber, ILodashObject, ILodashProperties, ILodashSeq, ILodashString, ILodashUtil
    {
    }
}