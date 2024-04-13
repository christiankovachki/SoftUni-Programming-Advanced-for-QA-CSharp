namespace _02._Articles
{
    public class Program
    {
        static void Main(string[] args)
        {
            string[] articleInfo = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).ToArray();
            string title = articleInfo[0];
            string content = articleInfo[1];
            string author = articleInfo[2];

            Article article = new Article(title, content, author);

            int numberOfCommands = int.Parse(Console.ReadLine());

            for (int i = 1; i <= numberOfCommands; i++)
            {
                string[] commandsInput = Console.ReadLine().Split(": ", StringSplitOptions.RemoveEmptyEntries).ToArray();
                string command = commandsInput[0];
                string newData = commandsInput[1];

                if (command == "Edit")
                {
                    article.Edit(newData);
                }
                else if (command == "ChangeAuthor")
                {
                    article.ChangeAuthor(newData);
                }
                else if (command == "Rename")
                {
                    article.Rename(newData);
                }
            }

            Console.WriteLine(article.ToString());
        }
    }
}