namespace Dev201708
{
    /// <summary>
    /// Interface defining file retrieval API
    /// </summary>
    internal interface IDataRetrieverDA
    {
         DataRetrievalResult GetDataBasedOnKey(string dataKey);        
    }
}
