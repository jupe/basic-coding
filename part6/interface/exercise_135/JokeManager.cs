using System;
using System.Collections.Generic;
public class JokeManager
{
    List<string> jokes = new List<string>();


    public void AddJokes(string joke)
    {
        this.jokes.Add(joke);
    }

    public string DrawJoke()
    {
        Random draw = new Random();
        int index = draw.Next(0, jokes.Count);
        return (jokes[index]);
    }

    public void PrintJokes()
    {
        foreach (string joke in jokes)
        {
            Console.WriteLine(joke);
        }
    }
}

