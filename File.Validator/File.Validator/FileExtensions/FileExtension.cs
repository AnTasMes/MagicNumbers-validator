using System;
using System.Collections.Generic;
using System.Text;

namespace File.Validator.FileExtensions
{
    public abstract class FileExtensionInfo
    {
        public abstract string Name { get; }
        public abstract int Offset { get; }
        public abstract string[] Hex { get; }
    }
}
