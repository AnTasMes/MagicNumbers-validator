using System;
using System.Collections.Generic;
using System.Text;

namespace File.Validator.FileExtensions
{
	public class _BPGExtension : FileExtensionInfo
	{
		public override string Name => "bpg";
		public override int Offset => 0;
		public override string[] Hex => new string[] {"42-50-47-FB"};
	}
}