using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Ekz;

namespace Ekz_test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod()
        {
            Ekz.Trubes program = new Ekz.Trubes();
            program.Trup(4000, 1, 20, 2);

        }
    }
}
