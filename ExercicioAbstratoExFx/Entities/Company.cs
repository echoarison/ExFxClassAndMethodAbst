using System;
using System.Collections.Generic;
using System.Text;

namespace ExercicioAbstratoExFx.Entities
{
    /**
     * 
     * Herdando de uma classe abstract
     * 
     **/
    internal class Company : TaxPayer
    {
        //atributos (autoProp)
        public int NumberOfEmployees { get; set; }

        //construtor obrigatorio
        public Company(string name, double anualIncome, int numberOfEmployees)
            : base(name, anualIncome)
        {
            NumberOfEmployees = numberOfEmployees;
        }

        //method abstract
        public override double Tax()
        {
            //variavel local
            double taxTotal = 0.0;
            
            //fazendo uma condicao
            if (NumberOfEmployees <= 10) 
            {
                taxTotal = AnualIncome * 0.16;
            }
            else
            {
                taxTotal = AnualIncome * 0.14;
            }

            return taxTotal;
        }

        //method 
    }
}
