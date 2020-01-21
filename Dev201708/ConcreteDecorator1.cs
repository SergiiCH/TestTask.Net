using System;
using System.Collections.Generic;
using System.Runtime.Caching;


namespace Dev201708
{
    class ConcreteDecorator1 : Decorator
    {
        DataRetrievalResult result;

        public override DataRetrievalResult GetDataBasedOnKey(string dataKey)
        {

            result = base.GetDataBasedOnKey(dataKey);
            Caching();
            return result;
        }

        void Caching()
        {
            ObjectCache cache = MemoryCache.Default;
            DataRetrievalResult fileContents = cache[result.DataKey] as DataRetrievalResult;

            if (fileContents == null)
            {
                CacheItemPolicy policy = new CacheItemPolicy();
                policy.AbsoluteExpiration = DateTimeOffset.Now.AddMinutes(1);
                List<DataRetrievalResult> filePaths = new List<DataRetrievalResult>();
                filePaths.Add(result);
                cache.Add(result.DataKey, result, policy);
            }
            else
            {
                result = fileContents;
            }
        }
    }
}
