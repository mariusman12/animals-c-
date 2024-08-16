namespace OopHelloWorld
{
    internal class Cat : Animal
    {
        public override string Name
        {
            get { return "cat"; }
        }

        public override string MakeSound()
        {
            return "miau";
        }
    }
}
