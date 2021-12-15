namespace Lab5Ibrahimov
{
    class Coder: CryptSettings
    {
        public string Encode(string text, string key = "crypto1234crypto", string vector = "thermoAAAAthermo")
        {
            Crypt.SetEncodedIV(vector, "ascii");
            Crypt.SetEncodedKey(key, "ascii");

            return Crypt.EncryptStringENC(text);
        }
    }
}
