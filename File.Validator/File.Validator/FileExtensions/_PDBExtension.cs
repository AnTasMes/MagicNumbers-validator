using System;
using System.Collections.Generic;
using System.Text;

namespace File.Validator.FileExtensions
{
	public class _PDBExtension : FileExtensionInfo
	{
		public override string Name => "PDB";
		public override int Offset => 11;
		public override string[] Hex => new string[] {"00-00-00-00-00-00-00-00", "00-00-00-00-00-00-00-00", "00-00-00-00-00-00-00-00"};
	}
}