## "Итоговая проверочная задача"
***
* Формулировка задачи:
>*"Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решение не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами."*
___
* Описание планировочного решения задачи:
>*Сначала создаем массив строк, инициализируем его в самом начале. Повторяем для трех разных массивов*. 

>*Затем объявляем вспомогательную переменную size = 0, в которую запишем количество строк, длина которых 3 символа и меньше. И счетчик итераций i = 0.*

>*Вычисляем количество строк, длинна которых меньше либо равна 3 символа.*

>*В цикле проходим по каждой строке массива. На каждой итерации сверяем длину строки - если длина меньше или равна трём перезаписываем ранее инициализируемую переменную count и счетчик цикла счётчик цикла. Если длина больше трёх обновляем только счётчик.*

>*Инициализируем массив результатов размером size.*

>*Формируем массив с результатами.*

>*Снова в цикле проходим по каждой строке и также сравниваем на каждой итерации длину строки. Однако, теперь если длина меньше или равна трём, мы в текущий массив добавляем данную строку, уменьшаем count и обновляем счётчик цикла, или только инкрементируем счётчик цикла. Уменьшать счётчик количества строк size необходимо для правильного заполнения массива: мы из размера массива вычитаем текущее значение данного счётчика.*

>*Выводим массив результатов в консоль.*
______

* Примеры массивов и результатов вывода:

>*["hello", "2", "world", ":-)"] -> ["2", ":-)"]

>*["1234", "1567", "-2", "computer science"] -> ["-2"]

>*["Russia", "Denmark", "Kazan"] -> [ ]
