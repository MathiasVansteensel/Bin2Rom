using Microsoft.VisualBasic.FileIO;
using Scrap_mechanic_ROM_builder__BIN_2_ROM_;
using System;
using System.Collections;
using System.Collections.Specialized;
using System.IO;
using System.Net.Http;
using System.Numerics;
using System.Reflection.Metadata;
using System.Threading.Tasks;

class Program
{
	static TimeSpan browserTimout = TimeSpan.FromSeconds(5);
	[STAThread]
	static void Main(string[] args)
	{
		Console.Write("Select bin/rom file: ");
		OpenFileDialog openFileDialog = new OpenFileDialog 
		{
			Title = @"Select bin/rom file",
			Multiselect = false,
		};

		if (openFileDialog.ShowDialog() != DialogResult.OK) return;
		string filePath = openFileDialog.FileName;
		Console.WriteLine(filePath);

		while (!File.Exists(filePath))
		{
			Console.WriteLine("File not found. Please enter a valid path: ");
			filePath = Console.ReadLine();
		}

		Console.WriteLine("\nUSERS FOUND:");

		string[] userFolders = Directory.GetDirectories(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "Axolot Games", "Scrap Mechanic", "User"));

		OrderedDictionary nameId = new();

		for (int i = 0; i < userFolders.Length; i++)
		{
			string userFolder = userFolders[i];
			string steamId = Path.GetFileName(userFolder)?.Replace("User_", string.Empty);
			string steamUsername = LookupSteamUsernameAsync(steamId);
			nameId.Add(steamId, steamUsername); //save steamid, username and index onscreen
			Console.WriteLine($"[{i} | {steamUsername}] User found: Steam ID {steamId}");
		}

		Console.WriteLine();

		Console.Write("Enter the Steam ID, username, or index of the user for which to generate the output (leave empty for 1st user (index 0)): ");
		string input = Console.ReadLine();

		string selectedSteamId = null;
		string selectedUsername = null;
		string[] usernames = new string[nameId.Count];
		nameId.Values.CopyTo(usernames, 0);

		if (string.IsNullOrEmpty(input.Trim()))
		{
			if (0 < nameId.Count)
			{
				selectedSteamId = nameId.Cast<DictionaryEntry>().FirstOrDefault().Key.ToString();
				selectedUsername = nameId.Cast<DictionaryEntry>().FirstOrDefault().Value.ToString();
			}
		}
		else if (int.TryParse(input, out int selectedIndex))
		{
			if (selectedIndex >= 0 && selectedIndex < nameId.Count)
			{
				selectedSteamId = nameId.Cast<DictionaryEntry>().ElementAt(selectedIndex).Key.ToString();
				selectedUsername = nameId.Cast<DictionaryEntry>().ElementAt(selectedIndex).Value.ToString();
			}
			else
			{
				Console.WriteLine("Invalid index.");
				return;
			}
		}
		else if (nameId.Contains(input))
		{
			selectedSteamId = input;
			selectedUsername = nameId[input].ToString();
		}
		else if (usernames.Contains(input))
		{
			foreach (DictionaryEntry entry in nameId)
			{
				if (entry.Value.Equals(input))
				{
					selectedSteamId = entry.Key.ToString();
					selectedUsername = entry.Value.ToString();
					break;
				}
			}
		}
		else
		{
			Console.WriteLine("User not found.");
			return;
		}

		Console.WriteLine($"Selected User: Steam ID: {selectedSteamId}, Username: {selectedUsername}");
		Console.WriteLine("\nGenerating ROM blueprint");

		GenerateRomBlueprint();

		Console.WriteLine("ROM generation complete.");
	}

	static string LookupSteamUsernameAsync(string steamId)
	{
		string steamdbUrl = $"https://steamid.uk/profile/{steamId}";

		WebBrowser browser = new();
		browser.ScriptErrorsSuppressed = true;
		browser.Navigate(steamdbUrl);
		DateTime startTime = DateTime.Now;
		while (browser.ReadyState != WebBrowserReadyState.Complete)
		{
			if (startTime + browserTimout <= DateTime.Now) return "[TIMEOUT 💀👎]";
			Application.DoEvents();
		}
		string result = browser.Document.Title;
		string startLandmark = "SteamID » ";
		string endLandmark = " steam | ";
		int startIndex = result.IndexOf(startLandmark) + startLandmark.Length;
		int endIndex = result.IndexOf(endLandmark, startIndex);
		string username = result.Substring(startIndex, endIndex - startIndex);

		if (!string.IsNullOrEmpty(username))
		{
			return username;
		}

		return "[NO USERNAME FOUND]";
	}

	static void GenerateRomBlueprint() 
	{
		int currentX = 0, currentY = 0, currentZ = 0;
		RomBlueprint blueprint = new(); //auto sets version to v4
		blueprint.Dependencies.Add(ScrapReference.ModPackDependency);
		RomBlueprint.Body body = new();
		blueprint.Bodies.Add(body);
		//INPUT
		RomBlueprint.Child inputChild = new RomBlueprint.Child
		{
			Color = ScrapReference.Color.White,
			Controller = new RomBlueprint.Controller { Id = 0 },
			Pos = new RomBlueprint.Pos { X = currentX, Y = currentY, Z = currentZ },
			ShapeId = ""
		}
		
	}
}
