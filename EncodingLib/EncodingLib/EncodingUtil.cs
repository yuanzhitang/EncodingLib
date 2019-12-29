using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncodingLib
{
	public class EncodingUtil
	{
		/// <summary>
		/// Convert Char to Unicode Code Point
		/// For e.g Character "Š", Unicode Code page is \u0160
		/// </summary>
		/// <param name="character"></param>
		/// <returns></returns>
		public static string ConvertToUnicodeCodePoint(char character)
		{
			var bytes = Encoding.Unicode.GetBytes(new char[] { character });

			var lowerByte = bytes[0];
			var uppperByte = bytes[1];

			string codepoint = uppperByte.ToString("X2")+lowerByte.ToString("X2");
			return codepoint;
		}

		/// <summary>
		/// Convert Char to Unicode Code Point
		/// For e.g Unicode Code page is \u0160, The output is Character "Š"
		/// </summary>
		/// <param name="character"></param>
		/// <returns></returns>
		public static char ConvertUnicodeCodePointToChar(string unicodeCodePoint)
		{
			var lowerByte = Convert.ToByte(unicodeCodePoint.Substring(0, 2), 16);
			var uppperByte = Convert.ToByte(unicodeCodePoint.Substring(2, 2), 16);
			var bytes = new byte[] { uppperByte, lowerByte};

			return Encoding.Unicode.GetChars(bytes)[0];
		}
	}
}
