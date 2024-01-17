using System;
using System.Collections.Generic;
using System.Text;

namespace File.Validator.FileExtensions
{
	public class _NRIExtension : FileExtensionInfo
	{
		public override string Name => "nri";
		public override int Offset => 0;
		public override string[] Hex => new string[] {"0E-4E-65-72-6F-49-53-4F"};
	}
}