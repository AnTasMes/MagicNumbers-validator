using System;
using System.Collections.Generic;
using System.Text;

namespace File.Validator.FileExtensions
{
	public class _ICOExtension : FileExtensionInfo
	{
		public override string Name => "ico";
		public override int Offset => 0;
		public override string[] Hex => new string[] {"00-00-01-00"};
	}
}