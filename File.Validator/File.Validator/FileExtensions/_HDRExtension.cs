using System;
using System.Collections.Generic;
using System.Text;

namespace File.Validator.FileExtensions
{
	public class _HDRExtension : FileExtensionInfo
	{
		public override string Name => "hdr";
		public override int Offset => 0;
		public override string[] Hex => new string[] {"23-3F-52-41-44-49-41-4E-43-45-0A", "6E-69-31-00"};
	}
}