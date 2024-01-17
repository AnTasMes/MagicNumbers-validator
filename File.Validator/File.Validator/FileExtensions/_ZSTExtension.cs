using System;
using System.Collections.Generic;
using System.Text;

namespace File.Validator.FileExtensions
{
	public class _ZSTExtension : FileExtensionInfo
	{
		public override string Name => "zst";
		public override int Offset => 0;
		public override string[] Hex => new string[] {"28-B5-2F-FD"};
	}
}