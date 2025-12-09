namespace ceasar
{
    internal class Program
    {
        static string Position_drag(string word, int key)
        {
            char[] letters = word.ToCharArray();
            char[] dragged = new char[letters.Length];
            bool outw = false;
            int s = 1;
            for (int i = 0; i < letters.Length; i++)
            {
                outw = false;

                while (outw == false)
                {
                    if (i < letters.Length)
                    {
                        dragged[s] = letters[i];
                        outw = true;

                    }
                    else if (s == letters.Length)
                    {
                        dragged[0] = letters[i];
                        outw = true;
                    }
                    s++;
                }
            }
            string result = new string(dragged);
            return result;

        }



        static string Ceasar_code(string word, char[] alphabet, int key)
        {
            char[] letters = word.ToCharArray();
            int j = 0;
            bool outw = false;
            for (int i = 0; i < letters.Length; i++)
            {
                if (key > 0)
                {
                    j = 0;
                    outw = false;
                    while (outw == false)
                    {
                        if (letters[i] == alphabet[j])
                        {
                            if (j + key < alphabet.Length)
                            {
                                letters[i] = alphabet[j + key];
                                outw = true;
                            }
                            else
                            {
                                letters[i] = alphabet[(j + key) - alphabet.Length];
                                outw = true;
                            }
                        }
                        j++;
                    }
                }
                else
                {
                    j = 0;
                    outw = false;
                    while (outw == false)
                    {
                        if (letters[i] == alphabet[j])
                        {
                            if (j + key > 0)
                            {
                                letters[i] = alphabet[j + key];
                                outw = true;
                            }
                            else
                            {
                                letters[i] = alphabet[(j + key) + alphabet.Length];
                                outw = true;
                            }
                        }
                        j++;
                    }
                }
            }
            string result = new string(letters);
            return result;
        }
        static void Main(string[] args)
        {

            Console.WriteLine("please insert the word");
            string word = Console.ReadLine();
            Console.WriteLine("insert the key");
            int key = Convert.ToInt32(Console.ReadLine());
            char[] alphabet = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };
            Console.WriteLine(Ceasar_code(word, alphabet, key));
            Console.WriteLine(Position_drag(word, key));

        }


    }
}
