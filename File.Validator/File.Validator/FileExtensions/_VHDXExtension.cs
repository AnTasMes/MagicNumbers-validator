using System;
using System.Collections.Generic;
using System.Text;

namespace File.Validator.FileExtensions
{
	public class _VHDXExtension : FileExtensionInfo
	{
		public override string Name => "vhdx";
		public override int Offset => 0;
		public override string[] Hex => new string[] {"76-68-64-78-66-69-6C-65"};
	}
}