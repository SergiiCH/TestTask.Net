

namespace Dev201708
{
    abstract class Decorator : AbstractDataRetriever
    {
        public IDataRetrieverDA DataRetrieverDA { protected get; set; }

        public override  DataRetrievalResult GetDataBasedOnKey(string dataKey)
        {
           return DataRetrieverDA.GetDataBasedOnKey(dataKey);
        }

    }
}
