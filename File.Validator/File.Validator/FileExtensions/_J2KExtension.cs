using System;
using System.Collections.Generic;
using System.Text;

namespace File.Validator.FileExtensions
{
	public class _J2KExtension : FileExtensionInfo
	{
		public override string Name => "j2k";
		public override int Offset => 0;
		public override string[] Hex => new string[] {"FF-4F-FF-51"};
	}
}