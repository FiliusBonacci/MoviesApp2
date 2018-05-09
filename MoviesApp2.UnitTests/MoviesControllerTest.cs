using System;
using System.Web.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MoviesApp2.Controllers;

namespace MoviesApp2.UnitTests
{
    [TestClass]
    public class MoviesControllerTest
    {
        [TestMethod]
        public void TestIndexMethod()
        {
            // Arrange
            var controller = new MoviesController();
            // Act
            var result = controller.Index() as ViewResult;
            // Assert
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void TestDetailsViewData()
        {
            var controller = new MoviesController();
            var result = controller.Details(1) as ViewResult;
            var movie = (MoviesApp2.Models.Movie)result.ViewData.Model;
            Console.WriteLine(movie);
            Assert.AreEqual("Laptop", movie.Title);
        }
    }
}
