using System;
using System.Collections.Generic;
using System.Text;

namespace File.Validator.FileExtensions
{
	public class _LEPExtension : FileExtensionInfo
	{
		public override string Name => "lep";
		public override int Offset => 0;
		public override string[] Hex => new string[] {"CF-84-01"};
	}
}