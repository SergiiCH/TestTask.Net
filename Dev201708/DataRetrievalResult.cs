using System;
using System.Xml.Serialization;

namespace Dev201708
{

    /// <summary>
    /// Data Retrieval Result object. 
    /// </summary>
    [XmlRoot("DataRetrievalResult")]
    public class DataRetrievalResult
    {
        [XmlElement("Content")]
        public string DataKey { get; private set; }

        [XmlElement("SerialID")]
        public string Content { get; private set; }

        [XmlElement("RetrievedOn")]
        public DateTime RetrievedOn { get; private set; }

        /// <summary>
        /// Constructor for result object.
        /// </summary>
        /// <param name="dataKey">Data key name.</param>
        /// <param name="content">Data content value.</param>
        /// <param name="retrievedOn">Time of data retrieval.</param>
        public DataRetrievalResult(string dataKey, string content, DateTime retrievedOn)
        {
            if(content == null)
                throw new ArgumentNullException("dataKey");
            if (content == null)
                throw new ArgumentNullException("content");

            DataKey = dataKey;
            Content = content;
            RetrievedOn = retrievedOn;
        }
    }
}
