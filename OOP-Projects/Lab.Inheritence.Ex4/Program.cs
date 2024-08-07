using Lab.Inheritence.Ex4;

Console.WriteLine("Hello, World!");

RandomList randomList = new RandomList();

randomList.Add("RandomSting");
randomList.Add("RandomSting1");
randomList.Add("RandomSting3");
randomList.Add("RandomSting2");

Console.WriteLine(string.Join(", ", randomList));

randomList.Remove();

Console.WriteLine(string.Join(", ", randomList));