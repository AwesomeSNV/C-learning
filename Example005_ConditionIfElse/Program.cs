Console.Write("Введите имя пользователя: ");
string username = Console.ReadLine();

if(username.ToLower() == "николай")
{
    Console.WriteLine("Ура, это же НИИИКОЛАЙ!!!");
}
else
{
    Console.Write("Привет, ");
    Console.Write(username);
}