namespace ClassLibrary
{
    public class SortStudents : Students
    {
        private static void Sort(string[] str, char[] ch, int[] numeral, int i, int j)
        {
            string tempStr;
            char tempCh;
            int tempInt;
            tempStr = str[i];
            str[i] = str[j];
            str[j] = tempStr;
            tempCh = ch[i];
            ch[i] = ch[j];
            ch[j] = tempCh;
            tempInt = numeral[i];
            numeral[i] = numeral[j];
            numeral[j] = tempInt;
        }
        public static void SortAlphabet( int fromIndex, int toIndex)
        {
            for (int i = fromIndex; i < toIndex; i++)
                for (int j = i + 1; j < toIndex; j++)
                    if (Surnames[i].CompareTo(Surnames[j]) > 0)
                        Sort(Surnames, Marks, Id, i, j);
        }
        public static void SortId()
        {
            for (int i = 0; i < Surnames.Length; i++)
                for (int j = i + 1; j < Surnames.Length; j++)
                    if (Id[i] > Id[j])
                        Sort(Surnames, Marks, Id, i, j);
        }
        public static void SortMarks()
        {
            for (int i = 0; i < Surnames.Length; i++)
                for (int j = i + 1; j < Surnames.Length; j++)
                    if (Marks[i] < Marks[j])
                        Sort(Surnames, Marks, Id, i, j);
        }
        public static void SortMarksAlphavet()
        {
            int sumMark5 = ManipulationsWithMarks.SumMark5(Marks);
            int sumMark4 = ManipulationsWithMarks.SumMark4(Marks);
            int sumMark3 = ManipulationsWithMarks.SumMark3(Marks);
            SortMarks();
            SortAlphabet(fromIndex: 0, toIndex: sumMark5);
            SortAlphabet(fromIndex: sumMark5, toIndex: sumMark4 + sumMark5);
            SortAlphabet(fromIndex: sumMark5 + sumMark4, toIndex: sumMark3 + sumMark4 + sumMark5);
            SortAlphabet(fromIndex: sumMark5 + sumMark4 + sumMark3, toIndex: Surnames.Length);
        }
    }
}
