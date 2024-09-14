namespace PrimeFactorKata;

public class PrimeFactor
{
	public List<int> Calculate(int numberToDecompose)
	{
		var factors = new List<int>();
		if (numberToDecompose > 1)
		{
			if (numberToDecompose % 2 == 0 && numberToDecompose > 2)
			{
				factors.Add(2);
				factors.Add((int)Math.Floor((decimal)numberToDecompose / 2));
				return factors;
			}

			factors.Add(numberToDecompose);
		}
		return factors;
	}
}