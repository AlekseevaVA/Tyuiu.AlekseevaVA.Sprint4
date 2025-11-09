using Tyuiu.AlekseevaVA.Sprint4.Task0.V26.Lib;


namespace Tyuiu.AlekseevaVA.Sprint4.Task0.V26
{
    class Program
    {
        static void Main(string[] args)
        {

            DataService ds = new DataService();

            Console.Title = "Спринт #4 | Выполнила: Алексеева В. А. | ИИПб-25-1 ";

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Тема: Одномерные массивы (статический ввод)                             *");
            Console.WriteLine("* Задание #7                                                              *");
            Console.WriteLine("* Вариант #4                                                              *");
            Console.WriteLine("* Выполнила: Алексеева В. А. | ИИПб-25-1                                  *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* В одномерном статичном массиве на 10 элементов подсчитать               *");
            Console.WriteLine("* сумму нечетных элементов                                                *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int[] nums = { 9, 3, 7, 1, 5, 5, 3, 2, 1, 7 };

            Console.WriteLine("Исходный массив: ");

            for (int i = 0; i < nums.Length; i++)
            {
                Console.Write(nums[i] + " ");
            }
            Console.WriteLine();

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            double res = ds.GetSumOddArrEl(nums);

            Console.WriteLine("Сумма нечетных элементов в массиве: " + res);

            Console.ReadKey();
        }
    }
}
