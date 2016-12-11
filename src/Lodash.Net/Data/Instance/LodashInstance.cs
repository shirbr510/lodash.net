using Lodash.Net.Data.Instance.Abstract;
using Lodash.Net.Workers;
using Lodash.Net.Workers.Abstract;

namespace Lodash.Net.Data.Instance
{
    public class LodashInstance : ILodashInstance
    {
        private readonly ILodashDate _lodashDate;

        public LodashInstance()
        {
            _lodashDate = new LodashDate();
        }

        public long Now() => _lodashDate.Now();
    }
}
