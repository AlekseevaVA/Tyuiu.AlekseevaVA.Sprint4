using Tyuiu.AlekseevaVA.Sprint4.Task6.V17.Lib;


namespace Tyuiu.AlekseevaVA.Sprint4.Task6.V17
{
    class Program
    {
        static void Main(string[] args)
        {

            DataService ds = new DataService();
           

            Console.Title = "Спринт #4 | Выполнила: Алексеева В. А. | ИИПб-25-1 ";

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Тема:  Двумерные массивы. (генератор случайных чисел)                   *");
            Console.WriteLine("* Задание #6                                                              *");
            Console.WriteLine("* Вариант #17                                                             *");
            Console.WriteLine("* Выполнила: Алексеева В. А. | ИИПб-25-1                                  *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан строковый массив данных используя класс Array подсчитайте количество*");
            Console.WriteLine("* элементов, длина которых равна 6                                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            var lang = new string[] { "Python", "JavaScript", "Java", "C#", "Swift", "Kotlin", "Ruby" };
            Console.WriteLine("Исходный массив: ");
            for (int i = 0; i < lang.Length; i++)
            {
                Console.WriteLine(lang[i]);
            }


            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("Количество элементов длина которых = 6: " );

            int res = ds.Calculate(lang);
            Console.WriteLine(res);
            Console.ReadKey();
        }
    }
}
