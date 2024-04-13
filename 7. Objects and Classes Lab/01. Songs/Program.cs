namespace _01._Songs
{
    internal class Song
    {
        public string TypeList { get; set; }
        public string Name { get; set; }
        public string Time { get; set; }

        public Song() { }

        public Song(string typeList, string name, string time)
        {
            TypeList = typeList;
            Name = name;
            Time = time;
        }

        internal class Program
        {
            static void Main(string[] args)
            {
                int numberOfSongs = int.Parse(Console.ReadLine());

                List<Song> songs = new List<Song>();

                for (int i = 1; i <= numberOfSongs; i++)
                {
                    string[] input = Console.ReadLine().Split("_").ToArray();
                    string typeList = input[0];
                    string name = input[1];
                    string time = input[2];

                    Song song = new Song(typeList, name, time);

                    songs.Add(song);
                }

                string outputCommand = Console.ReadLine();

                if (!outputCommand.Equals("all"))
                {
                    songs = songs.Where(t => t.TypeList.Equals(outputCommand)).ToList();
                }

                songs.ForEach(s => Console.WriteLine(s.Name));
            }
        }
    }
}