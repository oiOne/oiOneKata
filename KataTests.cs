using System;
using Xunit;
using FluentAssertions;

namespace oiOneKata
{
    public class KataTests
    {
        [Fact(DisplayName ="ValidatePin should return false for pins with length other than 4 or 6")]
        public void LengthTest()
        {
          Assert.False(Kata.ValidatePin("1"), "Wrong output for \"1\"");
          Assert.False(Kata.ValidatePin("12"), "Wrong output for \"12\"");
          Assert.False(Kata.ValidatePin("123"), "Wrong output for \"123\"");
          Assert.False(Kata.ValidatePin("12345"), "Wrong output for \"12345\"");
          Assert.False(Kata.ValidatePin("1234567"), "Wrong output for \"1234567\"");
          Assert.False(Kata.ValidatePin("-1234"), "Wrong output for \"-1234\"");
          Assert.False(Kata.ValidatePin("1.234"), "Wrong output for \"1.234\"");
          Assert.False(Kata.ValidatePin("-1.234"), "Wrong output for \"-1.234\"");
          Assert.False(Kata.ValidatePin("00000000"), "Wrong output for \"00000000\"");
        }
    
        [Fact(DisplayName ="ValidatePin should return false for pins which contain characters other than digits")]
        public void NonDigitTest()
        {
          Assert.False(Kata.ValidatePin("a234"), "Wrong output for \"a234\"");
          Assert.False(Kata.ValidatePin(".234"), "Wrong output for \".234\"");
        }
    
        [Fact(DisplayName ="ValidatePin should return true for valid pins")]
        public void ValidTest()
        {
          Assert.True(Kata.ValidatePin("1234"), "Wrong output for \"1234\"");
          Assert.True(Kata.ValidatePin("0000"), "Wrong output for \"0000\"");
          Assert.True(Kata.ValidatePin("1111"), "Wrong output for \"1111\"");
          Assert.True(Kata.ValidatePin("123456"), "Wrong output for \"123456\"");
          Assert.True(Kata.ValidatePin("098765"), "Wrong output for \"098765\"");
          Assert.True(Kata.ValidatePin("000000"), "Wrong output for \"000000\"");
          Assert.True(Kata.ValidatePin("090909"), "Wrong output for \"090909\"");
        }

        [Fact]
        public void MoveZeroes()
        {
            Assert.Equal(new int[] {1, 2, 1, 1, 3, 1, 0, 0, 0, 0}, Kata.MoveZeroes(new int[] {1, 2, 0, 1, 0, 1, 0, 3, 0, 1}));
        }
        [Theory]
        [InlineData("AAAABBBCCDAABBB","ABCDAB")]
        [InlineData("aabc","abc")]
        [InlineData("","")]
        public void UniqueInOrder(string input, string expected)
        {
            var exp = Kata.UniqueInOrder(input);
            Assert.Equal(expected, string.Join("",exp));
        }
        /*
            t can store a value between 2,147,483,647 and -2,147,483,648
         */
        [Theory]
        [InlineData("123", "321", "444")]
        [InlineData("11", "99", "110")]
        [InlineData("", "", "")]
        public void AddBigNumbers(string a, string b, string expected)
        {
            Assert.Equal(expected, Kata.AddBigNumbers(a, b));
        }

        [Theory]
        [InlineData(3.0, 0.66, 1.5, 3)]
        [InlineData(30.0, 0.66, 1.5, 15)]
        public void BouncingBall(double h, double bounce, double window, int expected)
        {
            Assert.Equal(expected, Kata.BouncingBall(h, bounce, window));
        }

        [Theory]
        [InlineData(new [] { 'a','b','c','d','f' }, 'e')]
        [InlineData(new [] { 'O','Q','R','S' }, 'P')]
        public void FindMissingLetter(char[] input, char expected)
        {
          Assert.Equal(expected, Kata.FindMissingLetter(input));
          Assert.Equal(expected, Kata.FindMissingLetter(input));
        }

        [Fact]
        public void BitCalculator()
        {
            Assert.Equal(0, Kata.Calculate("0", "0"));

            Assert.Equal(1, Kata.Calculate("0", "1"));
            Assert.Equal(1, Kata.Calculate("1", "0"));

            Assert.Equal(2, Kata.Calculate("1", "1"));
            Assert.Equal(2, Kata.Calculate("10", "0"));

            Assert.Equal(4, Kata.Calculate("10", "10"));
            Assert.Equal(3, Kata.Calculate("10", "1"));
            Assert.Equal(6, Kata.Calculate("110", "0"));
        }

        //[Fact]
        //public void Test1() {
        //    Assert.AreEqual(1, Hamming.hamming(1), "hamming(1) should be 1");
        //    Assert.AreEqual(2, Hamming.hamming(2), "hamming(2) should be 2");
        //    Assert.AreEqual(3, Hamming.hamming(3), "hamming(3) should be 3");
        //    Assert.AreEqual(4, Hamming.hamming(4), "hamming(4) should be 4");
        //    Assert.AreEqual(5, Hamming.hamming(5), "hamming(5) should be 5");
        //    Assert.AreEqual(6, Hamming.hamming(6), "hamming(6) should be 6");
        //    Assert.AreEqual(8, Hamming.hamming(7), "hamming(7) should be 8");
        //    Assert.AreEqual(9, Hamming.hamming(8), "hamming(8) should be 9");
        //    Assert.AreEqual(10, Hamming.hamming(9), "hamming(9) should be 10");
        //    Assert.AreEqual(12, Hamming.hamming(10), "hamming(10) should be 12");
        //    Assert.AreEqual(15, Hamming.hamming(11), "hamming(11) should be 15");
        //    Assert.AreEqual(16, Hamming.hamming(12), "hamming(12) should be 16");
        //    Assert.AreEqual(18, Hamming.hamming(13), "hamming(13) should be 18");
        //    Assert.AreEqual(20, Hamming.hamming(14), "hamming(14) should be 20");
        //    Assert.AreEqual(24, Hamming.hamming(15), "hamming(15) should be 24");
        //    Assert.AreEqual(25, Hamming.hamming(16), "hamming(16) should be 25");
        //    Assert.AreEqual(27, Hamming.hamming(17), "hamming(17) should be 27");
        //    Assert.AreEqual(30, Hamming.hamming(18), "hamming(18) should be 30");
        //    Assert.AreEqual(32, Hamming.hamming(19), "hamming(19) should be 32");
        //}
    }
}
