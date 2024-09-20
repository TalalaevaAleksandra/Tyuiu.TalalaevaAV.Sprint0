namespace Tyuiu.TalalaevaAV.Sprint0.V0.Task7.Lib
{
    public class DataService
    {
        public static int[] AdditionArrays(int[] numOne, int[] numTwo)
        {
            int[] resulArray = new int[5];
            for (var i = 0; i < resulArray.Length; i++)
            {

                resulArray[i] = numOne[i] + numTwo[i];
            }

            return resulArray;
        }

    }
}
