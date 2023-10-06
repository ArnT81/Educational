namespace Educational
{
    public class ClassWithExplicitConstructor
    {
        public string Name { get; set; }
        public ClassWithExplicitConstructor(string name)
        {
            if (name.Count() < 5)
            {
                Console.WriteLine("Name should be longer than 5 characters");
                return;
            }
            Name = name;
        }

        public void Explanation()
        {
            Console.WriteLine("Classes with explicit constructor requires parameters on instantiation.");
            Console.WriteLine("Here it´s also possible to add validation to the arguments.\n");
        }
    }
}
