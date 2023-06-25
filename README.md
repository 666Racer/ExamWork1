# ExamWork1
Examination work (quarter 1)

# Алгоритм решения #

## 1. Выводим массив строк (PrintArrayOfStrings).

Для наглядности выводим его в консоль через цикл `for`, начиная с элемента с индексом 0 и заканчивая элементом с индексом, равным длине массива, минус 1. Оформляем вывод массива строк **как функцию void**.

## 2. Считаем количество элементов в массиве, длина которых не более 3 символов (Count3CharElements).

Создаём счётчик элементов `count` в массиве с длиной не более 3 символов, начальное значение 0.
Аналогично **пункту 1** создаём цикл `for`, начиная с элемента с индексом 0 и заканчивая элементом с индексом, равным длине массива, минус 1. Но в этом цикле добавляется условие, которое проверяет длину строки (меньше 3), и прибавляет к счётчику 1 в случае положительного результата:
```
if (arr[i].Length <= 3) count++;
```
Возвращаем значение счётчика `count`, т.е. данная функция будет иметь **тип int**.

## 3. Создаём массив строк (NewArrayWith3CharElements).

Создаём метод, принимающий на вход массив строк, а также размер нового массива. Метод будет создавать из старого массива новый с элементами старого массива с длиной не более 3 символов.
Создаём новый массив указанной размерности, заполняя его пустыми элементами.
Индекс j элементов нового массива изначально присваиваем 0.
Перебор элементов старого массива оформляем через цикл `for`, начиная с элемента с индексом 0 и заканчивая элементом с индексом, равным длине массива, минус 1 (аналогично **пункту 1**).
Условие, которое проверяет длину строки (меньше 3) и, при удовлетворительном результате, присваивает элементу нового массива значение старого, оформляем как
```
if (arr[i].Length <= 3) newarr[j] = arr[i];
```
Соответственно, индекс j увеличивается на 1 при выполнении данного условия.
Таким образом, получаем массив элементов старого массива с длиной не более 3.
Оформляем это **как функцию с типом string []**.

## 4. Применяем данные 3 метода для созданного в пункте 1 массива.

Создаём массив строк (используя строки из примера) через команду:
```
string[] array = new string [кол-во элементов]{"строка1", "строка2", "строка3"};
```
Для наглядности выводим массив в консоль методом, описанным в **пункте 1**:
```
PrintArrayOfStrings (array);
```
Присваиваем размеру нового массива значение, полученное в результате применения метода, описанного в **пункте 2**:
```
int sizeNewArr = Count3CharElements (array)
```
На случай, если новый массив пустой, вводим условие (чтобы программа не выдавала массив нулей):
```
if (sizeNewArr = 0) Console.WriteLine ("В данном массиве нет строк с длиной не более 3")
```
Создаём новый массив с размером `sizeNewArr`:
```
string[] newArray = new string [sizeNewArr];
```
Затем выполняем для него метод, описанный в **пункте 3**:
```
newArray = NewArrayWith3CharElements (array, sizeNewArr)
```
Завершающий этап - вывод нового массива `newArray` в консоль методом, описанным в **пункте 1**.
```
PrintArrayOfStrings (newArray);
```

**Результат выполнения программы - в консоли должны быть выведены старый массив строк и новый со строками старого массива, длина которых не более 3.**