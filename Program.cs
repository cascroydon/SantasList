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
		var santasList = new Dictionary<string, NaughtyChild>();
		NaughtyChild Matthew;
		NaughtyChild Oliver;

		Matthew.ChildID = 1;
		Matthew.Name = "Matthew";
		Matthew.Age = 16;
		Matthew.isAlwaysNaughty = true;

		Oliver.ChildID = 2;
		Oliver.Name = "Oliver";
		Oliver.Age = 17;
		Oliver.isAlwaysNaughty = true;

		santasList.Add("Matthew", Matthew);
		santasList.Add("Oliver", Oliver);

		Console.WriteLine("Please enter student");
		string SelectedChild = Console.ReadLine();

		Console.WriteLine("ID is                : {0}", santasList[SelectedChild].ChildID);
		Console.WriteLine("Full name is         : {0}", santasList[SelectedChild].Name);
		Console.WriteLine("Age is               : {0}", santasList[SelectedChild].Age);
		Console.WriteLine("On the naughty list? : {0}", santasList[SelectedChild].isAlwaysNaughty);
	}
}
