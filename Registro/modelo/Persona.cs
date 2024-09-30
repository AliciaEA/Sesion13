using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Registro.modelo
{
    public struct Persona
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime Birthdate { get; set; }

        public int Age => CalcularEdad();

        public int CalcularEdad()
        {
            int Age = DateTime.Now.Year - Birthdate.Year;
            if (DateTime.Now.Month < Birthdate.Month || (DateTime.Now.Month == Birthdate.Month && DateTime.Now.Day < Birthdate.Day))
            {
                Age--;
            }
            return Age;
        }




    }
}
