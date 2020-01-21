using NUnit.Framework;


namespace Dev201708.Test
{
    [TestFixture]
    public class DataRetrievalServiceTest
    {
        [Test]
        public void GetDataBasedOnKnownKeyShouldBeOK()
        {
            DataRetrievalResult res = DataRetrievalService.GetMyData("DataFile1");
            Assert.IsNotNull(res, string.Format("retrieving file should not end up in null!"));
        }

        [Test]
        public void GetKeyTwiceInDifferentTimeShouldNotHaveSameRetrievedOn()
        {
            DataRetrievalResult res1 = DataRetrievalService.GetMyData("DataFile1");
            DataRetrievalResult res2 = DataRetrievalService.GetMyData("DataFile1");
            Assert.IsTrue(res1.RetrievedOn != res2.RetrievedOn,
                string.Format("RetrievedOn1={0} AND RetrievedOn2={1} should not be same!", res1.RetrievedOn,
                    res2.RetrievedOn));
        }

        [Test]
        public void GetKeyTwiceInDifferentTimeShouldHaveSameRetrievedOn()
        {
            DataRetrievalResult res1 = DataRetrievalService.GetMyData("DataFile1");
            DataRetrievalResult res2 = DataRetrievalService.GetMyData("DataFile1");
            Assert.IsTrue(res1.RetrievedOn == res2.RetrievedOn,
                string.Format("RetrievedOn1={0} AND RetrievedOn2={1} should be same!", res1.RetrievedOn,
                    res2.RetrievedOn));
        }

    }
}
