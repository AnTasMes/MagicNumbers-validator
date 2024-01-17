using System;
using System.Collections.Generic;
using System.Text;

namespace File.Validator.FileExtensions
{
	public class _MMMExtension : FileExtensionInfo
	{
		public override string Name => "mmm";
		public override int Offset => 0;
		public override string[] Hex => new string[] {"52-49-46-46-52-4D-4D-50"};
	}
}