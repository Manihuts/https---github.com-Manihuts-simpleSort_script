internal class Program
{
    public static void Min(int k, int[] vetor, ref int j)
    {
        if (k < vetor.Length)
        {
            if (vetor[k] < vetor[j])
            {
                j = k;
            }
            Min(k + 1, vetor, ref j);
        }
    }

    public static int[] simpleSort(int i, int[] vetor)
    {
        int j, t;
        if (i < vetor.Length - 1)
        {
            j = i;
            Min(i + 1, vetor, ref j);
            t = vetor[i];
            vetor[i] = vetor[j];
            vetor[j] = t;
            simpleSort(i + 1, vetor);
        }
        return vetor;
    }

    private static void Main(string[] args)
    {
        int[] vetorExemplo = new int[7] {10, 3, 27, 16, 9, 1, 54};
        int[] vetorOrganizado = simpleSort(0, vetorExemplo);

        for (int i = 0; i < vetorOrganizado.Length; i++)
            Console.Write($"{vetorOrganizado[i]} ");

        // Output: 1 3 9 10 16 27 54
    }
}