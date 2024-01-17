using System;
using System.Collections.Generic;
using System.Text;

namespace File.Validator.FileExtensions
{
	public class _VHDExtension : FileExtensionInfo
	{
		public override string Name => "vhd";
		public override int Offset => 0;
		public override string[] Hex => new string[] {"63-6F-6E-6E-65-63-74-69", "78"};
	}
}