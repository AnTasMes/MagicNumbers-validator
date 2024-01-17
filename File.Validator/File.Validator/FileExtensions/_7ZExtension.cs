using System;
using System.Collections.Generic;
using System.Text;

namespace File.Validator.FileExtensions
{
	public class _7ZExtension : FileExtensionInfo
	{
		public override string Name => "7z";
		public override int Offset => 0;
		public override string[] Hex => new string[] {"37-7A-BC-AF-27-1C"};
	}
}