using System;
using System.Collections.Generic;
using System.Text;

namespace curso_1
{
    public class school
    {
        private List<Estudiantes> students;

        public school()
        {
            students = new List<Estudiantes>();
        }
        public void addstudent(Estudiantes nuevoEstudiantes)
        {
            students.Add(nuevoEstudiantes);
        }
        public bool buscarpornombre(string name)
        {
            bool encontrado = false;
            int i = 0;
            while (encontrado == false && i < students.Count)
            {
                if (students[i].Nombre.Equals(name))
                {
                    encontrado = true;
                }
                else
                {
                    i++;
                }
            }
            if (encontrado)
            {
                Console.WriteLine("name: " + students[i].Nombre + "\n"
                    + "edad: " + students[i].edad + "\n"
                    + "calificacion: " + students[i].calificacion);
                return false;
            }
            else
            {
                Console.WriteLine("no existe el nombre, intente nuevamente");
                return true;

            }
        }
    }
}
