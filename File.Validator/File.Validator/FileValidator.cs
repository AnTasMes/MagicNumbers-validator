using File.Validator.FileExtensions;
using System.Reflection;

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

            return fileExtensionInfo.IsValid(reader);
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
