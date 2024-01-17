using System;
using System.Collections.Generic;
using System.Text;

namespace File.Validator.FileExtensions
{
	public class _ZOOExtension : FileExtensionInfo
	{
		public override string Name => "zoo";
		public override int Offset => 0;
		public override string[] Hex => new string[] {"5A-4F-4F"};
	}
}