using System;
using System.Collections.Generic;
using System.Text;

namespace File.Validator.FileExtensions
{
	public class _IFFExtension : FileExtensionInfo
	{
		public override string Name => "iff";
		public override int Offset => 0;
		public override string[] Hex => new string[] {"46-4F-52-4D", "49-4C-42-4D", "46-4F-52-4D", "38-53-56-58", "46-4F-52-4D", "41-43-42-4D", "46-4F-52-4D", "41-4E-42-4D", "46-4F-52-4D", "41-4E-49-4D", "46-4F-52-4D", "46-41-58-58", "46-4F-52-4D", "46-54-58-54", "46-4F-52-4D", "53-4D-55-53", "46-4F-52-4D", "43-4D-55-53", "46-4F-52-4D", "59-55-56-4E", "46-4F-52-4D", "46-41-4E-54", "46-4F-52-4D", "41-49-46-46"};
	}
}