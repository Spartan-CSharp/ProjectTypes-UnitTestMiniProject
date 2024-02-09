using System;

using Xunit;

namespace CalculationLibrary.Tests
{
	public class CalculationsTests
	{
		[Fact]
		public void BasicAddTest()
		{
			// Arrange
			int expected = 7;

			// Act
			int actual = Calculations.Add(3, 4);

			// Assert
			Assert.Equal(expected, actual);
		}

		[Fact]
		public void BasicSubtractTest()
		{
			// Arrange
			int expected = -1;

			// Act
			int actual = Calculations.Subtract(3, 4);

			// Assert
			Assert.Equal(expected, actual);
		}

		[Fact]
		public void BasicMultiplyTest()
		{
			// Arrange
			int expected = 12;

			// Act
			int actual = Calculations.Multiply(3, 4);

			// Assert
			Assert.Equal(expected, actual);
		}

		[Fact]
		public void BasicDivideTest()
		{
			// Arrange
			int expected = 0;

			// Act
			int actual = Calculations.Divide(3, 4);

			// Assert
			Assert.Equal(expected, actual);
		}

		[Theory]
		// Arrange
		[InlineData(-3, -4, -7)]
		[InlineData(-3, 4, 1)]
		[InlineData(3, -4, -1)]
		[InlineData(3, 4, 7)]
		[InlineData(4, -4, 0)]
		[InlineData(4, 4, 8)]
		[InlineData(0, -4, -4)]
		[InlineData(0, 4, 4)]
		[InlineData(0, 0, 0)]
		[InlineData(-3, 0, -3)]
		[InlineData(3, 0, 3)]
		[InlineData(-4, -3, -7)]
		[InlineData(4, -3, 1)]
		[InlineData(-4, 3, -1)]
		[InlineData(4, 3, 7)]
		[InlineData(-4, 4, 0)]
		[InlineData(-4, 0, -4)]
		[InlineData(4, 0, 4)]
		[InlineData(0, -3, -3)]
		[InlineData(0, 3, 3)]
		[InlineData(-8, -4, -12)]
		[InlineData(-8, 4, -4)]
		[InlineData(8, -4, 4)]
		[InlineData(8, 4, 12)]
		[InlineData(-8, 0, -8)]
		[InlineData(8, 0, 8)]
		[InlineData(-4, -8, -12)]
		[InlineData(4, -8, -4)]
		[InlineData(-4, 8, 4)]
		[InlineData(4, 8, 12)]
		[InlineData(0, -8, -8)]
		[InlineData(0, 8, 8)]
		[InlineData(1, -4, -3)]
		[InlineData(1, 4, 5)]
		[InlineData(1, 1, 2)]
		[InlineData(-3, 1, -2)]
		[InlineData(3, 1, 4)]
		[InlineData(-4, 1, -3)]
		[InlineData(4, 1, 5)]
		[InlineData(1, -3, -2)]
		[InlineData(1, 3, 4)]
		[InlineData(-8, 1, -7)]
		[InlineData(8, 1, 9)]
		[InlineData(1, -8, -7)]
		[InlineData(1, 8, 9)]
		[InlineData(-1, -4, -5)]
		[InlineData(-1, 4, 3)]
		[InlineData(-1, -1, -2)]
		[InlineData(-3, -1, -4)]
		[InlineData(3, -1, 2)]
		[InlineData(-4, -1, -5)]
		[InlineData(4, -1, 3)]
		[InlineData(-1, -3, -4)]
		[InlineData(-1, 3, 2)]
		[InlineData(-8, -1, -9)]
		[InlineData(8, -1, 7)]
		[InlineData(-1, -8, -9)]
		[InlineData(-1, 8, 7)]
		public void ComprehensiveAddTest(int x, int y, int expected)
		{
			// Act
			int actual = Calculations.Add(x, y);

			// Assert
			Assert.Equal(expected, actual);
		}

