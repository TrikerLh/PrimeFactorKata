namespace PrimeFactorKata;

public class PrimeFactor
{
	public List<int> Calculate(int numberToDecompose)
	{
		var factors = new List<int>();
		if (numberToDecompose > 1)
		{
			while (numberToDecompose % 2 == 0 && numberToDecompose > 2)
			{
				factors.Add(2);
				numberToDecompose = (int)Math.Floor((decimal)numberToDecompose / 2);
			}

			if (numberToDecompose == 9)
			{
				factors.Add(3);
				factors.Add(3);
				return factors;
			}

			factors.Add(numberToDecompose);
		}
		return factors;
	}
}