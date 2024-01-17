using System;
using System.Collections.Generic;
using System.Text;

namespace File.Validator.FileExtensions
{
	public class _BACExtension : FileExtensionInfo
	{
		public override string Name => "bac";
		public override int Offset => 0;
		public override string[] Hex => new string[] {"42-41-43-4B-4D-49-4B-45", "44-49-53-4B"};
	}
}