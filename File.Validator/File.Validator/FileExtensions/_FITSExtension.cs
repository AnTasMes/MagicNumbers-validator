using System;
using System.Collections.Generic;
using System.Text;

namespace File.Validator.FileExtensions
{
	public class _FITSExtension : FileExtensionInfo
	{
		public override string Name => "fits";
		public override int Offset => 0;
		public override string[] Hex => new string[] {"53-49-4D-50-4C-45-20-20", "3D-20-20-20-20-20-20-20", "20-20-20-20-20-20-20-20", "20-20-20-20-20-54"};
	}
}