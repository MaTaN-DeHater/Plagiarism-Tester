using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using compare;
using System.IO;
using System.Collections.Generic;

namespace UnitTestCompare
{
    [TestClass]
    public class UnitTest1
    {
        /// <summary>
        /// UnitTests for relative path and testing our comapre class for working correctly 
        /// we provide 1 test that will succseed 
        /// and 1 test that fails 
        /// </summary>
        [TestMethod]
        public void TestMethod1()
        {
            try
            {
                Compares compare = new Compares();
                // This will get the current WORKING directory (i.e. \bin\Debug)
                string workingDirectory = Environment.CurrentDirectory;
                // This will get the current PROJECT directory
                string projectDirectory = Directory.GetParent(workingDirectory).Parent.Parent.FullName;
                string path = Path.Combine(projectDirectory, @"compare\TestData");
                compare.compares(path);
                Assert.IsTrue(compare.result);
            }
            catch (Exception e)
            {
                Assert.Fail(e.Message);
            }


        }

        [TestMethod]
        public void TestMethod2()
        {
            try
            {
                Compares compare = new Compares();
                // This will get the current WORKING directory (i.e. \bin\Debug)
                string workingDirectory = Environment.CurrentDirectory;
                // This will get the current PROJECT directory
                string projectDirectory = Directory.GetParent(workingDirectory).Parent.Parent.FullName;
                string path = Path.Combine(projectDirectory, @"compare\TestData");
                compare.compares(null);
                Assert.IsTrue(compare.result);
            }
            catch (Exception e)
            {
                Assert.Fail(e.Message);
            }


        }

        [TestMethod]
        public void TestMethod3()
        {
            try
            {
                Compares compare = new Compares();
                // This will get the current WORKING directory (i.e. \bin\Debug)
                string workingDirectory = Environment.CurrentDirectory;
                // This will get the current PROJECT directory
                string projectDirectory = Directory.GetParent(workingDirectory).Parent.Parent.FullName;
                string path = Path.Combine(projectDirectory, @"compare\Test");
                compare.compares(path);
                string[] a = compare.match.ToArray();
                Assert.AreEqual("32156465HW.txt match 100% with 32165454HW1.txt",a[0]);
            }
            catch (Exception e)
            {
                Assert.Fail(e.Message);
            }


        }

        [TestMethod]
        public void TestMethod4()
        {
            try
            {
                Compares compare = new Compares();
                // This will get the current WORKING directory (i.e. \bin\Debug)
                string workingDirectory = Environment.CurrentDirectory;
                // This will get the current PROJECT directory
                string projectDirectory = Directory.GetParent(workingDirectory).Parent.Parent.FullName;
                string path = Path.Combine(projectDirectory, @"compare\TestData");
                compare.compares(path);
                string[] a = compare.match.ToArray();
                Assert.AreEqual("מוהאב חמד_93616 Matrixin1.txt match 100% with מוחמד יזבכ_93610 Matrixin1.txt", a[1]);
            }
            catch (Exception e)
            {
                Assert.Fail(e.Message);
            }


        }

    }
}
