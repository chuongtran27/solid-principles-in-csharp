namespace SolidPrinciples.InterfaceSegregation.Good
{
    public interface IWorker
    {
        void Work();
    }

    public interface IHuman
    {
        void Eat();
    }
    
    public class HumanWorker: IWorker, IHuman
    {
        public void Work()
        {
            // .... working
        }
        public void Eat()
        {
            // ...... eating in lunch break
        }
    }

    // (Good) Separate interface help low-level modules only implement interfaces that they need
    public class RobotWorker: IWorker
    {
        public void Work()
        {
            //.... working
        }
    }
}