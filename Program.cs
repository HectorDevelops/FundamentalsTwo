                                // Three Basic Arrays

// Create an integer array with the values 0 through 9 inside.
int [] MyIntArray = {0,1,2,3,4,5,6,7,8};
// Create a string array with the names "Tim", "Martin", "Nikki", and "Sara".
string [] MyStringArray = {"Tim", "Martin", "Nikki", "Sara"};
// Create a boolean array of length 10. Then fill it with alternating true/false values, starting with true. (Tip: do this using logic! Do not hard-code the values in!)
bool [] MyBoolArray = new bool[10];

// Appending the boolean values into the array 
for (int i = 0; i < 10; i += 2)
{
    MyBoolArray[i] = true;
    MyBoolArray[i+1] = false;
}

// Displaying each item of the boolean array
foreach (bool item in MyBoolArray)
{
    Console.WriteLine(item);
}







                                    // List of Flavors

// Create a string List of ice cream flavors that holds at least 5 different flavors. (Feel free to add more than 5!)
List<string> IceCreamFlavors = new List<string>();

IceCreamFlavors.Add("Chocolate");
IceCreamFlavors.Add("Cookies and Cream");
IceCreamFlavors.Add("Rum Raising");
IceCreamFlavors.Add("Lavender");
IceCreamFlavors.Add("Peach");

// Output the length of the List after you added the flavors.
Console.WriteLine(IceCreamFlavors.Count);

// Output the third flavor in the List.
Console.WriteLine(IceCreamFlavors[2]);

// Now remove the third flavor using its index location.
IceCreamFlavors.RemoveAt(2);

// Output the length of the List again. It should now be one fewer.
Console.WriteLine(IceCreamFlavors.Count);




                                        // User Dictionary

// Create a dictionary that will store string keys and string values.
Dictionary<string, string> MyNewDictionary = new Dictionary<string, string>();

MyNewDictionary.Add("Name", "Hector Rosario");
MyNewDictionary.Add("Sex", "Male");

MyNewDictionary.Clear();
// Making sure i count the length to check if it was properly stored
Console.WriteLine(MyNewDictionary.Count); 

// Add key/value pairs to the dictionary where:
    // Each key is a name from your names array (this can be done by hand or using logic)
    // Each value is a randomly selected flavor from your flavors List (remember Random from earlier?)
Random randomizer = new Random();
int idx = randomizer.Next(IceCreamFlavors.Count);

MyNewDictionary.Add("Tim", IceCreamFlavors[idx]);
MyNewDictionary.Add("Martin", IceCreamFlavors[idx]);
MyNewDictionary.Add("Nikki", IceCreamFlavors[idx]);
MyNewDictionary.Add("Sara", IceCreamFlavors[idx]);

// Loop through the dictionary and print out each user's name and their associated ice cream flavor.

foreach (KeyValuePair<string, string> entry in MyNewDictionary)
{
    Console.WriteLine($"{entry.Key} is eating {entry.Value} Ice Cream.");
}