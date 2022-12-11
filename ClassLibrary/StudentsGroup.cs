namespace ClassLibrary
{
    public class StudentsGroup
    {
        private static string name;
        private static string subject;
        private static int count;
        public static string Name { get => name; set => name = value; }
        public static string Subject { get => subject; set => subject = value; }
        public static int Count { get => count; set => count = value; }
    }
}
