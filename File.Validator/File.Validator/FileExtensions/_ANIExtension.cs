using System;
using System.Collections.Generic;
using System.Text;

namespace File.Validator.FileExtensions
{
	public class _ANIExtension : FileExtensionInfo
	{
		public override string Name => "ani";
		public override int Offset => 0;
		public override string[] Hex => new string[] {"52-49-46-46", "41-43-4F-4E"};
	}
}