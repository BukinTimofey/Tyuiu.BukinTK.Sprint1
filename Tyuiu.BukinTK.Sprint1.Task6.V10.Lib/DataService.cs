using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.BukinTK.Sprint1.Task6.V10.Lib
{
    public class DataService : ISprint1Task6V10
    {
        public string DeleteMiddleLetter(string value)
        {
            string[] words = value.Split(' ');
            string endWord = "";
            for (int i = 0; i < words.Length; i++)
            {
                string word = words[i];
                if (word.Length % 2 == 1 && word.Length > 1)
                {
                    int middleLatter = word.Length / 2;
                    string newWord = word.Remove(middleLatter, 1);
                    endWord += newWord;
                }
                else
                {
                    endWord += word;
                }
                if (i < words.Length - 1)
                {
                    endWord += " ";
                }
            }
            return endWord;
        }
    }
}
