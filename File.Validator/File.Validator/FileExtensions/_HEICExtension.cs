using System;
using System.Collections.Generic;
using System.Text;

namespace File.Validator.FileExtensions
{
	public class _HEICExtension : FileExtensionInfo
	{
		public override string Name => "heic";
		public override int Offset => 4;
		public override string[] Hex => new string[] {"66-74-79-70-68-65-69-666-74-79-70-6D"};
	}
}