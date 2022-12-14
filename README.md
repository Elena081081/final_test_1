# Итоговая проверочная работа

## Для выполнения проверочной работы необходимо:

1. Создать репозиторий на GitHub
2. Нарисовать блок-схему алгоритма (можно обойтись блок-схемой основной содержательной части, если вы выделяете её в отдельный метод)
3. Снабдить репозиторий оформленным текстовым описанием решения (файл README.md)
4. Написать программу, решающую поставленную задачу
5. Использовать контроль версий в работе над этим небольшим проектом (не должно быть так, что всё залито одним коммитом, как минимум этапы 2, 3, и 4 должны быть расположены в разных коммитах)

## *Задача:* 
Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

## *Решение:*

## **Описание блок-схемы алгоритма:**

1. Инициализируем два массива типа string и переменную *count = 0*.

2. Запускаем цикл и проверяем каждый элемент первоначального массива на длину.

3. Если длина элемента меньше или равна трём, то добавляем этот элемент во второй массив и переходим к следующему элементу.

4. Если длина элемента больше трёх, то сразу переходим к следующему элементу.

5. По завершению последней итерации будет сформирован и выведен результирующий массив.

## **Описание программы, решающей поставленную задачу:**

1. Инициализируем два массива типа string и переменную *count = 0*. Первоначальный массив задаем на старте. Второй массив объявляем такой же длины как первоначальный.

2. C помощью метода *void* заполняем второй массив. Для этого инициализируем цикл, в котором будут перебираться элементы первоначального массива на выполнение условия, что длина строк должна быть меньше либо равна трём символам.

3. Запускаем цикл и проверяем каждый элемент первоначального массива на длину. 
* Если длина элемента меньше или равна трём, то добавляем этот элемент во второй массив и переходим к следующему элементу.
* Если длина элемента больше трёх, то сразу переходим к следующему элементу.

4. С помощью метода *void* выводим результирующий массив на консоль. При этом также формируем результирующий массив через использование цикла.
* Если длина элемента меньше или равна трём, то добавляем этот элемент во второй массив (в счетчик *count*) и переходим к следующему элементу (увеличиваем счётчик *i*).
* Если длина элемента больше трёх увеличиваем только счётчик цикла *i*. Счётчик *count* не увеличиваем, чтобы не было пустот во втором массиве.


