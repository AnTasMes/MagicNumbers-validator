using System;
using System.Collections.Generic;
using System.Text;

namespace File.Validator.FileExtensions
{
	public class _PCAPExtension : FileExtensionInfo
	{
		public override string Name => "pcap";
		public override int Offset => 0;
		public override string[] Hex => new string[] {"D4-C3-B2-A1", "A1-B2-C3-D4", "4D-3C-B2-A1", "A1-B2-3C-4D"};
	}
}