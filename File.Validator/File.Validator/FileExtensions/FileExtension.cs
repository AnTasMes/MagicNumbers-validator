using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace File.Validator.FileExtensions
{
    public abstract class FileExtensionInfo
    {
        public abstract string Name { get; }
        public abstract int Offset { get; }
        public abstract string[] Hex { get; }

        public virtual bool IsValid (BinaryReader reader)
        {
            // Postavi offset
            reader.BaseStream.Seek(this.Offset, SeekOrigin.Begin);

            // Izvlaci broj bajtova u najduzem hex potpisu
            string longestSignature = this.Hex.OrderByDescending(h => h.Length).First();
            int longestSignatureLen = Regex.Matches(longestSignature, "[a-zA-Z0-9][a-zA-Z0-9]").Count;

            // Procitaj N bajtova iz niza
            byte[] data = reader.ReadBytes(longestSignatureLen);
            string data_as_hex = BitConverter.ToString(data);
            reader.Close();

            // Proveriti da li data_as_hex poseduje neki do potpisa u nizu
            return this.Hex.Any(h => data_as_hex.Contains(h));
        }
    }
}
