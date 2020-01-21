
namespace Dev201708
{
    abstract class AbstractDataRetriever : IDataRetrieverDA
    {
        public abstract DataRetrievalResult GetDataBasedOnKey(string dataKey);
        
    }
}
