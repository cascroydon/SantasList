using System;
using System.Collections.Generic;

class Program
{
	struct NaughtyChild
	{
		public int ChildID;
		public string Name;
		public int Age;
		public bool isAlwaysNaughty;
	}

	public static void Main(string[] args)
	{
		var santasList = new List<NaughtyChild>();
        santasList.Add(new NaughtyChild { Name = "Matthew", ChildID = 1, Age = 16, isAlwaysNaughty = true });
        santasList.Add(new NaughtyChild { Name = "Oliver", ChildID = 2, Age = 17, isAlwaysNaughty = true });

		Console.WriteLine("Please enter student");
		string nameToFind = Console.ReadLine();

        var selectedChild = santasList.Find(x => x.Name.Contains(nameToFind));

		Console.WriteLine("ID is                : {0}", selectedChild.ChildID);
		Console.WriteLine("Full name is         : {0}", selectedChild.Name);
		Console.WriteLine("Age is               : {0}", selectedChild.Age);
		Console.WriteLine("On the naughty list? : {0}", selectedChild.isAlwaysNaughty);
	}
}
