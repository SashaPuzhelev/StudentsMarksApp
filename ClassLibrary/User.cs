using System;
using System.Windows.Forms;

namespace ClassLibrary
{
    public class User
    {
        private static string name;
        public User(string name)
        {
            Name = name;
        }
        public static string Name { get  => name;
            set {
                if (!string.IsNullOrWhiteSpace(value))
                {
                    if (CheckValidCharForLetters(value))
                        name = value;
                    else
                        MessageBox.Show("Имя должно состоять только из букв!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                    MessageBox.Show("Вы не ввели имя!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } 
        }
        private static bool CheckValidCharForLetters(string str)
        {
            for (int i = 0; i < str.Length; i++)
            {
                if (!Char.IsLetter(str, i))
                {
                    if (Char.IsWhiteSpace(str, i))
                        continue;
                    else
                        return false;
                }
            }
            return true;
        }
    }
}
