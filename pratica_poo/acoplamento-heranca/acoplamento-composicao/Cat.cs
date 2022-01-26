
using System;

namespace acoplamento_composicao
{
    public class Cat 
    {
        Animal cat = new Animal();
        BehaviorRun behaviorRun = new BehaviorRun();

        public void Meow()
        {
            Console.WriteLine("Miaaau...");
        }
    }
}
