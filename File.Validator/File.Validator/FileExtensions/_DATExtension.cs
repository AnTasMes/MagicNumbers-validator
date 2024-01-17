using System;
using System.Collections.Generic;
using System.Text;

namespace File.Validator.FileExtensions
{
	public class _DATExtension : FileExtensionInfo
	{
		public override string Name => "dat";
		public override int Offset => 0;
		public override string[] Hex => new string[] {"50-4D-4F-43-43-4D-4F-43", "72-65-67-66"};
	}
}