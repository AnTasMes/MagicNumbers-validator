using System;
using System.Collections.Generic;
using System.Text;

namespace File.Validator.FileExtensions
{
	public class _VMDKExtension : FileExtensionInfo
	{
		public override string Name => "vmdk";
		public override int Offset => 0;
		public override string[] Hex => new string[] {"4B-44-4D", "23-20-44-69-73-6B-20-44-65-73-63-72-69-70-74-6F"};
	}
}