Console.WriteLine("--------------------------  Linked List -------------------------");

LinkedList<string> people = new();
people.AddLast("Kalle");
people.AddLast("Jane");
people.AddLast("Zaid");
people.AddLast("Åsa");

foreach (var person in people) Console.WriteLine(person);

Console.WriteLine("--------------------------  Remove -------------------------");
people.AddFirst("Lukas");
people.Remove("Jane");
foreach (var person in people) Console.WriteLine(person);