		[Theory]
		// Arrange
		[InlineData(-3, -4, 1)]
		[InlineData(-3, 4, -7)]
		[InlineData(3, -4, 7)]
		[InlineData(3, 4, -1)]
		[InlineData(4, -4, 8)]
		[InlineData(4, 4, 0)]
		[InlineData(0, -4, 4)]
		[InlineData(0, 4, -4)]
		[InlineData(0, 0, 0)]
		[InlineData(-3, 0, -3)]
		[InlineData(3, 0, 3)]
		[InlineData(-4, -3, -1)]
		[InlineData(4, -3, 7)]
		[InlineData(-4, 3, -7)]
		[InlineData(4, 3, 1)]
		[InlineData(-4, 4, -8)]
		[InlineData(-4, 0, -4)]
		[InlineData(4, 0, 4)]
		[InlineData(0, -3, 3)]
		[InlineData(0, 3, -3)]
		[InlineData(-8, -4, -4)]
		[InlineData(-8, 4, -12)]
		[InlineData(8, -4, 12)]
		[InlineData(8, 4, 4)]
		[InlineData(-8, 0, -8)]
		[InlineData(8, 0, 8)]
		[InlineData(-4, -8, 4)]
		[InlineData(4, -8, 12)]
		[InlineData(-4, 8, -12)]
		[InlineData(4, 8, -4)]
		[InlineData(0, -8, 8)]
		[InlineData(0, 8, -8)]
		[InlineData(1, -4, 5)]
		[InlineData(1, 4, -3)]
		[InlineData(1, 1, 0)]
		[InlineData(-3, 1, -4)]
		[InlineData(3, 1, 2)]
		[InlineData(-4, 1, -5)]
		[InlineData(4, 1, 3)]
		[InlineData(1, -3, 4)]
		[InlineData(1, 3, -2)]
		[InlineData(-8, 1, -9)]
		[InlineData(8, 1, 7)]
		[InlineData(1, -8, 9)]
		[InlineData(1, 8, -7)]
		[InlineData(-1, -4, 3)]
		[InlineData(-1, 4, -5)]
		[InlineData(-1, -1, 0)]
		[InlineData(-3, -1, -2)]
		[InlineData(3, -1, 4)]
		[InlineData(-4, -1, -3)]
		[InlineData(4, -1, 5)]
		[InlineData(-1, -3, 2)]
		[InlineData(-1, 3, -4)]
		[InlineData(-8, -1, -7)]
		[InlineData(8, -1, 9)]
		[InlineData(-1, -8, 7)]
		[InlineData(-1, 8, -9)]
		public void ComprehensiveSubtractTest(int x, int y, int expected)
		{
			// Act
			int actual = Calculations.Subtract(x, y);

			// Assert
			Assert.Equal(expected, actual);
		}

		[Theory]
		// Arrange
		[InlineData(-3, -4, 12)]
		[InlineData(-3, 4, -12)]
		[InlineData(3, -4, -12)]
		[InlineData(3, 4, 12)]
		[InlineData(4, -4, -16)]
		[InlineData(4, 4, 16)]
		[InlineData(0, -4, 0)]
		[InlineData(0, 4, 0)]
		[InlineData(0, 0, 0)]
		[InlineData(-3, 0, 0)]
		[InlineData(3, 0, 0)]
		[InlineData(-4, -3, 12)]
		[InlineData(4, -3, -12)]
		[InlineData(-4, 3, -12)]
		[InlineData(4, 3, 12)]
		[InlineData(-4, 4, -16)]
		[InlineData(-4, 0, 0)]
		[InlineData(4, 0, 0)]
		[InlineData(0, -3, 0)]
		[InlineData(0, 3, 0)]
		[InlineData(-8, -4, 32)]
		[InlineData(-8, 4, -32)]
		[InlineData(8, -4, -32)]
		[InlineData(8, 4, 32)]
		[InlineData(-8, 0, 0)]
		[InlineData(8, 0, 0)]
		[InlineData(-4, -8, 32)]
		[InlineData(4, -8, -32)]
		[InlineData(-4, 8, -32)]
		[InlineData(4, 8, 32)]
		[InlineData(0, -8, 0)]
		[InlineData(0, 8, 0)]
		[InlineData(1, -4, -4)]
		[InlineData(1, 4, 4)]
		[InlineData(1, 1, 1)]
		[InlineData(-3, 1, -3)]
		[InlineData(3, 1, 3)]
		[InlineData(-4, 1, -4)]
		[InlineData(4, 1, 4)]
		[InlineData(1, -3, -3)]
		[InlineData(1, 3, 3)]
		[InlineData(-8, 1, -8)]
		[InlineData(8, 1, 8)]
		[InlineData(1, -8, -8)]
		[InlineData(1, 8, 8)]
		[InlineData(-1, -4, 4)]
		[InlineData(-1, 4, -4)]
		[InlineData(-1, -1, 1)]
		[InlineData(-3, -1, 3)]
		[InlineData(3, -1, -3)]
		[InlineData(-4, -1, 4)]
		[InlineData(4, -1, -4)]
		[InlineData(-1, -3, 3)]
		[InlineData(-1, 3, -3)]
		[InlineData(-8, -1, 8)]
		[InlineData(8, -1, -8)]
		[InlineData(-1, -8, 8)]
		[InlineData(-1, 8, -8)]
		public void ComprehensiveMultiplyTest(int x, int y, int expected)
		{
			// Act
			int actual = Calculations.Multiply(x, y);

			// Assert
			Assert.Equal(expected, actual);
		}

