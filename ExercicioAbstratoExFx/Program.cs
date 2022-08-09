using System;
using ExercicioAbstratoExFx.Entities;
using System.Globalization;
using System.Collections.Generic;

namespace ExercicioAbstratoExFx
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //fazendo uma list tipo Tax
            List<TaxPayer> list = new List<TaxPayer>();
            double sum = 0.0;

            //pegando os dados
            Console.Write("Enter the number of tax payers: ");
            int n = int.Parse(Console.ReadLine());

            //fazendo o loop
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Tax payer #{i+1} data: ");
                Console.Write("Individual or company (i/c)? ");
                char ch = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Anual income: ");
                double anualIncome = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                //fazendo uma condição
                if (ch == 'i' || ch == 'I') {

                    //ele vai perguntar sobre gasto hospitalares
                    Console.Write("Health expenditures: ");
                    double healthExpenditures = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    //vai add in list
                    list.Add(new Individual(name, anualIncome, healthExpenditures));

                }
                else
                {
                    //ele vai perguntar sobre o numero de funcionario
                    Console.Write("Number of employees: ");
                    int numberOfEmployees = int.Parse(Console.ReadLine());

                    //add list
                    list.Add(new Company(name, anualIncome, numberOfEmployees));
                }

                Console.WriteLine();
            }

            Console.WriteLine();

            //exibindo os dados
            Console.WriteLine("TAXES PAID:");

            //acessando a list
            foreach (TaxPayer item in list)
            {

                Console.WriteLine("Name: " 
                    + item.Name
                    +" "
                    +"Tax Aplicated: $"
                    + item.Tax().ToString("F2", CultureInfo.InvariantCulture));

                sum += item.Tax();

            }

            Console.WriteLine();

            Console.WriteLine("Total Taxes: $" + sum.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
