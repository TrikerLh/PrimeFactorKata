namespace PrimeFactorKata.Tests {
	public class PrimeFactorShould
	{
		private PrimeFactor primeFactor;

		[SetUp]
		public void Setup() {
			primeFactor = new PrimeFactor();
		}

		[Test]
		public void Not_have_prime_factors()
		{
			var result = primeFactor.Calculate(1);
			
			Assert.That(result, Is.EquivalentTo(new List<int>()));
		}

		[TestCase(2)]
		[TestCase(3)]
		[TestCase(5)]
		public void Return_the_same_number_if_is_prime_number(int primeNumber)
		{
			var result = primeFactor.Calculate(primeNumber);

			Assert.That(result, Is.EquivalentTo(new List<int>{primeNumber}));
		}
	}
}