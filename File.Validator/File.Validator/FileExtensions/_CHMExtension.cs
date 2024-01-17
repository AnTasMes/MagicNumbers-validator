using System;
using System.Collections.Generic;
using System.Text;

namespace File.Validator.FileExtensions
{
	public class _CHMExtension : FileExtensionInfo
	{
		public override string Name => "chm";
		public override int Offset => 0;
		public override string[] Hex => new string[] {"49-54-53-46-03-00-00-00", "60-00-00-00"};
	}
}