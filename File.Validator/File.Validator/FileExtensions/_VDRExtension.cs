using System;
using System.Collections.Generic;
using System.Text;

namespace File.Validator.FileExtensions
{
	public class _VDRExtension : FileExtensionInfo
	{
		public override string Name => "vdr";
		public override int Offset => 0;
		public override string[] Hex => new string[] {"52-49-46-46-56-44-52-4D"};
	}
}