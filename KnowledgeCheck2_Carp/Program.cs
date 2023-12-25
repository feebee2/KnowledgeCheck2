using KnowledgeCheck2_Carp;

Console.WriteLine("How many records do you want to add? ");
var numberOfRecords = int.Parse(Console.ReadLine());

var recordList = new List<Carp>();
for (int i = 0; i < numberOfRecords; i++)
{
    // In this loop, populate the object's properties using Console.ReadLine()
    Carp myCarp = new Carp();

    Console.WriteLine("Enter the value for size in CM ");
    myCarp.sizeCM = double.Parse(Console.ReadLine());
    
    Console.WriteLine("Enter the value for age in years ");
    myCarp.ageYR = int.Parse(Console.ReadLine());

    Console.WriteLine("Enter the color ");
    myCarp.color = (Console.ReadLine());

    Console.WriteLine("Enter the species ");
    myCarp.species = (Console.ReadLine());

    recordList.Add(myCarp);
}

foreach (Carp myCarp in recordList)
{
    Console.WriteLine(myCarp);
}





// Print out the list of records using Console.WriteLine()
