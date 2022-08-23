Console.WriteLine(); // пустая строка-пробел
Console.WriteLine("Итоговая проверочная задача:"); // Выводим в консоль название задания и его формулировку
Console.WriteLine("Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решение не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.");
Console.WriteLine();

string[] arrayFirst =  {"hello", "2", "world", ":-)"}; // создаем и инициализируем первый массив строк
int countFirst = CountStringLessThreeChar(arrayFirst);
string[] resultFirst =  FillResultArray(arrayFirst,countFirst);


string[] arraySecond = {"1234", "1567", "-2", "computer science"};// создаем и инициализируем второй массив строк
int countSecond  = CountStringLessThreeChar(arraySecond);
string[] resultSecond = FillResultArray(arraySecond,countSecond);


string[] arrayThird = {"Russia", "Denmark", "Kazan"};// создаем и инициализируем третий массив строк
int countThird = CountStringLessThreeChar(arrayThird);
string[] resultThird = FillResultArray(arrayThird, countThird);

void PrintArray(string[] array) 
    {

        for (int i = 0; i < array.Length; i++) // проверяем длинну каждого элемента
            {
                if (i != array.Length - 1) Console.Write($"{array[i]}, ");
                else Console.Write($"{array[i]}.");
            }
        Console.WriteLine();
    }

int CountStringLessThreeChar(string[] array)
    {
        int size = 0; // объявляем вспомогательную переменную size = 0, в которую запишем количество строк, 
                      //длина которых 3 символа и меньше
        for (int i = 0; i < array.Length; i++)
            {
                if (array[i].Length <= 3) size++;
            }
        return size; 
    }

string[] FillResultArray(string[] array, int size)
    {
        string[] result = new string[size];
        for (int i = 0; i < array.Length; i++)
            {
                if (array[i].Length <= 3)
                    {
                        result[result.Length - size] = array[i];
                        size--;
                    }
            }
        return result;
    }

Console.Write("Первый массив строк: ");
PrintArray(arrayFirst); // выводим в консоль первый массив
Console.Write("Результат решения задачи по первому массиву: "); // выводим в консоль результат решения первого массива
PrintArray(resultFirst);
Console.WriteLine();

Console.Write("Второй массив строк: ");
PrintArray(arraySecond);
Console.Write("Результат решения задачи по второму массиву: ");
PrintArray(resultSecond);
Console.WriteLine();

Console.Write("Третий массив строк: ");
PrintArray(arrayThird);
Console.Write("Результат решения задачи по третьему массиву: ");
PrintArray(resultThird);
Console.WriteLine();
