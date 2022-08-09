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
    internal class Individual : TaxPayer
    {
        //atributo (autoProp)
        public double HealthExpenditures { get; set; }

        //construtor obrigatorio
        public Individual(string name, double anualIncome, double healthExpenditures)
            : base(name, anualIncome) 
        {
            HealthExpenditures = healthExpenditures;
        }

        //methods abstract
        public override double Tax()
        {
            //variavel local
            double taxTotal = 0.0;

            //fazendo uma condição
            if (AnualIncome > 20000.00)
            {
                //essa vai ser a tax aplicada
                taxTotal = (AnualIncome * 0.25) - (HealthExpenditures * 0.5);
            }
            else
            {
                //essa vai ser a tax aplicada
                taxTotal = (AnualIncome * 0.15) - (HealthExpenditures * 0.5);
            }

            return taxTotal;
        }

        //methods
    }
}
