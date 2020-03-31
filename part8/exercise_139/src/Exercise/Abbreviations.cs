using System.Collections.Generic;

namespace Exercise
{
  public class Abbreviations
  {
    // add dictionary for abbrevs
    private Dictionary<string, string> abbrevs;

    //add empty constructor
    public Abbreviations()
    {
      this.abbrevs = new Dictionary<string,string>();
    }

    //add to abbrevs
    public void AddAbbreviation(string abbreviation, string explanation)
    {
      this.abbrevs.Add(abbreviation, explanation);
    }

    //check if abbrevs contain give string
    public bool HasAbbreviation(string abbreviation)
    {
      if (this.abbrevs.ContainsKey(abbreviation))
      { 
        return true;
      }
      else
      {
        return false;
      }
    }

    //return abbrev, if none return not found
    public string FindExplanationFor(string abbreviation)
    {
      if (HasAbbreviation(abbreviation))
    {
      return abbrevs[abbreviation];
    }
    else
    {
      return "not found";
    }
    }
  }
}