using System;

namespace StrategyPattern
{
    public class SecondChoice:IChoice
    {
        public void MyChoice()
        {
            Console.WriteLine("Viajando para Gramado");
        }
    }
}
