using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace GokulAssignment2.Tests
{
    [TestClass]
    public class RectangleAppTests
    {
           //******************DEFAULT CONSTRUCTOR****************

            [TestMethod]
            public void RectangleDefaultConstructor_NoInputs_ReturnsLengthAndWidthEqualTo_1()
            {
                // arrange
                Rectangle rectangle = new Rectangle();

                // act            
                //there is no actions to perform

                // assert
                Assert.AreEqual(1, rectangle.GetLength());
                Assert.AreEqual(1, rectangle.GetWidth());
            }

            //****************** CONSTRUCTOR WIDTH PARAMETERS****************
            public void RectangleConstructorWithParameters_InputLength6AndWidth3_ReturnsLength6Width3()
            {
                // arrange
                var rectangle = new Rectangle(6, 3);

                // act            
                //there is no actions to perform

                // assert
                Assert.AreEqual(3, rectangle.GetLength());
                Assert.AreEqual(3, rectangle.GetWidth());
            }

            [TestMethod]
            [ExpectedException(typeof(ArgumentOutOfRangeException))]
            public void RectangleConstructorWithParameters_InputLengthHasMinimum_ResultArgumentOutOfRangeException()
            {
                // arrange
                var rectangle = new Rectangle(0, 2);

                // act
                //there is no actions to perform

                // assert
                //  nothing to assert
            }

            [TestMethod]
            [ExpectedException(typeof(ArgumentOutOfRangeException))]
            public void RectangleConstructorWithParameters_InputWidthHasMinimum_ResultArgumentOutOfRangeException()
            {
                // arrange
                var rectangle = new Rectangle(6, 0);

                // act
                //there is no actions to perform

                // assert
                //  nothing to assert
            }

            [TestMethod]
            [ExpectedException(typeof(ArgumentException))]
            public void RectangleConstructorWithParameters_InputLengthEqualsWidth_ResultArgumentException()
            {
                // arrange
                var rectangle = new Rectangle(6, 6);

                // act
                //there is no actions to perform

                // assert
                //  nothing to assert
            }

            //*********************** AREA ***********************
            [TestMethod]
            public void GetArea_InputLength6AndWidth3_Returns18()
            {
                //Arrange
                int length = 6, width = 3;
                int expectedResult = length * width;
                var rectangle = new Rectangle(length, width);

                //Act
                int actualResult = rectangle.GetArea();

                //Assert
                Assert.AreEqual(expectedResult, actualResult);
            }

            [TestMethod]
            public void GetArea_InputInteger_ReturnsInteger()
            {
                //Arrange
                int length = 6, width = 3;
                var rectangle = new Rectangle(length, width);

                //Act
                int actualResult = rectangle.GetArea();

                //Assert
                Assert.IsInstanceOfType(actualResult, typeof(int));
            }


            //*********************** PERIMETER ***********************
            [TestMethod]
            public void GetPerimeter_InputLength6AndWidth3_Returns18()
            {
                //Arrange
                int length = 6, width = 3;
                int expectedResult = 2 * (length + width);
                var rectangle = new Rectangle(length, width);

                //Act
                int actualResult = rectangle.GetPerimeter();

                //Assert
                Assert.AreEqual(expectedResult, actualResult);
            }

            [TestMethod]
            public void GetPerimeter_InputInteger_ReturnsInteger()
            {
                int length = 6, width = 3;
                var rectangle = new Rectangle(length, width);

                //Act
                int actualResult = rectangle.GetPerimeter();

                //Assert
                Assert.IsInstanceOfType(actualResult, typeof(int));
            }


            //*********************** GETLENGTH ***********************
            [TestMethod]
            public void GetLength_Input6_Returns6()
            {
                int length = 6;

                //Arrange            
                var rectangle = new Rectangle(length, 3);

                //Act
                int actualResult = rectangle.GetLength();

                //Assert
                Assert.AreEqual(length, actualResult);
            }

            [TestMethod]
            public void GetLength_InputInteger_ReturnsInteger()
            {
                int length = 6;

                //Arrange            
                var rectangle = new Rectangle(length, 3);

                //Act
                int actualResult = rectangle.GetLength();

                //Assert
                Assert.IsInstanceOfType(actualResult, typeof(int));
            }


            //*********************** SETLENGTH ***********************
            [TestMethod]
            public void SetLength_Input6_Returns6()
            {
                //Arrange            
                var rectangle = new Rectangle();

                //Act
                int actualResult = rectangle.SetLength(6);

                //Assert
                Assert.AreEqual(6, actualResult);
            }

            [TestMethod]
            public void SetLength_InputInteger_ReturnsInteger()
            {
                //Arrange            
                var rectangle = new Rectangle();

                //Act
                int actualResult = rectangle.SetLength(6);

                //Assert
                Assert.IsInstanceOfType(actualResult, typeof(int));
            }

            [TestMethod]
            public void SetLength_InputValueLessThan1_ReturnsTheLastValidValue()
            {
                //Arrange            
                var rectangle = new Rectangle(5, 6);

                //Act
                int actualResult = rectangle.SetLength(-1);

                //Assert
                Assert.AreEqual(5, actualResult);
            }


            //*********************** GETWIDTH ***********************
            [TestMethod]
            public void GetWidth_Input6_Returns6()
            {
                int width = 6;

                //Arrange            
                var rectangle = new Rectangle(3, width);

                //Act
                int actualResult = rectangle.GetWidth();

                //Assert
                Assert.AreEqual(width, actualResult);
            }

            [TestMethod]
            public void GetWidth_InputInteger_ReturnsInteger()
            {
                int width = 6;

                //Arrange            
                var rectangle = new Rectangle(3, width);

                //Act
                int actualResult = rectangle.GetWidth();

                //Assert
                Assert.IsInstanceOfType(actualResult, typeof(int));
            }


            //*********************** SETWIDTH ***********************
            [TestMethod]
            public void SetWidth_Input6_Returns6()
            {
                //Arrange            
                var rectangle = new Rectangle();

                //Act
                int actualResult = rectangle.SetWidth(6);

                //Assert
                Assert.AreEqual(6, actualResult);
            }

            [TestMethod]
            public void SetWidth_InputInteger_ReturnsInteger()
            {
                //Arrange            
                var rectangle = new Rectangle();

                //Act
                int actualResult = rectangle.SetWidth(6);

                //Assert
                Assert.IsInstanceOfType(actualResult, typeof(int));
            }

            [TestMethod]
            public void SetWidth_InputValueLessThan1_ReturnsTheLastValidValue()
            {
                //Arrange            
                var rectangle = new Rectangle(5, 6);

                //Act
                int actualResult = rectangle.SetWidth(-5);

                //Assert
                Assert.AreEqual(6, actualResult);
            }
        }
   
}
