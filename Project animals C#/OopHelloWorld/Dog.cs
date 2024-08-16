namespace OopHelloWorld
{
    internal class Dog : Animal
    {
        public override string Name
        {
            get { return "dog"; }
        }

        public override string MakeSound()
        {
            return "ham";
        }
    }
}
