using Microsoft.VisualStudio.TestTools.UnitTesting;
using StringCheckLibrary;
using System;

namespace StringCheckLibararyTests
{
    [TestClass]
    public class StringCheckTests
    {
        /// <summary>
        /// Проверка на пустую строку.
        /// </summary>
        [TestMethod]
        public void CheckName_isEmpty_ReturnedFalse()
        {
            //Arrange
            string stringName=string.Empty;
            //Act
            StringCheck obj = new StringCheck();
            bool result=obj.CheckName(stringName);
            //Assert
            Assert.IsFalse(result);
        }
        /// <summary>
        /// Проверка на ввод больше 50
        /// </summary>
        [TestMethod]
        public void CheckName_isMany50_ReturnedFalse()
        {
            //Arrange
            string stringName = "Sasasadsasdadsadfdsafasdfasfsafasdasdhgasffdjhgasjhdfsjksdafkjdshjk";
            //Act
            StringCheck obj = new StringCheck();
            bool result = obj.CheckName(stringName);
            //Assert
            Assert.IsFalse(result);
        }

    }

}
