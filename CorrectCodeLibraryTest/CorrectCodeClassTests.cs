using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using CorrectCodeLibrary;

namespace CorrectCodeLibraryTest
{
    [TestClass]
    public class CorrectCodeClassTests
    {
        /// <summary>
        /// Пустая строка
        /// </summary>
        [TestMethod]
        public void IsCorrectCode_StringEmpity_ReturnFalse()
        {
            //Arrange
            string text = "";

            //Act
            bool actual = CorrectCodeClass.IsCorrectCode(text);

            //Assert
            Assert.IsFalse(actual);
        }

        /// <summary>
        /// Длинна строки меньше 10
        /// </summary>
        [TestMethod]
        public void IsCorrectCode_LenghtLess10_ReturnFalse()
        {
            //Arrange
            string text = "123";

            //Act
            bool actual = CorrectCodeClass.IsCorrectCode(text);

            //Assert
            Assert.IsFalse(actual);
        }

        /// <summary>
        /// Длинна строки больше 10
        /// </summary>
        [TestMethod]
        public void IsCorrectCode_LenghtOver10_ReturnFalse()
        {
            //Arrange
            string text = "123123123123123";

            //Act
            bool actual = CorrectCodeClass.IsCorrectCode(text);

            //Assert
            Assert.IsFalse(actual);
        }

        /// <summary>
        /// Строка содержит не цифры
        /// </summary>
        [TestMethod]
        public void IsCorrectCode_NotNumbers_ReturnFalse()
        {
            //Arrange
            string text = "strokasymb";

            //Act
            bool actual = CorrectCodeClass.IsCorrectCode(text);

            //Assert
            Assert.IsFalse(actual);
        }

        /// <summary>
        /// Сумма делится на 10, последний символ 0
        /// </summary>
        [TestMethod]
        public void IsCorrectCode_DividedBy10_ReturnTrue()
        {
            //Arrange
            string text = "1234123400";

            //Act
            bool actual = CorrectCodeClass.IsCorrectCode(text);

            //Assert
            Assert.IsTrue(actual);
        }

        /// <summary>
        /// Сумма не делится на 10
        /// </summary>
        [TestMethod]
        public void IsCorrectCode_DividedBy10_ReturnFalse()
        {
            //Arrange
            string text = "1234123401";

            //Act
            bool actual = CorrectCodeClass.IsCorrectCode(text);

            //Assert
            Assert.IsFalse(actual);
        }

        /// <summary>
        /// Сумма не делится на 10, в конце не 1
        /// </summary>
        [TestMethod]
        public void IsCorrectCode_DividedBy10Not1_ReturnFalse()
        {
            //Arrange
            string text = "1234123404";

            //Act
            bool actual = CorrectCodeClass.IsCorrectCode(text);

            //Assert
            Assert.IsFalse(actual);
        }

        /// <summary>
        /// Сумма делится на 3
        /// </summary>
        [TestMethod]
        public void IsCorrectCode_DividedBy3_ReturnTrue()
        {
            //Arrange
            string text = "3000030001";

            //Act
            bool actual = CorrectCodeClass.IsCorrectCode(text);

            //Assert
            Assert.IsTrue(actual);
        }

        /// <summary>
        /// Сумма не делится на 3, но в конце 9
        /// </summary>
        [TestMethod]
        public void IsCorrectCode_NotDividedBy3End9_ReturnTrue()
        {
            //Arrange
            string text = "3000130009";

            //Act
            bool actual = CorrectCodeClass.IsCorrectCode(text);

            //Assert
            Assert.IsTrue(actual);
        }
    }
}
