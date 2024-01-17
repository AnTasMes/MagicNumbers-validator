using System;
using System.Collections.Generic;
using System.Text;

namespace File.Validator.FileExtensions
{
	public class _LZFSEExtension : FileExtensionInfo
	{
		public override string Name => "lzfse";
		public override int Offset => 0;
		public override string[] Hex => new string[] {"62-76-78-32"};
	}
}