using System;

namespace Dev201708
{
    /// <summary>
    /// Core implmentation for data retrieval based on file system.
    /// It implements IDataRetrieverDA.
    /// This Class is responsible for implementing IO part to get data from disk
    /// </summary>
    internal class FileBasedRetrieverDA : IDataRetrieverDA
    {
        /// <summary>
        /// Retrieves the file data content based based on filename: dataKey.txt
        /// Files must be located same folder as running routine.
        /// Exceptions - ApplicationException for any issue.
        /// </summary>
        /// <param name="dataKey">filename without extension.</param>
        /// <returns>Text file content.</returns>
        public virtual DataRetrievalResult GetDataBasedOnKey(string dataKey)
        {
            try
            {
                DateTime retrievedOn = DateTime.UtcNow;
                string path = dataKey + ".txt";
                string fileContent = System.IO.File.ReadAllText(path);                
                DataRetrievalResult result = new DataRetrievalResult(dataKey, fileContent, retrievedOn);
                return result;
            }
            catch (Exception ex)
            {
                throw new ApplicationException(string.Format("Error reding file for dataKey: {0}", dataKey), ex);
            }
        }
    }
}
