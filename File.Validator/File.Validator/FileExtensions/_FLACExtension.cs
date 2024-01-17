using System;
using System.Collections.Generic;
using System.Text;

namespace File.Validator.FileExtensions
{
	public class _FLACExtension : FileExtensionInfo
	{
		public override string Name => "flac";
		public override int Offset => 0;
		public override string[] Hex => new string[] {"66-4C-61-43"};
	}
}