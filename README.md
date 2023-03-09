### Задача: 
Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых
меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры, либо задать на старте
выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись
исключительно массивами.

### Решение: 
1. Создание исходный массив
2. Создание функции FillArr для заполнения массива с клавиатуры
3. Создание функции ChangeArr для:
    - Определения размера нового массива
    - Создания нового массива
    - Заполнения нового массива строками меньшими или равными 3 символам
    - Возврата итогового массива
4. Вызов функции FillArr
5. Вывод в консоль решения с использованием функции ChangeArr