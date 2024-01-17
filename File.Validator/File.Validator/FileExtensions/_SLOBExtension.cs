using System;
using System.Collections.Generic;
using System.Text;

namespace File.Validator.FileExtensions
{
	public class _SLOBExtension : FileExtensionInfo
	{
		public override string Name => "slob";
		public override int Offset => 0;
		public override string[] Hex => new string[] {"21-2D-31-53-4C-4F-42-1F"};
	}
}