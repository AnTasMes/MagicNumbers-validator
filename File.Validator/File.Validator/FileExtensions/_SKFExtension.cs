using System;
using System.Collections.Generic;
using System.Text;

namespace File.Validator.FileExtensions
{
	public class _SKFExtension : FileExtensionInfo
	{
		public override string Name => "skf";
		public override int Offset => 0;
		public override string[] Hex => new string[] {"07-53-4B-46"};
	}
}