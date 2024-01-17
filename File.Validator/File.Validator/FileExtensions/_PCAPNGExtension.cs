using System;
using System.Collections.Generic;
using System.Text;

namespace File.Validator.FileExtensions
{
	public class _PCAPNGExtension : FileExtensionInfo
	{
		public override string Name => "pcapng";
		public override int Offset => 0;
		public override string[] Hex => new string[] {"0A-0D-0D-0A"};
	}
}