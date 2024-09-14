namespace PrimeFactorKata;

public class PrimeFactor
{
	public List<int> Calculate(int numberToDecompose)
	{
		if (numberToDecompose == 1)
			return [];

		return new List<int>{numberToDecompose};
	}
}