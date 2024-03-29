using Microsoft.VisualStudio.TestTools.UnitTesting;
using HairSalon.Models;
using System.Collections.Generic;
using System;

namespace HairSalon.Tests
{
  [TestClass]
  public class StylistTest : IDisposable
  {

    public void Dispose()
    {
      Stylist.ClearAll();
    }

    [TestMethod]
    public void StylistConstructor_CreatesInstanceOfStylist_Stylist()
    {
      Stylist newStylist = new Stylist("Rebecca Cuts");
      Assert.AreEqual(typeof(Stylist), newStylist.GetType());
    }

    [TestMethod]
    public void GetName_ReturnsName_String()
    {
      //Arrange
      string name = "Rebecca Cuts";
      Stylist newStylist = new Stylist(name);

      //Act
      string result = newStylist.Name;

      //Assert
      Assert.AreEqual(name, result);
    }

    [TestMethod]
    public void GetId_ReturnsStylistId_Int()
    {
      //Arrange
      string name = "Rebecca Cuts";
      Stylist newStylist = new Stylist(name);

      //Act
      int result = newStylist.Id;

      //Assert
      Assert.AreEqual(1, result);
    }

    [TestMethod]
    public void GetAll_ReturnsAllStylistObjects_StylistList()
    {
      //Arrange
      string name01 = "Rebecca Cuts";
      string name02 = "Tina Trims";
      Stylist newStylist1 = new Stylist(name01);
      Stylist newStylist2 = new Stylist(name02);
      List<Stylist> newList = new List<Stylist> { newStylist1, newStylist2 };

      //Act
      List<Stylist> result = Stylist.GetAll();

      //Assert
      CollectionAssert.AreEqual(newList, result);
    }

    [TestMethod]
    public void Find_ReturnsCorrectStylist_Stylist()
    {
      //Arrange
      string name01 = "Rebecca Cuts";
      string name02 = "Tina Trims";
      Stylist newStylist1 = new Stylist(name01);
      Stylist newStylist2 = new Stylist(name02);

      //Act
      Stylist result = Stylist.Find(2);

      //Assert
      Assert.AreEqual(newStylist2, result);
    }
    [TestMethod]
    public void AddClient_AssociatesClientWithStylist_ClientList()
    {
      //Arrange
      string description = "Nancy Needahaircut";
      Client newClient = new Client(description);
      List<Client> newList = new List<Client> { newClient };
      string name = "Rebecca Cuts";
      Stylist newStylist = new Stylist(name);
      newStylist.AddClient(newClient);

      //Act
      List<Client> result = newStylist.Clients;

      //Assert
      CollectionAssert.AreEqual(newList, result);
    }
  }
}