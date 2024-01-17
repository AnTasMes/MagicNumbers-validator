using System;
using System.Collections.Generic;
using System.Text;

namespace File.Validator.FileExtensions
{
	public class _TARExtension : FileExtensionInfo
	{
		public override string Name => "tar";
		public override int Offset => 257;
		public override string[] Hex => new string[] {"75-73-74-61-72-00-30-30", "75-73-74-61-72-20-20-00"};
	}
}