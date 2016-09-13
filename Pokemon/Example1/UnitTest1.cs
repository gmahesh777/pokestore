using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Pokemon;
using System.Diagnostics;

namespace UnitTests
{
    [TestClass]
    public class UnitTest1
    {
        /// <summary>
        /// Purchased 1 Pikachu
        /// Should yield $6.00 
        /// </summary>
        [TestMethod]
        public void TestMethod1()
        {
            Console.Write('$'+ CalculateCost.Calculate(1, 0, 0).ToString("#0.00"));
        }

        /// <summary>
        /// Purchased 2 Pikachu
        /// Should yield $12.00
        /// </summary>
        [TestMethod]
        public void TestMethod2()
        {
            Console.Write('$' + CalculateCost.Calculate(2, 0, 0).ToString("#0.00"));
        }

        /// <summary>
        /// Purchased 1 Pikachu
        /// Purchased 1 Squirtle
        /// Should yield $9.90
        /// </summary>
        [TestMethod]
        public void TestMethod3()
        {
            Console.Write('$' + CalculateCost.Calculate(1, 1, 0).ToString("#0.00"));
        }

        /// <summary>
        /// Purchased 2 Pikachu
        /// Purchased 2 Squirtle
        /// Should yield $19.80
        /// </summary>
        [TestMethod]
        public void TestMethod4()
        {
            Console.Write('$' + CalculateCost.Calculate(2, 2, 0).ToString("#0.00"));
        }

        /// <summary>
        /// Purchased 3 Pikachu
        /// Purchased 3 Squirtle
        /// Should yield $29.70
        /// </summary>
        [TestMethod]
        public void TestMethod5()
        {
            Console.Write('$' + CalculateCost.Calculate(3, 3, 0).ToString("#0.00"));
        }

        /// <summary>
        /// Purchased 2 Pikachu
        /// Purchased 1 Squirtle
        /// Should yield $15.90
        /// </summary>
        [TestMethod]
        public void TestMethod6()
        {
            Console.Write('$' + CalculateCost.Calculate(2, 1, 0).ToString("#0.00"));
        }

        /// <summary>
        /// Purchased 1 Pikachu
        /// Purchased 1 Squirtle
        /// Purchased 1 Charmander
        /// Should yield $12.80
        /// </summary>
        [TestMethod]
        public void TestMethod7()
        {
            Console.Write('$' + CalculateCost.Calculate(1, 1, 1).ToString("#0.00"));
        }

        /// <summary>
        /// Purchased 2 Pikachu
        /// Purchased 1 Squirtle
        /// Purchased 1 Charmander
        /// Should yield $18.80
        /// </summary>
        [TestMethod]
        public void TestMethod8()
        {
            Console.Write('$' + CalculateCost.Calculate(2, 1, 1).ToString("#0.00"));
        }

    }
}
