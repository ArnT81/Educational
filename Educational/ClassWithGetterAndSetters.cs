namespace Educational
{
    public class ClassWithGetterAndSetters
    {
        public string Name { get; set; }

        public void Explanation()
        {
            Console.WriteLine("Getters and setters declare properties without implicit constructor\n");
        }
    }
}
