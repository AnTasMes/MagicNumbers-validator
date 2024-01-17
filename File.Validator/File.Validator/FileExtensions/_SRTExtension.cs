using System;
using System.Collections.Generic;
using System.Text;

namespace File.Validator.FileExtensions
{
	public class _SRTExtension : FileExtensionInfo
	{
		public override string Name => "srt";
		public override int Offset => 0;
		public override string[] Hex => new string[] {"31-0A-30-30"};
	}
}