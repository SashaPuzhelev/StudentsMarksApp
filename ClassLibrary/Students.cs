
namespace ClassLibrary
{
    public class Students : StudentsGroup
    {
        private static int[] id;
        private static string[] surnames;
        private static char[] marks;
        public static int[] Id
        {
            get => id;
            set { 
                id = value; 
            } 
        }
        public static string[] Surnames { get => surnames;
            set {
                    surnames = value;
            } 
        }
        public static char[] Marks { get => marks; 
            set {
                marks = value;
            } 
        }
        
    }
}
