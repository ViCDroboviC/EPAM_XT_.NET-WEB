namespace General
{
    public class Text
    {
        public int Length
        {
            get
            {
               return symbols.Length;
            }
        }

        private char[] symbols; 

        public Text (params char[] symbols)
        {
            this.symbols = new char[symbols.Length];
            symbols.CopyTo(this.symbols, 0);
        } 

        public Text (string str)
        {
            var charArrayString = str.ToCharArray();
            this.symbols = new char[charArrayString.Length];
            charArrayString.CopyTo(this.symbols, 0);
        }

        public static Text operator + (Text text1, Text text2)
        {
            char[] combinedText = new char[text1.Length + text2.Length];
            text1.symbols.CopyTo(combinedText, 0);
            text2.symbols.CopyTo(combinedText, text1.Length);
            var newText = new Text(combinedText);
            return newText;
        }

        public static bool operator == (Text text1, Text text2)
        {
            for (int i = 0; i < text1.Length; i++)
            {
                if (text1.symbols[i] != text2.symbols[i])
                {
                    return false;
                }
            }
            return true;
            //return text1.symbols.Equals(text2.symbols);
        }

        public static bool operator != (Text text1, Text text2)
        {
            for (int i = 0; i < text1.Length; i++)
            {
                if (text1.symbols[i] != text2.symbols[i])
                {
                    return true;
                }               
            }
            return false;
            //return !text1.symbols.Equals(text2.symbols);
        }

        public static implicit operator string (Text text)
        {
            string newString = text.ToString();
            return newString;
        }

        public static implicit operator char[] (Text text)
        {
            var newCharArray = new char[text.symbols.Length];
            text.symbols.CopyTo(newCharArray, 0);
            return newCharArray;
        }

        public override string ToString()
        {
            string str = new string (symbols);
            return str;
        }

        public void Find (char symbol)
        {
            int index = 0;
            foreach (char sym in symbols)
            {
                index++;
                if (sym == symbol)
                {
                    ConsoleHelper.Write($"Text contains '{symbol}' on {index} position.");
                    break;
                }
            }
        }

        public void Find(char symbol, ref int index)
        {
            int i = 0;
            foreach (char sym in symbols)
            {
                i++;
                if (sym == symbol)
                {
                    index = i;
                    ConsoleHelper.Write($"Text contains '{symbol}' on {index} position.");
                    break;
                }
            }
        }
    }
}
