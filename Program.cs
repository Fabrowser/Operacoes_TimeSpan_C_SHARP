using System;

namespace Operacoes_TimeSpan
{
    class Program
    {
        static void Main(string[] args)
        {
            TimeSpan t1 = new TimeSpan(2,3,5,7,11);

            Console.WriteLine(t1);


            Console.WriteLine("Dias: " + t1.Days); // Retorna o dia
            Console.WriteLine("Horas: " + t1.Hours); // Retorna a hora
            Console.WriteLine("Minutos: " + t1.Minutes);//...
            Console.WriteLine("Segundos: " + t1.Seconds);//...
            Console.WriteLine("Milisegundos: " + t1.Milliseconds);//...
            Console.WriteLine("Ticks: " + t1.Ticks);

            Console.WriteLine("--------------------------");

            Console.WriteLine("Total Dias: " + t1.TotalDays); // Retorna os dias em forma de fração baseado em t1
            Console.WriteLine("Total Horas: " + t1.TotalHours);// Retorna os Horas em forma de fração baseado em t1
            Console.WriteLine("Total Minutos: " + t1.TotalMinutes);//...
            Console.WriteLine("Total Segundos: " + t1.TotalSeconds);//...
            Console.WriteLine("Total Milisegundos: " + t1.TotalMilliseconds);//...

            Console.WriteLine("--------------------------");



            TimeSpan t2 = new TimeSpan(1, 30, 10);
            TimeSpan t3 = new TimeSpan(0, 10, 5);

            TimeSpan soma = t2.Add(t3); // Soma dois tempos t2 e t3
            TimeSpan dif = t2.Subtract(t3); // Subtrai dois intervalos de tempo
            TimeSpan mult = t2.Multiply(2); // multiplica o tempo t2 por 2
            TimeSpan div = t2.Divide(2); // Divide o tempo t2 por 2 

            Console.WriteLine(soma);
            Console.WriteLine(dif);
            Console.WriteLine(mult);
            Console.WriteLine(div);


        }
    }
}
