using HexagonalThis.Domain;
using HexagonalThis.Infra;

// 1. Instantiate right-side adapter(s) ("I want to go outside the hexagon")
var fileAdapter = new PoetryLibraryFileAdapter(@".\Rimbaud.txt");

// 2. Instantiate the hexagon
var poetryReader = new PoetryReader(fileAdapter);

// 3. Instantiate the left-side adapter(s) ("I want ask/to go inside the hexagon")
var consoleAdapter = new ConsoleAdapter(poetryReader);

System.Console.WriteLine("Here is some...");
consoleAdapter.Ask();

System.Console.WriteLine("Type enter to exit...");
System.Console.ReadLine();
