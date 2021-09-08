using System;

namespace UnitTestAndDebug
{
    public class Person
    {
        public Person(string name, string id, string fechaNacimiento)
        {
            this.Name = name;
            this.ID = id;
            this.FechaNacimiento = fechaNacimiento;
        }

        private string name;

        private string id;

        private string fechaNacimiento;

        public string Name
        {
            get
            {
                return this.name;
            }
            
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    this.name = value;
                }
            }
        }
        public string ID
        {
            get
            {
                return this.id;
            }

            set
            {
                if (IdUtils.IdIsValid(value))
                {
                    this.id = value;
                }
            }
        }

        public string FechaNacimiento {
            get {
                return this.fechaNacimiento;
            }
            set {
                string[] componentes = value.Split('/');
                if (componentes.Length != 3) {
                    this.fechaNacimiento = "1/1/1900";
                    return;
                }

                int dia, mes, anio;
                if (! int.TryParse(componentes[0], out dia) ||
                    ! int.TryParse(componentes[1], out mes) ||
                    ! int.TryParse(componentes[2], out anio)) {
                    this.fechaNacimiento = "1/1/1900";
                    return;
                }

                if (dia >= 1 && dia <= 31 &&
                    mes >= 1 && mes <= 12 &&
                    anio >= 1900) {
                    this.fechaNacimiento = value;
                }
                else {
                    this.fechaNacimiento = "1/1/1900";
                }
            }
        }

        public void IntroduceYourself()
        {
            Console.WriteLine($"Soy {this.Name}, mi cédula es {this.ID} y nací el {this.FechaNacimiento}");
        }
    }
}