		[Theory]
		// Arrange
		[InlineData(-3, -4, 0)]
		[InlineData(-3, 4, 0)]
		[InlineData(3, -4, 0)]
		[InlineData(3, 4, 0)]
		[InlineData(4, -4, -1)]
		[InlineData(4, 4, 1)]
		[InlineData(0, -4, 0)]
		[InlineData(0, 4, 0)]
		//[InlineData(0, 0, 0)]
		//[InlineData(-3, 0, 0)]
		//[InlineData(3, 0, 0)]
		[InlineData(-4, -3, 1)]
		[InlineData(4, -3, -1)]
		[InlineData(-4, 3, -1)]
		[InlineData(4, 3, 1)]
		[InlineData(-4, 4, -1)]
		//[InlineData(-4, 0, 0)]
		//[InlineData(4, 0, 0)]
		[InlineData(0, -3, 0)]
		[InlineData(0, 3, 0)]
		[InlineData(-8, -4, 2)]
		[InlineData(-8, 4, -2)]
		[InlineData(8, -4, -2)]
		[InlineData(8, 4, 2)]
		//[InlineData(-8, 0, 0)]
		//[InlineData(8, 0, 0)]
		[InlineData(-4, -8, 0)]
		[InlineData(4, -8, 0)]
		[InlineData(-4, 8, 0)]
		[InlineData(4, 8, 0)]
		[InlineData(0, -8, 0)]
		[InlineData(0, 8, 0)]
		[InlineData(1, -4, 0)]
		[InlineData(1, 4, 0)]
		[InlineData(1, 1, 1)]
		[InlineData(-3, 1, -3)]
		[InlineData(3, 1, 3)]
		[InlineData(-4, 1, -4)]
		[InlineData(4, 1, 4)]
		[InlineData(1, -3, 0)]
		[InlineData(1, 3, 0)]
		[InlineData(-8, 1, -8)]
		[InlineData(8, 1, 8)]
		[InlineData(1, -8, 0)]
		[InlineData(1, 8, 0)]
		[InlineData(-1, -4, 0)]
		[InlineData(-1, 4, 0)]
		[InlineData(-1, -1, 1)]
		[InlineData(-3, -1, 3)]
		[InlineData(3, -1, -3)]
		[InlineData(-4, -1, 4)]
		[InlineData(4, -1, -4)]
		[InlineData(-1, -3, 0)]
		[InlineData(-1, 3, 0)]
		[InlineData(-8, -1, 8)]
		[InlineData(8, -1, -8)]
		[InlineData(-1, -8, 0)]
		[InlineData(-1, 8, 0)]
		public void ComprehensiveDivideTest(int x, int y, int expected)
		{
			// Act
			int actual = Calculations.Divide(x, y);

			// Assert
			Assert.Equal(expected, actual);
		}
	}
}
