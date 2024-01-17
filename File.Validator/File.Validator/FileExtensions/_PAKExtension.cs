using System;
using System.Collections.Generic;
using System.Text;

namespace File.Validator.FileExtensions
{
	public class _PAKExtension : FileExtensionInfo
	{
		public override string Name => "pak";
		public override int Offset => 0;
		public override string[] Hex => new string[] {"4B-50-4B-41"};
	}
}