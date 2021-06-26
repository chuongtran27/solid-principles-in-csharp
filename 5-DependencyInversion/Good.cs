using System.Collections.Generic;

namespace SolidPrinciples.DependencyInversion.Good
{
    public interface IEmployee
    {
        void Work();
    }

    public class Human : IEmployee
    {
        public void Work()
        {
            // ....working
        }
        public void Rest()
        {
            // ....rest
        }
        public void Eat()
        {
            // ....eat
        }
    }

    public class Robot : IEmployee
    {
        public void Work()
        {
            //....working
        }
        public void OldChange()
        {
            //....oil change
        }
    }

    public class Manager
    {
        private readonly IEnumerable<IEmployee> _employees;

        // (Good) Create abstract IEmployee interface
        // High-level modules doesn't need to know about implementation of low-level modules.
        // Just use the methods which is defined in IEmployee interface.
        public Manager(IEnumerable<IEmployee> employees)
        {
            _employees = employees;
        }

        public void Manage()
        {
            foreach (var employee in _employees)
            {
                employee.Work();
            }
        }
    }
}