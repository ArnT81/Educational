namespace Educational
{
    public static class StaticObject
    {
        public static int myProperty = 12;

        public static string Greeting() => "Hello";

        public static void Explenation()
        {
            Console.WriteLine("Classes with the \"static\" may be considered as predefined objects and do not need to be instantiated\n");
        }
    }
}