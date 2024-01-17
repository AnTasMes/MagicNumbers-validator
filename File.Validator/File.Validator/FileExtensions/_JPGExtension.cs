using System;
using System.Collections.Generic;
using System.Text;

namespace File.Validator.FileExtensions
{
	public class _JPGExtension : FileExtensionInfo
	{
		public override string Name => "jpg";
		public override int Offset => 0;
		public override string[] Hex => new string[] {"FF-D8-FF-DB", "FF-D8-FF-E0-00-10-4A-46", "49-46-00-01", "FF-D8-FF-EE", "FF-D8-FF-E1-45-78", "69-66-00-00", "FF-D8-FF-E0"};
	}
}