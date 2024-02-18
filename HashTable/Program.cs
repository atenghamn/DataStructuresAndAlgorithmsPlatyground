using System.Collections;

Console.WriteLine("--------------------------  Hash Table -------------------------");

Hashtable languages = new Hashtable();
languages.Add("Finland", "Finish");
languages.Add("Sweden", "Swedish");
languages.Add("Norway", "Norwegian");
languages.Add("Denmark", "Danish");

foreach (var lang in languages) Console.WriteLine(lang.ToString());

Console.WriteLine("----------------------------------------------------------------");