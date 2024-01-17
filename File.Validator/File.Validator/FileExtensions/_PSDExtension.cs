using System;
using System.Collections.Generic;
using System.Text;

namespace File.Validator.FileExtensions
{
	public class _PSDExtension : FileExtensionInfo
	{
		public override string Name => "psd";
		public override int Offset => 0;
		public override string[] Hex => new string[] {"38-42-50-53"};
	}
}