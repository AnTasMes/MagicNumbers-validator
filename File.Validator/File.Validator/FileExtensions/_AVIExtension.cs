using System;
using System.Collections.Generic;
using System.Text;

namespace File.Validator.FileExtensions
{
	public class _AVIExtension : FileExtensionInfo
	{
		public override string Name => "avi";
		public override int Offset => 0;
		public override string[] Hex => new string[] {"52-49-46-46", "41-56-49-20"};
	}
}