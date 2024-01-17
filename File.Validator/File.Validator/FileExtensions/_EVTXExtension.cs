using System;
using System.Collections.Generic;
using System.Text;

namespace File.Validator.FileExtensions
{
	public class _EVTXExtension : FileExtensionInfo
	{
		public override string Name => "evtx";
		public override int Offset => 0;
		public override string[] Hex => new string[] {"45-6C-66-46-69-6C-65"};
	}
}