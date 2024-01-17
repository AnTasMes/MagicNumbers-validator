using System;
using System.Collections.Generic;
using System.Text;

namespace File.Validator.FileExtensions
{
	public class _ODSExtension : FileExtensionInfo
	{
		public override string Name => "ods";
		public override int Offset => 0;
		public override string[] Hex => new string[] {"50-4B-03-04", "50-4B-05-06", "50-4B-07-08"};
	}
}