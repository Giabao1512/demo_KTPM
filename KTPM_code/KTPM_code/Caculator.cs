using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KTPM_code
{
	public class Caculator
	{
		int a, b;
		public Caculator(int a, int b)
		{
			this.a = a;
			this.b = b;

		}
		public int Exectute(string operation)
		{
			int result = 0;
			switch (operation) {
				case "+":
				result = this.a + this.b; break;
				case "-":
				result = this.a - this.b; break;
				case "*":
				result = this.a * this.b; break;
				case "/":
				result = this.a / this.b; break;
			}
			return result;
		}
	}
}
