namespace Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[100];

            ArrayCheck(array);
        }

        static void ArrayCheck(int[] array)
        {
            Random randomNumber = new Random();

            int[] array2 = new int[array.Length];

            bool findRepeated = true;

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = randomNumber.Next(1, 1000);

                for (int j = 0; j < array2.Length; j++) 
                {
                    if (array2[j] == array[i])
                    {
                        findRepeated = false;
                    }
                }

                if (findRepeated == true) 
                {
                    array2[i] = array[i];
                    Console.WriteLine(array2[i]);
                }
            }
        }
    }
}