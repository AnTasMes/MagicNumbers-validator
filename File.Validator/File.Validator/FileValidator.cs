using File.Validator;
using File.Validator.FileExtensions;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text.RegularExpressions;

namespace File.Validator
{
    public class FileValidator
    {
        private static List<FileExtensionInfo?> _extensions = new List<FileExtensionInfo?>();

        /// <summary>
        /// Proverava da li fajl u Stream-u poseduje zaglavlje koje odgovara prosledjenoj ekstenziji.
        /// Ovu metodu je moguce pozivati nezavisno u bilo kom delu koda.
        /// Trenutno se poziva iz Middleware-a u Web
        /// </summary>
        /// <param name="stream">MemoryStream fajla</param>
        /// <param name="expectedExtension">Ekstenzija u odnosu na koju se proverava validnost</param>
        /// <returns>Potvrda da li je zaglavlje vazece</returns>
        /// <exception cref="ArgumentException">Ako je ektenzija prazna</exception>
        /// <exception cref="ArgumentNullException">Ako je stream null</exception>
        public static bool isValidExtension(Stream stream, string expectedExtension)
        {
            if (string.IsNullOrEmpty(expectedExtension))
                throw new ArgumentException("Expected extension must have value");


            if (stream == null)
                throw new ArgumentNullException("StreamReader must not be null");

            // Ukloni tacku, ako postoji i postavimo na lowercase
            expectedExtension = expectedExtension.Replace(".", "");
            expectedExtension = expectedExtension.ToLower();

            BinaryReader reader = new BinaryReader(stream);

            FileExtensionInfo? fileExtensionInfo = getExtensionInfo(expectedExtension);

            if (fileExtensionInfo == null)
                return false;

            // Postavi offset
            reader.BaseStream.Seek(fileExtensionInfo.Offset, SeekOrigin.Begin);

            // Izvlaci broj bajtova u najduzem hex potpisu
            string longestSignature = fileExtensionInfo.Hex.OrderByDescending(h => h.Length).First();
            int longestSignatureLen = Regex.Matches(longestSignature, "[a-zA-Z0-9][a-zA-Z0-9]").Count;

            // Procitaj N bajtova iz niza
            byte[] data = reader.ReadBytes(longestSignatureLen);   
            string data_as_hex = BitConverter.ToString(data);
            reader.Close();

            // Proveriti da li data_as_hex poseduje neki do potpisa u nizu
            return fileExtensionInfo.Hex.Any(h => data_as_hex.Contains(h));
        }

        /// <summary>
        /// Cuva listu ekstenzija za poredjenje i vraca informacije o zeljenoj.
        /// Ako je lista klasa puna, nece se ucitavati ponovo, radi brzine
        /// </summary>
        /// <param name="extension">Naziv ekstenzije bez tacke</param>
        /// <returns></returns>
        private static FileExtensionInfo? getExtensionInfo(string extension)
        {
            // Dodavanje ekstenzija u cache, ako je prazan
            if (_extensions.Count == 0)
            {
                Assembly myAssembly = Assembly.GetExecutingAssembly();

                foreach(Type fileExtensionInfo in myAssembly.GetTypes())
                {
                    if (fileExtensionInfo.IsSubclassOf(typeof(FileExtensionInfo))) 
                        _extensions.Add(Activator.CreateInstance(fileExtensionInfo) as FileExtensionInfo);
                }
            }

            // Vrati bilo koji fajl koji poseduje HEX vrednost i 
            return _extensions.FirstOrDefault(ext => ext != null && ext.Name.Equals(extension));
        }
    }
}
