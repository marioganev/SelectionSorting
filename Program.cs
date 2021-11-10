{
            int n, swap, i, j, max;
            Console.Write("Въведи брой елементи: ");
            n = int.Parse(Console.ReadLine());

            int[] Arr = new int[n];
            for (i = 0; i < Arr.Length; i++)
            {
                Console.Write("Array [ " + i + "] = ");
                Arr[i] = int.Parse(Console.ReadLine());
            }
            for (i = Arr.Length - 1; i > 0; i--)
            {
                max = 0;
                for (j = 0; j < i + 1; j++)

                    if (Arr[j] > Arr[max])
                        max = j;
                swap = Arr[i];
                Arr[i] = Arr[max];
                Arr[max] = swap;
            }
            for (i = 0; i < Arr.Length; i++)
                Console.Write("Arr [ " + i + "] = " + Arr[i] + "");
            Console.ReadLine();
        }
    }
}
