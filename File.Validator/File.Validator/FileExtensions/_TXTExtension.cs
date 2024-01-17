using System;
using System.Collections.Generic;
using System.Text;

namespace File.Validator.FileExtensions
{
	public class _TXTExtension : FileExtensionInfo
	{
		public override string Name => "txt";
		public override int Offset => 0;
		public override string[] Hex => new string[] {"EF-BB-BF", "FF-FE", "FE-FF", "FF-FE-00-00", "00-00-FE-FF", "0E-FE-FF"};
	}
}