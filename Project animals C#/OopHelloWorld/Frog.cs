namespace OopHelloWorld
{
    internal class Frog : Animal
    {
        public override string Name
        {
            get { return "frog"; }
        }

        public override string MakeSound()
        {
            return "oac";
        }
    }
}
