using System;
using System.Collections.Generic;
using System.Text;

namespace File.Validator.FileExtensions
{
	public class _JPCExtension : FileExtensionInfo
	{
		public override string Name => "jpc";
		public override int Offset => 0;
		public override string[] Hex => new string[] {"FF-4F-FF-51"};
	}
}