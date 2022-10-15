using System.Data.SqlTypes;

String s = "Supercalifragilisticexpialidocious";
String v = "Honorificabilitudinitatibus";
String t = "Bababadalgharaghtakamminarronnkonn";

//How many letters are there in 'Supercalifragilisticexpialidocious'?

int count = 0;
foreach (char c in s)
{
    count++;
}
Console.WriteLine($"the total no of count Supercalifragilisticexpialidocious =" +count);

//Does 'Supercalifragilisticexpialidocious' contain 'ice' as a substring ?

if (s.Contains("ice") == true)
{
    Console.WriteLine("ice Word found!");
}
else
{
    Console.WriteLine("ice Word not found!");
}

//Which of the following words is the longest: Supercalifragilisticexpialidocious, Honorificabilitudinitatibus, or Bababadalgharaghtakamminarronnkonn? 

if (s.Length > v.Length & s.Length > t.Length)
{
    Console.WriteLine($"Supercalifragilisticexpialidocious is longest");
}
else if (v.Length > s.Length & v.Length > t.Length)
{
    Console.WriteLine($"Honorificabilitudinitatibus is longest");
}
else
{
    Console.WriteLine($"Bababadalgharaghtakamminarronnkonn is longest");
}

//Which composer comes first in the dictionary: 'Berlioz', 'Borodin', 'Brian', 'Bartok', 'Bellini', 'Buxtehude', 'Bernstein'.Which one comes last?

List<string> lst = new List<string>();
lst.Add("Berlioz");
lst.Add("Borodin");
lst.Add("Brian");
lst.Add("Bartok");
lst.Add("Bellini");
lst.Add("Buxtehude");
lst.Add("Bernstein");
lst.Sort();
Console.WriteLine("Composer that came first in the list : " + lst[0]);
lst.Reverse();
Console.WriteLine("Composer that came last in the list : " + lst[0]);


