namespace ass1
{
    internal class Program
    {

        static void Main()
        {
            int[] arr = { 64, 34, 25, 12, 22, 11, 90 };
            OptimizedBubbleSort(arr);
            Console.WriteLine("Sorted array: " + string.Join(", ", arr));
        }

        static void OptimizedBubbleSort(int[] arr)
        {
            int n = arr.Length;
            bool swapped;

            for (int i = 0; i < n - 1; i++)
            {
                swapped = false;
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                       
                        int temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                        swapped = true;
                    }
                }

                if (!swapped)
                    break;
            }
        
        var intRange = new Range<int>(10, 20);
            Console.WriteLine("Is 15 in range? " + intRange.IsInRange(15)); 
            Console.WriteLine("Length of range: " + intRange.Length()); 

            var doubleRange = new Range<double>(1.5, 3.5);
            Console.WriteLine("Is 2.5 in range? " + doubleRange.IsInRange(2.5)); 
            Console.WriteLine("Length of range: " + doubleRange.Length()); 
        }





    }



}
