namespace Lab5Ibrahimov
{
    class Program
    {
        private static readonly string _path = @"D:\Zahist\lab5\Lab5Ibrahimov\Lab5Ibrahimov\Texts\TextFile1.txt";

        static void Main(string[] args)
        {
            var textToDecode = new Text().GetText(_path);
            var decodedText = new Decoder().Decode(textToDecode);
            var encodedText = new Coder().Encode(decodedText);

        }
    }
}
