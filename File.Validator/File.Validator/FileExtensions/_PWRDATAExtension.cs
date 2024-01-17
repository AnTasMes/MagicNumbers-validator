using System;
using System.Collections.Generic;
using System.Text;

namespace File.Validator.FileExtensions
{
	public class _PWRDATAExtension : FileExtensionInfo
	{
		public override string Name => "pwrdata";
		public override int Offset => 0;
		public override string[] Hex => new string[] {"70-77-72-64-61-74-61"};
	}
}