/* Написать функцию Sqrt(x) - квадратного корня, которая принимает на вход целочисленное значение x и возвращает 
целую часть квадратного корня от введенного числа.
4 -> 2
28 -> 5    
Нельзя использовать встроенные функции библиотеки Math! */

Console.WriteLine("Введите целое число: ");
int num = int.Parse(Console.ReadLine()!);

int getSqr(int num)
{

  int y = 1;
  int x = 1;
  if (num > 0)
  {
    while (x <= num)
    {
      x = y * y;
      y++;

    }
    Console.WriteLine(y - 2);
  }
  if (num == 0)
  {
    Console.WriteLine($"Квадратный корень {0} равен {0}");
  }

  return y;
}

int number = getSqr(num);


