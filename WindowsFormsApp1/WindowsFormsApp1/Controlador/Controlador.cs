using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Controlador
{
    public class Controlador
    {
        public string[] Nombres = new string[1000];
        public int contador = 0;
        public int[] DNI = new int[1000];
        public double[] Notas = new double[1000];

         public void RegistrarAlumno(string nombre,int dni, double nota)
         {
            Nombres[contador] = nombre;
            DNI[contador] = dni;
            Notas[contador] = nota;

         }

        public double CalcularPromedio()
        {
            double acumulador = 0;
            double promedio = 0;
            for (int i=0; i<contador; i++)
            {
                acumulador += Notas[i];

            }
            if (contador > 0) 
            {
                promedio = acumulador / contador;

            }
            return promedio;
        }

        public string[] NombresProm= new string[1000];
        public int[] DNIProm= new int[1000];
        public double[] NotasProm= new double[1000];
        public int ContadorProm = 0;

        public void AlumnosSuperanProm()
        {
            double promedio = CalcularPromedio();

            for (int i=0; i < contador; i++)
            {
                if (Notas[i] > promedio)
                {
                    NotasProm[i] = promedio;
                }
            }

        }

    }

}
