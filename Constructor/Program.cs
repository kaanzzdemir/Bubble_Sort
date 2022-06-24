using Constructor;

Movie m = new Movie(1, "Dabbe 3", "Korku");
Movie m2 = new Movie() { MovieGenre = "Korku", MovieId = 2, MovieName = "Dabbe 2" };

Console.WriteLine(m.MovieName);
class Movie
{
    //Configure and apply with the overload method.
    public Movie()
    {

    }
    public Movie(int movieId, string movieName, string movieGenre)
    {

    }

    public int MovieId { get; set; }
    public string MovieName { get; set; }
    public string MovieGenre { get; set; }
}