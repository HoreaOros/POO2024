using System;
using ACM.BL;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ACM.BLTest
{
  [TestClass]
  public class CustomerRepositoryTest
  {
    [TestMethod]
    public void RetrieveValid()
    {
      //-- Arrange
      var customerRepository = new CustomerRepository();
      var expected = new Customer(1)
      {
        EmailAddress = "fbaggins@hobbiton.me",
        FirstName = "Frodo",
        LastName = "Baggins"
      };

      //-- Act
      var actual = customerRepository.Retrieve(1);

      //-- Assert
      Assert.AreEqual(expected.CustomerId, actual.CustomerId);
      Assert.AreEqual(expected.EmailAddress, actual.EmailAddress);
      Assert.AreEqual(expected.FirstName, actual.FirstName);
      Assert.AreEqual(expected.LastName, actual.LastName);
    }
  }
}
