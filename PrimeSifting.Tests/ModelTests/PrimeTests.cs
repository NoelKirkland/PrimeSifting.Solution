using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using PrimeSifting.Models;

namespace PrimeSifting.Tests
{
  [TestClass]

  public class PrimeSiftingTest
  {

    [TestMethod]

    public void PrimeConstructor_CreatesInstanceOfPrime_Prime()
    {
      Prime newPrime = new Prime(5);
      Assert.AreEqual(typeof(Prime), newPrime.GetType());
    }

    [TestMethod]

    public void Prime_AssignsNumber_Number()
    {
      int newNumber = 5;
      Prime newPrime = new Prime(newNumber);
      int result = newPrime.Numbers;
      Assert.AreEqual(newNumber, result);
    }



  }
}
// public void NameOfMethodWeAreTesting_DescriptionOfBehavior_ExpectedReturnValue()