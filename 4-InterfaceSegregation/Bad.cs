namespace SolidPrinciples.InterfaceSegregation.Bad
{
    public interface IEmployee
    {
        void Work();
        void Eat();
    }

    public class Human: IEmployee
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

    public class Robot: IEmployee
    {
        public void Work()
        {
            //.... working
        }

        public void Eat()
        {
            //.... (Bad) robot can't eat, but it must implement this method
        }
    }
}