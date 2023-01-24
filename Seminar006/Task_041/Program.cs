// Задача 41: Пользователь вводит с клавиатуры M чисел.
// Посчитайте, сколько чисел больше 0 ввёл пользователь. Ввод чисел останавливается
// при помощи ввода стоп-слова "stop" и производится при помощи нажатия Enter

int result = 0;
string? check = "";
Console.WriteLine("Для выхода из программы наберите 'stop'");
input1:
while(check != "stop")
{
    Console.Write("Введите число ");
    check = Console.ReadLine();
    bool check_a = int.TryParse(check, out int a);
    if (!check_a)
    {
        if(check == "stop")
        {
            goto input1;
        }
        Console.WriteLine("Это не число");
        goto input1;
    }
    int numers = Convert.ToInt32(check);
    if(numers > 0)
    {
        result++;
    }
}
Console.WriteLine($"Колличество чисел больше нуля = {result}");
Console.WriteLine("Выполнение программы завершено");