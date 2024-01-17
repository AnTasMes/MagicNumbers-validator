using System;
using System.Collections.Generic;
using System.Text;

namespace File.Validator.FileExtensions
{
	public class _MIDExtension : FileExtensionInfo
	{
		public override string Name => "mid";
		public override int Offset => 0;
		public override string[] Hex => new string[] {"4D-54-68-64"};
	}
}