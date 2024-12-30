//Integer11 ◦ . Дано трехзначное число. Найти сумму и произведение его цифр

int number = 321;
int FirstTwoNumber = number % 100;//21
int SecondNumber = number / 100;//3
int third = FirstTwoNumber / 10;//2
int lastnumber = FirstTwoNumber % 10;//1
int sum=SecondNumber+third+lastnumber;
int proizvod=SecondNumber*third*lastnumber;
Console.WriteLine($"(integer 11) summa={sum} proizvod={ proizvod}");

//Integer12 ◦ . Дано трехзначное число. Вывести число, полученное при прочтении исходного числа справа налево

Console.WriteLine( $"(integer 11) числа справа налево= {lastnumber}{third}{SecondNumber}" );