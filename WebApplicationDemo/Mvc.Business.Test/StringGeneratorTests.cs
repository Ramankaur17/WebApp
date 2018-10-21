using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Mvc.Business.Interface;

namespace Mvc.Business.Test
{
    /// <summary>
    /// Summary description for StringGeneratorTests
    /// </summary>
    [TestClass]
    public class StringGeneratorTests
    {
        IStringGenerator strGen;
        public StringGeneratorTests()
        {
            strGen = new StringGenerator();
            //TDD approach
            //strGen = new MockStringGenerator();
        }

        [TestMethod]
        public void TestMethod1()
        {
           //Arrange

            //Act
            var result = this.strGen.Format("45");

            //Assert
            Assert.AreEqual("FOURTY FIVE DOLLARS", result);
        }

        [TestMethod]
        public void TestMethod2()
        {
            //Arrange

            //Act
            var result = this.strGen.Format("545.52");

            //Assert
            Assert.AreEqual("FIVE HUNDRED FOURTY FIVE DOLLARS AND FIVE TWO CENTS", result);
        }

        [TestMethod]
        public void TestMethod3()
        {
            //Arrange

            //Act
            var result = this.strGen.Format("1.1");

            //Assert
            Assert.AreEqual("ONE DOLLAR AND ONE CENT", result);
        }

        [TestMethod]
        public void TestMethod4()
        {
            //Arrange

            //Act
            var result = this.strGen.Format("-2.45");

            //Assert
            Assert.AreEqual("MINUS TWO DOLLARS AND FOUR FIVE CENTS", result);
        }

        [TestMethod]
        public void TestMethod5()
        {
            //Arrange

            //Act
            var result = this.strGen.Format("0");

            //Assert
            Assert.AreEqual("The number in currency fomat is \nZero Only".ToUpper(), result);
        }

        [TestMethod]
        public void TestMethod6()
        {
            //Arrange

            //Act
            var result = this.strGen.Format("1");

            //Assert
            Assert.AreEqual("ONE DOLLAR", result);
        }

        [TestMethod]
        public void TestMethod7()
        {
            //Arrange

            //Act
            var result = this.strGen.Format("0.1");

            //Assert
            Assert.AreEqual("ONE CENT", result);
        }

        [TestMethod]
        public void TestMethod8()
        {
            //Arrange

            //Act
            var result = this.strGen.Format("0.25");

            //Assert
            Assert.AreEqual("TWO FIVE CENTS", result);
        }

        [TestMethod]
        public void TestMethod9()
        {
            //Arrange

            //Act
            var result = this.strGen.Format("-0.25");

            //Assert
            Assert.AreEqual("MINUS TWO FIVE CENTS", result);
        }

        [TestMethod]
        public void TestMethod10()
        {
            //Arrange

            //Act
            var result = this.strGen.Format("100000.25");

            //Assert
            Assert.AreEqual("ONE HUNDRED THOUSAND DOLLARS AND TWO FIVE CENTS", result);
        }

        [TestMethod]
        public void TestMethod11()
        {
            //Arrange

            //Act
            var result = this.strGen.Format("10000000");

            //Assert
            Assert.AreEqual("TEN MILLION DOLLARS", result);
        }

        [TestMethod]
        public void TestMethod12()
        {
            //Arrange

            //Act
            var result = this.strGen.Format("-33333");

            //Assert
            Assert.AreEqual("MINUS THIRTY THREE THOUSAND THREE HUNDRED THIRTY THREE DOLLARS", result);
        }
        
    }
}
