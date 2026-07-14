using System;
using System.Collections.Generic; 
using System.IO; 
public class Journal
    {
        private List<Entry> _entries = new List<Entry>();
        private PromptGenerator _promptGenerator = new PromptGenerator();
            public void AddEntry()
            {
                DateTime theCurrentTime = DateTime.Now;
                string dateText = theCurrentTime.ToShortDateString();
                string promptText = _promptGenerator.GetRandomPrompt();
                Console.WriteLine(promptText);
                Entry entry = new Entry();
                entry._promptText = promptText;
                entry._date = dateText;
                Console.Write("> ");
                string EntryText = Console.ReadLine();
                entry._entryText = EntryText;
                _entries.Add(entry);
            }
            public void DisplayAll()
            {
                foreach (Entry entry in _entries)
                {
                    entry.Display();
                }
            }
            public void SaveToFile()
            {
                Console.Write(" Enter the filename to save the journal entries: ");
                string filename = Console.ReadLine();
                using (StreamWriter outputFile = new StreamWriter(filename))
                {
                    foreach (Entry entry in _entries)
                    {
                        outputFile.WriteLine($"{entry._date}~{entry._promptText}~{entry._entryText}");
                    }
                }
            }
            public void LoadFromFile()
            {
                Console.Write(" Enter the filename to load the journal entries from: ");
                string filename = Console.ReadLine();
                if (File.Exists(filename))
                {
                    string[] lines = File.ReadAllLines(filename);
                    _entries.Clear();
                    foreach (string line in lines)
                    {
                        string[] parts = line.Split('~');
                        Entry entry = new Entry();
                        entry._date = parts[0];
                        entry._promptText = parts[1];
                        entry._entryText = parts[2];
                        _entries.Add(entry);
                    }
                }
                else
                {
                    Console.WriteLine("File not found.");
                }
            }
    }
