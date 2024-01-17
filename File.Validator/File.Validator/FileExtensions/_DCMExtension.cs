using System;
using System.Collections.Generic;
using System.Text;

namespace File.Validator.FileExtensions
{
	public class _DCMExtension : FileExtensionInfo
	{
		public override string Name => "dcm";
		public override int Offset => 128;
		public override string[] Hex => new string[] {"44-49-43-4D"};
	}
}