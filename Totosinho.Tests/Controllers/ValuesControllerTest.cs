using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Web.Http;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Totosinho;
using Totosinho.Controllers;
using Totosinho.Models;

namespace Totosinho.Tests.Controllers
{
    [TestClass]
    public class ValuesControllerTest
    {
   
        [TestMethod]
        public void Post()
        {
            // Arrange
            ScoreController controller = new ScoreController();

            // Act
            controller.Post(new ScoreViewModel());

            // Assert
        }
    }
}
