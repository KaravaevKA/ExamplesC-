Console.Write("Введите имя пользователя: ");
string username = Console.ReadLine();

if(username.ToLower() == "жанна")
{
    Console.WriteLine("Привет, Жаннулькарибка");
}
else
{
    Console.Write("Привет, ");
    Console.WriteLine(username);
}