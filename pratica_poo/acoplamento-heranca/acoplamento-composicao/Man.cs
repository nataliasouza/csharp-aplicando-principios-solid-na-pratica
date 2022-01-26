
using System;

namespace acoplamento_composicao
{
    public class Man
    {
        Animal man = new Animal();
        BehaviorRun behaviorRun = new BehaviorRun();

        public void Run()
        {
            Console.WriteLine("Correndo...");
        }
    }   
}
