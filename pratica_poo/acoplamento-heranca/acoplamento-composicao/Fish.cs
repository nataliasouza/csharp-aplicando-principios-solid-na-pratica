
using System;

namespace acoplamento_composicao
{
    public class Fish 
    {
        Animal fish = new Animal();
        BehaviorSwim behaviorSwim = new BehaviorSwim();

        public void Swin()
        {
            Console.WriteLine("Nadando...");
        }
    }
}
