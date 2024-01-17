using System;
using System.Collections.Generic;
using System.Text;

namespace File.Validator.FileExtensions
{
	public class _QCPExtension : FileExtensionInfo
	{
		public override string Name => "qcp";
		public override int Offset => 0;
		public override string[] Hex => new string[] {"52-49-46-46", "51-4C-43-4D"};
	}
}