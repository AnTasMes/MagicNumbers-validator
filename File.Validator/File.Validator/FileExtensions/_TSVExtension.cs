using System;
using System.Collections.Generic;
using System.Text;

namespace File.Validator.FileExtensions
{
	public class _TSVExtension : FileExtensionInfo
	{
		public override string Name => "tsv";
		public override int Offset => 0;
		public override string[] Hex => new string[] {"47"};
	}
}