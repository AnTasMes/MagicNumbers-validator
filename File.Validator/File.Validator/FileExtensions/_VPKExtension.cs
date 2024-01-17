using System;
using System.Collections.Generic;
using System.Text;

namespace File.Validator.FileExtensions
{
	public class _VPKExtension : FileExtensionInfo
	{
		public override string Name => "vpk";
		public override int Offset => 0;
		public override string[] Hex => new string[] {"34-12-AA-55"};
	}
}