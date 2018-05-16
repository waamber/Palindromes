using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palindromes
{
	class Program
	{
		static void Main(string[] args)
		{
			var reverse = new Palindrone();
			reverse.IsItAPalindrome("taco2!cat");
			Console.ReadLine();
		}
	}
}
