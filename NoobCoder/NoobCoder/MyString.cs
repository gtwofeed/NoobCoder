namespace NoobCoder
{
    internal class MyString
    {
        string phrase;
        internal string Phrase
        {
            get { return phrase; }
            set { phrase = value; }
        }
        internal MyString(string phrase = "hello")
        {
            Phrase = phrase;
            Phrase = phrase;
        }
        internal string Reverse()
        {
            string result = "";
            for (int i = 1; i <= Phrase.Length; i++)
            {
                result += Phrase[^i];
            }
            return result;
        }
        internal string UcFirst()
        {
            string usFirst = "";
            for (int i = 0; i < Phrase.Length; i++)
            {
                if (i == 0)
                {
                    usFirst += Phrase[i];
                    usFirst = usFirst.ToUpper();
                }
                else usFirst += Phrase[i];
            }
            return usFirst;
        }
        internal string UcWords()
        {
            string usWords = "";
            string[] strings = Phrase.Split(' ');
            foreach (var item in strings)
            {
                string temp = "";
                for (int i = 0; i < item.Length; i++)
                {
                    if (i == 0)
                    {
                        temp += item[i];
                        temp = temp.ToUpper();
                    }
                    else temp += item[i];
                }
                usWords += temp + " ";
            }
            return usWords;
        }
    }
}
