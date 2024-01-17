using System;
using System.Collections.Generic;
using System.Text;

namespace File.Validator.FileExtensions
{
	public class _HL7Extension : FileExtensionInfo
	{
		public override string Name => "hl7";
		public override int Offset => 0;
		public override string[] Hex => new string[] {"4D-53-48-7C", "42-53-48-7C"};
	}
}