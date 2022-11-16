Console.Write("Введите имя пользователя: "); // Ввод имени пользователя
string username = Console.ReadLine(); // задаю переменную username(тип данных sting) она будет == тому, что напишет пользователь

if(username.ToLower() == "маша") // Если переменная username будет совпадать со словом Маша, то..
{
    Console.WriteLine("Ура, это же МАША"); // вывод на консоль 
}
else // логический конец
{
    Console.Write("Привет, "); // Если username != Маша, то вывожу на консоль привет, username)
    Console.WriteLine(username);
}