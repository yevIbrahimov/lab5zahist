using System.IO;

namespace Lab5Ibrahimov
{
    class Text
    {
        public string GetText(string path)
        {
            string text;
            using (StreamReader sr = new StreamReader(path))
            {
                text = sr.ReadToEnd();
            }

            return text;
        }
    }
}
