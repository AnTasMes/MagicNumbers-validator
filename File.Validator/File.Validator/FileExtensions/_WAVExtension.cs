using System;
using System.Collections.Generic;
using System.Text;

namespace File.Validator.FileExtensions
{
	public class _WAVExtension : FileExtensionInfo
	{
		public override string Name => "wav";
		public override int Offset => 0;
		public override string[] Hex => new string[] {"52-49-46-46", "57-41-56-45"};
	}
}