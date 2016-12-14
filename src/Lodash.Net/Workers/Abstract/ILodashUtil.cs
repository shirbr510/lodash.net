using System;

namespace Lodash.Net.Workers.Abstract
{
    //TODO: implement rest of LodashUtil
    public interface ILodashUtil
    {
        Func<object, object> Property(params string[] path);

        Func<TObject, TProperty> Property<TObject, TProperty>(params string[] path);
    }
}
