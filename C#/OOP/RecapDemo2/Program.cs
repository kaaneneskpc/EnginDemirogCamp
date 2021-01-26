using System;
using System.Collections.Generic;

namespace RecapDemo2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<IWorker> workers = new List<IWorker>() { new Managers(), new Worker(), new Robots() };

            foreach (var item in workers)
            {
                item.Work();
            }
            List<IEat> eaters = new List<IEat>() { new Managers(), new Worker() };

            foreach (var item in eaters)
            {
                item.Eat();
            }
            List<ISalary> salaries = new List<ISalary>() { new Managers(), new Worker() };

            foreach (var item in salaries)
            {
                item.GetSalary();
            }
        }
    }
}
