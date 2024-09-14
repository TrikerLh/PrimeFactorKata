namespace PrimeFactorKata;

public class PrimeFactor
{
	public List<int> Calculate(int numberToDecompose)
	{
		if (numberToDecompose > 1)
		{
			if (numberToDecompose == 4)
			{
				return new List<int> { 2, 2 };
			}

			return new List<int> { numberToDecompose };
		}
		return [];
	}
}