using System;
using System.Collections.Generic;
using System.Text;

namespace File.Validator.FileExtensions
{
	public class _VDIExtension : FileExtensionInfo
	{
		public override string Name => "vdi";
		public override int Offset => 0;
		public override string[] Hex => new string[] {"3C-3C-3C-20-4F-72-61-63", "6C-65-20-56-4D-20-56-69", "72-74-75-61-6C-42-6F-78", "20-44-69-73-6B-20-49-6D", "61-67-65-20-3E-3E-3E"};
	}
}