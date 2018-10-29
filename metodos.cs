using System;

namespace Metodos
{
    public class MetodosAritmeticos
    {
        public string EsPrimo(Int32 num)
        {
            int numVerif = 0, i;
            for (i = 1; i < (num + 1); i++)
            {
                if (num % i == 0)
                {
                    numVerif++;
                }
            }
            if (numVerif != 2)
            {
                /*Console.WriteLine("No es primo");*/
                return "No es primo";
            }
            else
            {
                //Console.WriteLine("Si es primo");
                return "Si es primo";
            }
        }

        public bool EsPar(int num)
        {
            if (num % 2 == 0) { return true; }
            else return false;
        }

        public string QueDiaEs(int num)
        {
            string[] dias = { "Lunes", "Martes", "Miercoles", "Jueves", "Viernes", "Sabado", "Domingo" };
            return $"{dias[num - 1]}";
        }

        public string QueMesEs(int num)
        {
            string[] dias = { "Enero", "Febrero", "Marzo", "Abril", "Mayo", "Junio", "Julio", "Agosto", "Septiembre", "Octubre", "Noviembre", "Diciembre" };
            return $"{dias[num - 1]}";
        }

        public int[] OrdenarNumeros(int[] array)
        {

            Array.Sort(array);
            //for (int i = 0; i < array.Length; i++)
            //{
            //    int val1 = array[i];

            //}
            return array;
        }

        public string esPositivo(int num)
        {
            if (num >= 0) return "positivo";
            else return "negativo";
        }

        public string esVocal(string letra)
        {
            letra = letra.ToLower();
            if ((letra == "a") || (letra == "e") || (letra == "i") || (letra == "o") || (letra == "u"))
            {
                return "Es una vocal";
            }
            else return "No es una vocal";
        }

    }
    public class MetodosRecursividad
    {
        public int PromedioNotas(int[] notas)
        {
            int promedio = 0;
            for (int i=0; i < notas.Length; i++)
            {
                
                promedio = promedio + notas[i]; 
            }
            return promedio/ notas.Length;
        }
        public void EstaAprobado(int promedio)
        {
            if(promedio >= 11)
            {
                Console.WriteLine("Esta aprobado");
            }else{ Console.WriteLine("Esta desaprobado"); }
        }

        public uint SumaNumerosAnteriores(uint numero)
        {
            uint SumaNumeros(uint n)
            {
                if (n == 0)
                {
                    return 0;
                }
                return n + SumaNumeros(n - 1);
            }
            return SumaNumeros(numero - 1);
        }

        public int PotenciaNumero(int numero, int exponente)
        {
            int multiplicador(int exp)
            {
                if(exp == 0)
                {
                    return 1;
                }
                return numero * multiplicador(exp - 1);
            }
            return multiplicador(exponente);
        }

        public int Factorial(int num)
        {
            int factorial(int n)
            {
                if (n == 1) { return 1; }
                return n * factorial(n - 1);
            }
            return factorial(num);
        }
        //public int numeroMayor(int[] num)
        //{

        //}
    }

    public class MetodosArrays
    {
        public void EjercicioDemoArray()
        {
            int[] array = { 5, 65, 20, 12, 16 };
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine($"Usando for: {array[i]}");
            }
            foreach (int item in array)
            {
                Console.WriteLine($"Usando foreach: {item}");
            }
        }
        public void imprimeNumerosNaturales()
        {
            int[] array = new int[10];
            MetodosAritmeticos metodoAritmetico = new MetodosAritmeticos();
            for (int i = 1; i < 22; i++)
            {
                if (metodoAritmetico.EsPar(i)) { array[i] = i;}
                Console.WriteLine(array[i]);
            }                                                       

            
        }
    }
}
