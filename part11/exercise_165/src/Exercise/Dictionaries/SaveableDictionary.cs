namespace Exercise
{
  using System;
  using System.IO;
  using System.Collections.Generic;
  public class SaveableDictionary
  {
    private Dictionary<string, string> dictionary;
    private string file;
    string word { get; set; }
    string translation { get; set; }
    public SaveableDictionary()
    {
      this.dictionary = new Dictionary<string, string>();
    }

    public SaveableDictionary(string file) : this()
    {
      this.file = file;
    }

    public void Add(string word, string translation)
    {
      this.word = word;
      this.translation = translation;
      if (!this.dictionary.ContainsKey(word)) 
        {
            this.dictionary.Add(word, translation);
        }   
    }

    public bool Load()
    {
      try
      {
        string[] lines = File.ReadAllLines(this.file);
        foreach (string line in lines)
        {
          string[] parts = line.Split(":");
          this.dictionary.Add(parts[0], parts[1]);
        }
        return true;
      }
      catch (Exception e)
      {
        Console.WriteLine(e.Message);
        return false;
      }
    }
    
    public bool Save()
    {
      return false;
    }

    public string Translate(string word)
    {
      if (this.dictionary.ContainsKey(word))
      {
        return this.dictionary[word];
      }
      foreach (KeyValuePair<string, string> words in this.dictionary)
      {
        if (words.Value == word)
        {
          return words.Key;
        }
      }
      return null;
    }
      

    public void Delete(string word)
    {
      foreach (KeyValuePair <string, string> words in this.dictionary)
      {
        if (words.Key == word | words.Value == word)
        {
          this.dictionary.Remove(words.Key);
        }
      }
    }
  }
}

