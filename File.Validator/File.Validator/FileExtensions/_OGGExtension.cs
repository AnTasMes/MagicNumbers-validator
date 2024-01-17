using System;
using System.Collections.Generic;
using System.Text;

namespace File.Validator.FileExtensions
{
	public class _OGGExtension : FileExtensionInfo
	{
		public override string Name => "ogg";
		public override int Offset => 0;
		public override string[] Hex => new string[] {"4F-67-67-53"};
	}
}