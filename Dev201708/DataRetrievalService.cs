namespace Dev201708
{
    /// <summary>
    /// Generic service for data retrieval based on "key" value. 
    /// This service hides the implementation details and may redirect calls to File / Db or any other implementaion!
    /// </summary>
    public class DataRetrievalService
    {
        /// <summary>
        /// Retrieves data bysed on "key"
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        public static DataRetrievalResult GetMyData(string key)
        {            
            IDataRetrieverDA da = GetImplOfRetriever();

            Decorator decorator1 =new ConcreteDecorator1();
            decorator1.DataRetrieverDA = da;

            return decorator1.GetDataBasedOnKey(key);
        }

        /// <summary>
        /// Retrieves the Interface implementiaion. 
        /// </summary>
        /// <returns></returns>
        private static IDataRetrieverDA GetImplOfRetriever()
        {
            return new FileBasedRetrieverDA();
        }
    }
}
