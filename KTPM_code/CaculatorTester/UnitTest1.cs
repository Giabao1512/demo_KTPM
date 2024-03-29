using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using KTPM_code;

namespace CaculatorTester
{
	[TestClass]
	public class UnitTest1
	{
		private Caculator c;
		public TestContext testContext;
		[TestInitialize] //thiet lap du lieu chung
		public void setUp()
		{
			c = new Caculator(10,5);
		}
		[TestMethod] //1 testMethod = 1 testcase
		public void TestAddOperator()
		{
			int expected = 15;
			int actual = c.Exectute("+");
			Assert.AreEqual(expected, actual);
		}

		[TestMethod] //1 testMethod = 1 testcase
		public void TestSubOperator()
		{
			int expected = 5;
			int actual = c.Exectute("-");
			Assert.AreEqual(expected, actual);
		}

		[TestMethod] //1 testMethod = 1 testcase
		public void TestMulOperator()
		{
			int expected = 50;
			int actual = c.Exectute("*");
			Assert.AreEqual(expected, actual);
		}

		[TestMethod] //1 testMethod = 1 testcase
		public void TestDivOperator()
		{
			int expected = 2;
			int actual = c.Exectute("/");
			Assert.AreEqual(expected, actual);
		}

		//lien ket TestData voi project
		[DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV",
		@".\\Data\\TestData.csv",
		tableName: "TestData#csv",
		DataAccessMethod.Sequential)]
		[TestMethod]
		public void TestWithDataSource()
		{
			int a, b, expected;
			a = int.Parse(testContext.DataRow[0].ToString());
			b = int.Parse(testContext.DataRow[1].ToString());
			expected = int.Parse(testContext.DataRow[2].ToString());
			c = new Caculator(a, b);
			int actual = c.Exectute("+");
			Assert.AreEqual(expected, actual);
		}
	}
}
