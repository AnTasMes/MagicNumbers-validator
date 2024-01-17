using System;
using System.Collections.Generic;
using System.Text;

namespace File.Validator.FileExtensions
{
	public class _DSPExtension : FileExtensionInfo
	{
		public override string Name => "dsp";
		public override int Offset => 0;
		public override string[] Hex => new string[] {"23-20-4D-69-63-72-6F-73-6F-66-74-20-44-65-76-65-6C-6F-70-65-72-20-53-74-75-64-69-6F"};
	}
}