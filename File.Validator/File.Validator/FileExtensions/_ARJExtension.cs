using System;
using System.Collections.Generic;
using System.Text;

namespace File.Validator.FileExtensions
{
	public class _ARJExtension : FileExtensionInfo
	{
		public override string Name => "arj";
		public override int Offset => 0;
		public override string[] Hex => new string[] {"60-EA"};
	}
}