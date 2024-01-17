using System;
using System.Collections.Generic;
using System.Text;

namespace File.Validator.FileExtensions
{
	public class _SILExtension : FileExtensionInfo
	{
		public override string Name => "sil";
		public override int Offset => 0;
		public override string[] Hex => new string[] {"23-21-53-49-4C-4B-0A"};
	}
}