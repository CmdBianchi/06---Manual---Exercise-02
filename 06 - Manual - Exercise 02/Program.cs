using System;
using Entities;
namespace _06___Manual___Exercise_02 {
    class Program {
        static void Main(string[] args) {
            Student[] student = new Student[10];
            Console.Write("Quantos quartos serão alugados ? "); int n = int.Parse(Console.ReadLine());
            for(int i = 1; i <= n; i++) {
                Console.WriteLine();
                Console.WriteLine($"Aluguel #{i}: ");
                Console.Write("Nome: "); string name = Console.ReadLine();
                Console.Write("Email: "); string email = Console.ReadLine();
                Console.Write("Quarto: "); int quarto = int.Parse(Console.ReadLine());
                student[quarto] = new Student(name, email);
            }

            Console.WriteLine();
            Console.WriteLine("Quartos ocupados: ");
            for(int i=0; i < 10; i++) {
                if(student[i] != null) {
                    Console.WriteLine("\n"+i +": " + student[i]);
                }
            }
        }
    }
}
