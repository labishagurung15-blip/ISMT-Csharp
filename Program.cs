Console.WriteLine("What is your name?");
string username = Console.ReadLine();  //string? name=Console.ReadLine();
Console.WriteLine($"I am {username}!");
Console.WriteLine("What is your age?");
int age = Convert.ToInt32(Console.ReadLine());
if (age < 18)
{
    Console.WriteLine(" HIIIIIII {username}, you are a minor.");
}
else
{
    Console.WriteLine($" HIIIIIII {username}, you are an adult.");
}
Console.WriteLine($"you are currently {age} years old.");