using Chilkat;

namespace Lab5Ibrahimov
{
    abstract class CryptSettings
    {
        public static Crypt2 Crypt { get; } = new Crypt2()
        {
            CryptAlgorithm = "aes",
            CipherMode = "ctr",
            KeyLength = 256,
            EncodingMode = "base64",
        };
    }
}
