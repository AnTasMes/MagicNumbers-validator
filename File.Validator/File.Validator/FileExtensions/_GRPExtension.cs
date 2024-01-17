using System;
using System.Collections.Generic;
using System.Text;

namespace File.Validator.FileExtensions
{
	public class _GRPExtension : FileExtensionInfo
	{
		public override string Name => "grp";
		public override int Offset => 0;
		public override string[] Hex => new string[] {"50-4D-43-43"};
	}
}