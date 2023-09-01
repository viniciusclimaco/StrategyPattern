using System;

namespace StrategyPattern
{
    public class Context
    {
        IChoice choice;        
        public void SetChoice(IChoice choice)
        {
            this.choice = choice;
        }        
        public void ShowChoice()
        {
            choice.MyChoice();
        }
    }
}
