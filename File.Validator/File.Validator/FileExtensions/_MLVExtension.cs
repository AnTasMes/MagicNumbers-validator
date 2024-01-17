using System;
using System.Collections.Generic;
using System.Text;

namespace File.Validator.FileExtensions
{
	public class _MLVExtension : FileExtensionInfo
	{
		public override string Name => "MLV";
		public override int Offset => 0;
		public override string[] Hex => new string[] {"4D-4C-56-49"};
	}
}