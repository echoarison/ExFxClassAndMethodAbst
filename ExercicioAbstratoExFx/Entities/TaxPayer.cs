using System;
using System.Collections.Generic;
using System.Text;

namespace ExercicioAbstratoExFx.Entities
{
    /*Fazendo uma classe abstract Tax*/
    abstract class TaxPayer
    {
        //atributo(autoProp)
        public string Name { get; set; }
        public double AnualIncome { get; set; }

        //construtor obrigatorio
        public TaxPayer(string name, double anualIncome)
        {
            Name = name;
            AnualIncome = anualIncome;
        }

        //method abstract
        public abstract double Tax();

        //method

    }
}
