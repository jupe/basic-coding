namespace Exercise
{
  
  using System.IO;
  public class Program
  {
    public static void Main(string[] args)
    {

      using (StreamWriter writer = new StreamWriter("file.txt"))
      {
        writer.WriteLine("Hello file!"); //writes the string "Hello file!" and line change to the file
        writer.WriteLine("More text");
        writer.WriteLine("And a little extra"); // writes the string "And a little extra" to the file without a line change
      }// closes the file
    }
  }
}
