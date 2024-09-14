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

		[Test]
		public void Return_the_same_number_if_is_prime_number()
		{
			var result = primeFactor.Calculate(2);

			Assert.That(result, Is.EquivalentTo(new List<int>{2}));
		}
	}
}