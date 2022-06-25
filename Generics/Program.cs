
using System.Collections.Generic;

// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

GenericColl<int> intobj = new GenericColl<int>();
intobj.add(9);
intobj.add(10);
intobj.add(11); 
intobj.add(12);
intobj.add(13);

Console.WriteLine("Generic obj type is int with length of " + intobj.Length);
for (int item = 0; item < intobj.Length; item++ )
{
    Console.WriteLine(intobj[item]);
}

GenericColl<string> petAnimals = new GenericColl<string>();
petAnimals.add("DOG");
petAnimals.add("Horse");

Console.WriteLine("Generic obj type is string with length of " + petAnimals.Length);
for (int item = 0; item < petAnimals.Length; item++)
{
    Console.WriteLine(petAnimals[item]);
}


public class GenericColl<G>
{
    //define generic array
    G[] obj = new G[] { };
    int count = 0;

    public void add(G item)
    {
        Array.Resize<G>(ref obj, count+1);
        obj[count] = item;
        count++;
    }

    public G this[int index]
    {
        get { return obj[index]; }
    }
    //public int length;
    public int Length
    {
        get { return obj.Length; }
    }
} 



