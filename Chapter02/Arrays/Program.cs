using static System.Console;

// See https://aka.ms/new-console-template for more information
string[] names;
names = new string[4];
names[0] = "Kate";
names[1] = "Jack";
names[2] = "Rebecca";
names[3] = "Tom";

string[] names2 = { "Kate", "Jack", "Rebecca", "Tom" };

for (int i = 0; i < names2.Length; i++)
{
    Console.WriteLine(names2[i]);
}

int max = 500;
for (byte i = 0; i < max; i++)
{
    WriteLine(i);
}