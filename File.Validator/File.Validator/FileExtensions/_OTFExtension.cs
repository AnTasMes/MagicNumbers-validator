using System;
using System.Collections.Generic;
using System.Text;

namespace File.Validator.FileExtensions
{
	public class _OTFExtension : FileExtensionInfo
	{
		public override string Name => "otf";
		public override int Offset => 0;
		public override string[] Hex => new string[] {"4F-54-54-4F"};
	}
}