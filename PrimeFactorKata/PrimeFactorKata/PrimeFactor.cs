namespace PrimeFactorKata;

public class PrimeFactor
{
	public List<int> Calculate(int numberToDecompose)
	{
		var factors = new List<int>();
		var divisor = 2;

		while (divisor <= numberToDecompose) {
			while (numberToDecompose % divisor == 0)
			{
				factors.Add(divisor);
				numberToDecompose = (int)Math.Floor((decimal)numberToDecompose / divisor);
			}

			divisor++;
		}

		return factors;
	}
}