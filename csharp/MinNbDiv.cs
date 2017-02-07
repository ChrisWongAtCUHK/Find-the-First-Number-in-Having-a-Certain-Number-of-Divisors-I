public class MinNbDiv
{

    public static int FindMinNum(int num)
    {
        int minNum = 1;
        while (true)
        {
            if (GetNumberOfDivision(minNum) == num)
            {
                return minNum;
            }
            minNum++;
        }
    }

    /// <summary>
    /// Get number of division
    /// </summary>
    /// <param name="n"></param>
    /// <returns></returns>
    public static int GetNumberOfDivision(int n)
    {
        // special case
        if(n == 1) return 1;

        // default: 1 & self
        int numberOfDivision = 2;

        // loop 2..half of n
        for (int i = 2; i * 2 <= n; i++)
        {
            // if mod factor == 0, number division increase by 1
            if (n % i == 0)
            {
                numberOfDivision++;
            }
        }

        return numberOfDivision;
    }
}

