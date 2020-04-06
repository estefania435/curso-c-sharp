using System;

namespace curso_1
{
    class Program
    {
        static void Main()
        {
            var s1 = new Estudiantes()
            {
                Nombre = "stefa",
                edad = 21,
                calificacion = 5.0
            };
            var s2 = new Estudiantes()
            {
                Nombre = "stick",
                edad = 28,
                calificacion = 3.0
            };
            var s3 = new Estudiantes()
            {
                Nombre = "stevenson",
                edad = 29,
                calificacion = 5.0
            };

            var School = new school();
            School.addstudent(s1);
            School.addstudent(s2);
            School.addstudent(s3);
            bool valor = false;

            do
            {
                Console.WriteLine("ingrese el nombre");
                string name = Console.ReadLine();
                valor = School.buscarpornombre(name);

            } while (valor);

            
            Console.ReadKey();
        }
    }
}
