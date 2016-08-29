# PickleDotNet

## What is this?

This is a class library for .NET 3.5 and above which allows similar functionality to [Python's Pickle module](https://docs.python.org/3/library/pickle.html) which allows quick and easy saving and retrieval of complex data structures.

## How do I use it?

I've tried to keep it as simple as possible and there's not really much code in it at all. There are two methods, Dump and Load. To save a data structure you simple create an instance of the class and call the dump method on it with appropriate arguments. 

Here is an example:

```C#
// Declares a list to hold strings
List<String> s = new List<string>();

// Appends number 0 to 999 to the list
for (int i = 0; i < 1000; i++) s.Add(i.ToString());

// Saves it to an xml document using the pickle module
new Pickle<List<String>>().Dump(s, "file.xml");
```

To load data from a file you simple call the Load method with the path to a valid file and type as shown in this example:

```C#
// Declares a list to hold strings
List<String> s = new List<string>();

// Appends number 0 to 999 to the list
for (int i = 0; i < 1000; i++) s.Add(i.ToString());

// Saves it to an xml document using the pickle module
new Pickle<List<String>>().Dump(s, "file.xml");

// Loads the values we just dumped into a new list
var RetrievedData = new Pickle<List<String>>().Load("file.xml");

// Writes the data separated by commas.
Console.WriteLine(String.Join(", ", RetrievedData.ToArray()));
```

## When should I use this?

If you don't care much for performance and want something quick and easy for a proof of concept or personal project then this is probably sufficient for your needs. However, if you want something a bit more robust and efficient you are almost always guaranteed that a purpose built system for saving or retrieving data will be better. 

## Disclaimer

This is here so I can use it personally, I don't guarantee it to be fit for any purpose or reliable in any way. I do not recommend it's use in professional or critical applications and will not be actively supporting this beyond the initial "meh, it works for me" stage of development.

