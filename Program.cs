using System;


#region 1.Ввести с клавиатуры два 3-значных числа и поменять у них средние цифры (например, ввести 357  и 702 – получить и вывести числа  307 и 752).
Console.WriteLine("Введи 3 значное число");
int number = int.Parse(Console.ReadLine());
Console.WriteLine("Введи 3 значное число");
int number1 = int.Parse(Console.ReadLine());

int digitNumber = (number / 10) % 10;
int digitNumber1= (number1 / 10) % 10;

int newNumber = number - (digitNumber * 10) + (digitNumber1 * 10);
int newNumber1 = number1 - (digitNumber1 * 10) + (digitNumber * 10);

Console.WriteLine($"Новые числа: {newNumber} {newNumber1}");
#endregion
#region 2.	Ввести 4-значное число и подсчитать сумму первой и третьей цифры и разность второй и четвертой цифры
Console.Write("Введите 4-значное число: ");
int number123 = int.Parse(Console.ReadLine());

int digitNumber12 = number / 1000;
int digitNumber2 = (number / 100) % 10;
int digitNumber123 = (number / 10) % 10;
int digitNumber3 = number % 10;

int sum = digitNumber12 + digitNumber123;
int difference = digitNumber2 - digitNumber3;

Console.WriteLine("Сумма : " + sum);
Console.WriteLine("Разность : " + difference);
#endregion
#region 3.	Ввести с клавиатуры 3-значное число и удалить из него среднюю цифру (например, ввести 3, 5, 7 – получить и вывести число 37).
Console.WriteLine("Введи 3-знасное число ");
int sa = int.Parse(Console.ReadLine());

int digitSa1 = sa / 100;
int digitSa2 = sa % 10;

int newSa = digitSa1 * 10 + digitSa2;
Console.WriteLine("Новое число :"+ newSa);
#endregion
#region 4.	Написать программу, которая предлагает пользователю ввести сумму денежного вклада в гривнах, а также процент годовых, которые выплачивает банк. Определить сумму денег, выплачиваемых банком вкладчику каждый месяц.
Console.WriteLine("Введите сумму денежного вклада в гривнах");
double amount = double.Parse(Console.ReadLine());

Console.WriteLine("процент годовых");
double interestRate = double.Parse(Console.ReadLine());

double month = interestRate / 12.0;
double month2 = amount + month / (1 - Math.Pow(1 + month, -12));
    
Console.WriteLine($"Сумма на выплату: {month2:F2} ");

#endregion


#region 5.	Сколько товара ценой Y можно купить на Х гривен и сколько получить сдачи?
int price = 10; 
double money = 1000; 
double quantity = Math.Floor(money / price); 
double change = money - (quantity * price); 

Console.WriteLine($"Можно купить {quantity} товаров за {money} грн. Сдача: {change} грн.");
#endregion
#region 6.	Написать программу, которая переводит фунты в килограммы. Один фунт – 405.9 грамма задается в программе как константа. 
const double Fynt = 405.9;
Console.WriteLine("Введите фунты");
double kg = double.Parse(Console.ReadLine());
double sum12 = kg * Fynt;
Console.WriteLine("Кг{0}",sum12);
#endregion
#region 9.	Ввести пятизначное число и сдвинуть его циклически вправо на 2 разряда (например, ввести число 12345 – получить и вывести 45123)
Console.Write("Введите пятизначное число: ");
int numbe = int.Parse(Console.ReadLine());

int Digits = number % 100;
int ThreeDigits = number / 100;
int shiftedNumber = Digits * 1000 + ThreeDigits;

Console.WriteLine($"Результат: {shiftedNumber}");
#endregion
#region 10.	Ввести пятизначное число и сдвинуть его циклически влево на 2 разряда (например, ввести число 12345 – получить и вывести 34512).
Console.Write("Введите пятизначное число: ");
int number4 = int.Parse(Console.ReadLine());

int TwoDigits = number / 1000;
int lastDigits = number % 1000;
int shiftedNumber1 = lastDigits * 100 + TwoDigits;

Console.WriteLine($"Результат: {shiftedNumber}");
#endregion