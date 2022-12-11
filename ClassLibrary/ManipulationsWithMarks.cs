namespace ClassLibrary
{
    public class ManipulationsWithMarks : Students
    {
        private static double arithmeticMeanMarks;
        private static double academicPerformance;
        private static double qualityOfKnowledge;
        public static double ArithmeticMeanMarks { get => arithmeticMeanMarks; private set => arithmeticMeanMarks = value; }
        public static double AcademicPerformance { get => academicPerformance; private set => academicPerformance = value; }
        public static double QualityOfKnowledge { get => qualityOfKnowledge; private set => qualityOfKnowledge = value; }
        public static int SumMark3(char[] ch)
        {
            int sumMark3 = 0;
            for (int i = 0; i < ch.Length; i++)
                if (ch[i] == '3')
                    sumMark3++;
            return sumMark3;
        }
        public static int SumMark4(char[] ch)
        {
            int sumMark4 = 0;
            for (int i = 0; i < ch.Length; i++)
                if (ch[i] == '4')
                    sumMark4++;
            return sumMark4;
        }
        public static int SumMark5(char[] ch)
        {
            int sumMark5 = 0;
            for (int i = 0; i < ch.Length; i++)
                if (ch[i] == '5')
                    sumMark5++;
            return sumMark5;
        }
        public static double CalculationArithmeticMeanOfCharArray(char[] array)
        {
            double SumArray = 0;
            double[] arrayDouble = new double[array.Length];
            for (int i = 0; i < array.Length; i++)
            {
                arrayDouble[i] = double.Parse(array[i].ToString());
                SumArray += arrayDouble[i];
            }
            double ArithmeticMean = SumArray / array.Length;
            return ArithmeticMean;
        }
        public static double CalculationAcademicPerformance()
        {
            double percent = 100 / Count;
            double academicPerformance = percent * (SumMark3(Marks) + SumMark4(Marks) + SumMark5(Marks));
            return academicPerformance;
        }
        public static double CalculationQualityOfKnowledge()
        {
            double percent = 100 / Count;
            double qualityOfKnowledge = percent * (SumMark4(Marks) + SumMark5(Marks));
            return qualityOfKnowledge;
        }
    }
}
