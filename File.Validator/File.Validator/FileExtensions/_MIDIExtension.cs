using System;
using System.Collections.Generic;
using System.Text;

namespace File.Validator.FileExtensions
{
	public class _MIDIExtension : FileExtensionInfo
	{
		public override string Name => "midi";
		public override int Offset => 0;
		public override string[] Hex => new string[] {"4D-54-68-64"};
	}
}