using System;
using System.Collections.Generic;
using System.Text;

namespace File.Validator.FileExtensions
{
	public class _MP3Extension : FileExtensionInfo
	{
		public override string Name => "mp3";
		public override int Offset => 0;
		public override string[] Hex => new string[] {"FF-FB", "FF-F3", "FF-F2", "49-44-33"};
	}
}