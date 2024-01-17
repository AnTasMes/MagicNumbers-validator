using System;
using System.Collections.Generic;
using System.Text;

namespace File.Validator.FileExtensions
{
	public class _WADExtension : FileExtensionInfo
	{
		public override string Name => "wad";
		public override int Offset => 0;
		public override string[] Hex => new string[] {"49-57-41-44"};
	}
}