namespace PrimeFactorKata.Tests {
	public class PrimeFactorShould {
		[SetUp]
		public void Setup() {
		}

		[Test]
		public void Not_have_prime_factors()
		{
			var primeFactor = new PrimeFactor();

			var result = primeFactor.Calculate(1);
			
			Assert.That(result, Is.EquivalentTo(new List<int>()));
		}
	}
}