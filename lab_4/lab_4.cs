using System;
using System.IO;

class Program
{
    static void Main()
    {
        // Введення шляху до каталогу
        string directory = @"D:\Desktop\English";

        // Перевірка існування каталогу
        if (!Directory.Exists(directory))
        {
            Console.WriteLine($"Каталог \"{directory}\" не знайдено.");
            Console.ReadLine(); // Очікування введення користувача перед завершенням
            return;
        }

        // Перебір всіх підкаталогів у поточному каталозі
        foreach (string subdir in Directory.GetDirectories(directory))
        {
            // Перехід до підкаталогу
            Console.WriteLine($"Обробка каталогу: {subdir}");

            // Підрахунок кількості файлів у підкаталозі
            int fileCount = 0;
            foreach (string file in Directory.GetFiles(subdir))
            {
                fileCount++;
            }

            // Виведення назви підкаталогу і кількості файлів
            Console.WriteLine($"{subdir} : {fileCount}");
        }

        Console.ReadLine(); // Очікування введення користувача перед завершенням
    }
}
