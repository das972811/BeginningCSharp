namespace Treehouse.MediaLibrary
{
    class Movie
    {
        public readonly string Title;
        public readonly string Director;
        public readonly string Actors;
        public readonly string Producers;

        public Movie(string title, string director, string actors, string producers)
        {
            Title = title;
            Director = director;
            Actors = actors;
            Producers = producers;
        }
    }
}