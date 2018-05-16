using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Palindromes
{
	class Palindrone
	{
	
		public void IsItAPalindrome(string sentence)
		{

			var removedNonChars = new string(sentence.Where(Char.IsLetter).ToArray());
			string[] split = removedNonChars.ToLower().Split();
			var joined = "";

			foreach(var word in split)
			{
				joined += word;
			}

			char[] joinedArray = joined.ToCharArray();
			Array.Reverse(joinedArray);

			var reversed = new string(joinedArray);

			if(reversed == joined)
			{
				Console.WriteLine("True");
			}
			else Console.WriteLine("False");

		}
	}
}
