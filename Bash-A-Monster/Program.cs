using System.ComponentModel.Design.Serialization;
using System.Threading.Tasks.Dataflow;
using Microsoft.VisualBasic;

Random rnd = new Random();
Megaman man = new Megaman()
{
    Name = "Rockman",
    Hitpoints = 100
};

Megaman zero = new Megaman()
{
    Name = "Zero",
    Hitpoints = 100
};

while (zero.Hitpoints > 0)
{
    Console.WriteLine($"{man.Name} has {man.Hitpoints} health!");
    Console.WriteLine($"{zero.Name} has {zero.Hitpoints} health!");
    Console.WriteLine("Attack by pressing [Q]!");
    string input = Console.ReadLine().ToUpper();
    if (input == "Q")
    {
    int damage = rnd.Next(6, 17);
    zero.Hitpoints -= damage;
    Console.WriteLine($"{zero.Name} has {zero.Hitpoints} health!");
    }
}
Console.ReadLine();