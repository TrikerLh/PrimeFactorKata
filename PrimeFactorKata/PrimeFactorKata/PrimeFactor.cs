namespace PrimeFactorKata;

public class PrimeFactor
{
	public List<int> Calculate(int numberToDecompose)
	{
		var factors = new List<int>();
		var divisor = 2;

		while (divisor < numberToDecompose) {
			if (numberToDecompose % divisor == 0)
			{
				factors.Add(divisor);
				numberToDecompose = (int)Math.Floor((decimal)numberToDecompose / divisor);
			}

			divisor++;
		}

		if (numberToDecompose > 1)
		{
			factors.Add(numberToDecompose);
		}
		return factors;
	}
}