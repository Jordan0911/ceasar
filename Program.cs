namespace ceasar
{
    internal class Program
    {
        static string Ceasar_code(string words, char[] alphabet,int key)
        {
            char[] letters = words.ToCharArray();
            for (int i = 0; i < letters.Length; i++)
            {
                for (int j = 0; j < alphabet.Length; j++)
                {
                    if(letters[i] == alphabet[j])
                    {
                        if (j + key < 27)
                        {
                            letters[i] = alphabet[j + key];
                        }
                        else if (j+key > 26)
                        {
                            letters[i]=alphabet[(j+key)-26];
                        }
                    }
                } 
            }
            string result = new string(letters);
            return result;
        }
        static void Main(string[] args)
        {
            
            Console.WriteLine("please insert the word");
           string  word = Console.ReadLine();
            Console.WriteLine("insert the key");
            int key = Convert.ToInt32(Console.ReadLine());
            char[] alphabet = { 'a', 'b', 'c','d','e','f','g','h','i','j','k','l','m', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };
            Console.WriteLine(Ceasar_code(word, alphabet, key));
            
        }
    }
    
}
