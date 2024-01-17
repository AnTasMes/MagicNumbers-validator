using System;
using System.Collections.Generic;
using System.Text;

namespace File.Validator.FileExtensions
{
	public class _DMGExtension : FileExtensionInfo
	{
		public override string Name => "dmg";
		public override int Offset => 0;
		public override string[] Hex => new string[] {"6B-6F-6C-79"};
	}
}