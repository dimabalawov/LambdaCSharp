namespace Anonymous_methods
{
    class MainClass
    {
        delegate bool DoesContain(string x, string word);
        static void Main(string[] args)
        {
            string x = "Это пример текста для проверки наличия слова.";

            string word = "проверки";

            Func<string, string, bool> containsWord = (x, word) => x.Contains(word);
            bool result = containsWord(x, word);
            Console.WriteLine("Есть ли слово: " + result);

        }
    }
}