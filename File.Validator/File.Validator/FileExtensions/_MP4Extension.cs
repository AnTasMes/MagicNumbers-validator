using System;
using System.Collections.Generic;
using System.Text;

namespace File.Validator.FileExtensions
{
	public class _MP4Extension : FileExtensionInfo
	{
		public override string Name => "mp4";
		public override int Offset => 4;
		public override string[] Hex => new string[] {"66-74-79-70-69-73-6F-6D", "66-74-79-70-4D-53-4E-56"};
	}
}