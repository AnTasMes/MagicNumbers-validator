using System;
using System.Collections.Generic;
using System.Text;

namespace File.Validator.FileExtensions
{
	public class _WMFExtension : FileExtensionInfo
	{
		public override string Name => "wmf";
		public override int Offset => 0;
		public override string[] Hex => new string[] {"D7-CD-C6-9A"};
	}
}