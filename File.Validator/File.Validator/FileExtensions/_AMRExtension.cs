using System;
using System.Collections.Generic;
using System.Text;

namespace File.Validator.FileExtensions
{
	public class _AMRExtension : FileExtensionInfo
	{
		public override string Name => "amr";
		public override int Offset => 0;
		public override string[] Hex => new string[] {"23-21-41-4D-52"};
	}
}