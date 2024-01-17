using System;
using System.Collections.Generic;
using System.Text;

namespace File.Validator.FileExtensions
{
	public class _M3UExtension : FileExtensionInfo
	{
		public override string Name => "m3u";
		public override int Offset => 0;
		public override string[] Hex => new string[] {"23-45-58-54-4D-33-55"};
	}
}