using System;
using System.Collections.Generic;
using static System.Console;

namespace DictionariesFiles
{
  class Program
  {
    static void Main(string[] args) 
    {
      Dictionary<string, string> fileTypes = new Dictionary<string, string>();

      fileTypes.Add(".txt", "Text File");
      fileTypes.Add(".htm", "HTML Web Page");
      fileTypes.Add(".html", "HTML Web Page");
      fileTypes.Add(".css", "Cascading Style Sheet");
      fileTypes.Add(".xml", "XML Data");

      // How many key/value pairs are there?
      WriteLine($"There are {fileTypes.Count} key/values pairs\n");

			// Try adding an existing key 
			try
			{
        fileTypes.Add(".html", "Web Page");
			}
			catch (ArgumentException e)
			{
        WriteLine($"Key already exists in Dictionary\n{e.Message}\n");
			}

      // Try removing and than finding a key
      fileTypes.Remove(".css");
      WriteLine($"{nameof(fileTypes)} contains CSS: {fileTypes.ContainsKey(".css")}");
      WriteLine("Let us add it again, but by indexer");

      // Try adding key/value pair using indexer
      fileTypes[".css"] = "Cascading Style Sheet";
      WriteLine($"{nameof(fileTypes)} contains CSS: {fileTypes.ContainsKey(".css")}\n");

      // display the content of the sictionary
      WriteLine("Displaying Dictionary contents:");
      foreach (KeyValuePair<string, string> item in fileTypes)
			{
        WriteLine($"Key = {item.Key}, Value = {item.Value}");
			}

      WriteLine("\nHit Enter to continue...");
      ReadLine();
    }
  }
}
