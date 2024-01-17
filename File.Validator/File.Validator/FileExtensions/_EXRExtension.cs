using System;
using System.Collections.Generic;
using System.Text;

namespace File.Validator.FileExtensions
{
	public class _EXRExtension : FileExtensionInfo
	{
		public override string Name => "exr";
		public override int Offset => 0;
		public override string[] Hex => new string[] {"76-2F-31-01"};
	}
}