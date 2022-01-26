
using System;

namespace acoplamento_heranca
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
