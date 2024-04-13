namespace _02._Articles
{
    public class Article
    {
        private string _title;
        private string _content;
        private string _author;

        public string Title { get => _title; set => _title = value; }
        public string Content { get => _content; set => _content = value; }
        public string Author { get => _author; set => _author = value; }

        public Article() { }

        public Article(string title, string content, string author)
        {
            Title = title;
            Content = content;
            Author = author;
        }

        public void Edit(string newContent)
        { 
            Content = newContent;
        }

        public void ChangeAuthor(string newAuthor)
        { 
            Author = newAuthor;
        }

        public void Rename(string newTitle)
        { 
            Title = newTitle;
        }

        public override string ToString() 
        {
            return $"{Title} - {Content}: {Author}";
        }
    }
}