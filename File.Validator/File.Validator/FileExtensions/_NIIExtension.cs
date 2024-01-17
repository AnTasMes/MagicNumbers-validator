using System;
using System.Collections.Generic;
using System.Text;

namespace File.Validator.FileExtensions
{
	public class _NIIExtension : FileExtensionInfo
	{
		public override string Name => "nii";
		public override int Offset => 344;
		public override string[] Hex => new string[] {"6E-2B-31-00"};
	}
}