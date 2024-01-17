using System;
using System.Collections.Generic;
using System.Text;

namespace File.Validator.FileExtensions
{
	public class _SEAExtension : FileExtensionInfo
	{
		public override string Name => "SEA";
		public override int Offset => 0;
		public override string[] Hex => new string[] {"00"};
	}
}