namespace SolidPrinciples.DependencyInversion.Bad
{
    public abstract class EmployeeBase
    {
        public virtual void Work()
        {
            //....working
        }
    }

    public class Human : EmployeeBase
    {
        public override void Work()
        {
            //.... working
        }
    }

    public class Robot : EmployeeBase
    {
        public override void Work()
        {
            //.... working
        }
    }

    public class Manager
    {
        private readonly Robot _robot;
        private readonly Human _human;

        // (Bad) EmployeeBase depend on Robot & Human. So need to pass them to call Work() method  
        public Manager(Robot robot, Human human)
        {
            _robot = robot;
            _human = human;
        }

        public void Manage()
        {
            _robot.Work();
            _human.Work();
        }
    }

}