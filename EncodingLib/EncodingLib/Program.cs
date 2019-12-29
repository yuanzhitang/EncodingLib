using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncodingLib
{
	class Program
	{
		static void Main(string[] args)
		{
			//Char "Š", Unicode Code page is \u0160
			string str = "\u0160";
			string utf16CodePoint = EncodingUtil.ConvertToUnicodeCodePoint(str[0]);

			var character = EncodingUtil.ConvertUnicodeCodePointToChar("0160");
		}
	}
}
