using System;
using System.Collections.Generic;
using System.Text;

namespace File.Validator.FileExtensions
{
	public class _GRIBExtension : FileExtensionInfo
	{
		public override string Name => "grib";
		public override int Offset => 0;
		public override string[] Hex => new string[] {"47-52-49-42"};
	}
}