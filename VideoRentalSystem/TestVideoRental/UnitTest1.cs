using System;
using System.Data;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using VideoRentalSystem.Class;

namespace TestVideoRental
{
    [TestClass]
    public class UnitTest1
    {
        //Tests connection by ensuring the GetTable method returns a valid Datatable
        [TestMethod]
        public void TestConnection()
        {
            var myData = new Data();
            DataTable dt = null;

            try
            {
                dt = myData.GetTable("*", "RentalsFriendly");
            }
            catch (Exception)
            {
            }

            Assert.IsNotNull(dt);
        }

        //Tests GetMovie method by ensuring that it returns valid JSOn that can be deserialized to a Movie object.
        [TestMethod]
        public void TestGetMovie()
        {
            var myData = new Data();
            Movie myMovie = null;

            try
            {
                 myMovie = myData.GetJson("The Revenant");
            }
            catch (Exception)
            {
            }

            Assert.IsNotNull(myMovie);
        }
    }
}
