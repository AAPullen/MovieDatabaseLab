using MovieDatabase;

List<Movie> movieList = new List<Movie>()
{
    new Movie(){ Title = "The Thing", Category = "horror", Runtime = 109, Year = 1982 },
    new Movie(){ Title = "Evil Dead 2", Category = "horror", Runtime = 85, Year = 1987 },
    new Movie(){ Title = "Midsommar", Category = "horror", Runtime = 171, Year = 2019 },
    new Movie(){ Title = "Mandy", Category = "horror", Runtime = 120, Year = 2018 },
    new Movie(){ Title = "In the Mouth of Madness", Category = "horror", Runtime = 95, Year = 1994 },
    new Movie(){ Title = "Princess Mononoke", Category = "animated", Runtime = 133, Year = 1997 },
    new Movie(){ Title = "Mad God", Category = "animated", Runtime = 83, Year = 2021 },
    new Movie(){ Title = "Fantastic Planet", Category = "animated", Runtime = 72, Year = 1973 },
    new Movie(){ Title = "The Hateful Eight", Category = "drama", Runtime = 175, Year = 2015 },
    new Movie(){ Title = "Seven Samurai", Category = "drama", Runtime = 158, Year = 1954 },
    new Movie(){ Title = "Blade Runner", Category = "scifi", Runtime = 110, Year = 1982 },
    new Movie(){ Title = "Annihilation", Category = "scifi", Runtime = 120, Year = 2018 },
    new Movie(){ Title = "Dune", Category = "scifi", Runtime = 155, Year = 2021 },
    new Movie(){ Title = "Johnny Mnemonic", Category = "scifi", Runtime = 96, Year = 1995 },
    new Movie(){ Title = "The Matrix", Category = "scifi", Runtime = 136, Year = 1999 }
};

Console.Write("Welcome to the Movie Database! ");

string answer;
do
{
    Console.Write("Please enter one of the following categories to view a list of movies in that category.\n" +
        "animated, drama, horror, scifi: ");

    bool isCategory = false;
    string userCategory;
    do
    {
        userCategory = Console.ReadLine().ToLower();
        if (userCategory == "animated" || userCategory == "drama" || userCategory == "horror" || userCategory == "scifi")
        {
            Console.WriteLine();
            isCategory = true;
        }
        else
        {
            Console.Write("\nI'm sorry, that is not a valid selection. Please enter one of the following categories. \n" +
                "animated, drama, horror, scifi: ");
        }
    } while (isCategory == false);

    List<Movie> userList = new List<Movie>();
    foreach (Movie film in movieList)
    {
        if (userCategory == film.Category)
        {
            userList.Add(film);
        }
        
    }

    foreach (Movie item in userList)
    {
        Console.WriteLine($"Title: {item.Title}\nRuntime: {item.Runtime} minutes\nYear Released: {item.Year}\n");
    }

    do
    {
        Console.Write("Continue (y/n)? ");
        answer = Console.ReadLine();
        if (answer != "y" && answer != "n")
        {
            Console.WriteLine("\nI'm sorry, that is not a valid response.\n");
        }
    } while (answer != "y" && answer != "n");

    Console.WriteLine();

} while (answer == "y");

Console.WriteLine("Goodbye!");