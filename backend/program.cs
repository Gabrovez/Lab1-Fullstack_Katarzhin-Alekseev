Console.Write("Введите ваше имя: ");
string name = Console.ReadLine();
Console.WriteLine($"Привет, {name}!");

Console.WriteLine(DateTime.Now.DayOfWeek);

while (true){
    Console.Write("Хотите продолжить? (y/n): ");
    string ans = Console.ReadLine().Trim().ToLower();
    if (ans == "y" || ans == "yes"){
        Console.WriteLine("Отлично! Продолжаем...");
        continue;
    }
    else if (ans == "n" || ans == "no"){
        Console.WriteLine("До свидания!");
        break;
    }
    else{
        Console.WriteLine("Пожалуйста, введите 'y' или 'n'.");
    }
}