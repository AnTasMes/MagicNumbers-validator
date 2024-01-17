using System;
using System.Collections.Generic;
using System.Text;

namespace File.Validator.FileExtensions
{
	public class _SNDExtension : FileExtensionInfo
	{
		public override string Name => "snd";
		public override int Offset => 0;
		public override string[] Hex => new string[] {"46-4F-52-4D", "38-53-56-58", "46-4F-52-4D", "41-49-46-46", "2E-73-6E-64"};
	}
}