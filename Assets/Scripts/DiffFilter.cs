
public class DiffFilter 
{
    public static int[] numbersDiff(int[] xs)
    {
        int[] result = new int[xs.Length];
        result[0] = xs[0];
        for (int i = 1; i < xs.Length; i++)
        { 
            int res = xs[i] - xs[i - 1];
            if(res < 0)
            {
               res = res * (-1);
            }
            result[i] = res; 
        }
        return result;
    }
}
