using System;
using System.Collections.Generic;
using System.Text;

namespace File.Validator.FileExtensions
{
	public class _EPSFExtension : FileExtensionInfo
	{
		public override string Name => "epsf";
		public override int Offset => 0;
		public override string[] Hex => new string[] {"25-21-50-53-2D-41-64-6F-62-65-2D-33-2E-30-20-45-50-53-46-2D-33-2E-30", "25-21-50-53-2D-41-64-6F-62-65-2D-33-2E-31-20-45-50-53-46-2D-33-2E-30"};
	}
}