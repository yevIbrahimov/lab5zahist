namespace Lab5Ibrahimov
{
    class Decoder : CryptSettings
    {
        public string Decode(string text, string key = "crypto1234crypto", string vector = "thermoAAAAthermo")
        {
            Crypt.SetEncodedIV(vector, "ascii");
            Crypt.SetEncodedKey(key, "ascii");

            return Crypt.DecryptStringENC(text);
        }
    }
}
