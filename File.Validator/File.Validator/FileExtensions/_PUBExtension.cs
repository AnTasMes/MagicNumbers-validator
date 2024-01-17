using System;
using System.Collections.Generic;
using System.Text;

namespace File.Validator.FileExtensions
{
	public class _PUBExtension : FileExtensionInfo
	{
		public override string Name => "pub";
		public override int Offset => 0;
		public override string[] Hex => new string[] {"2D-2D-2D-2D-2D-42-45-47-49-4E-20-53-53-48-32-20-4B-45-59-2D-2D-2D-2D-2D"};
	}
}