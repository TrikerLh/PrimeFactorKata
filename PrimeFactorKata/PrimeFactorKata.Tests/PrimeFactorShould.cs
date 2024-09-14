using System.Security.Cryptography;

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
		public void Cannot_be_decomposed(int primeNumber)
		{
			var result = primeFactor.Calculate(primeNumber);

			Assert.That(result, Is.EquivalentTo(new List<int>{primeNumber}));
		}

		[Test]
		public void Decomposed_4_in_2_for_2()
		{
			var result = primeFactor.Calculate(4);

			Assert.That(result, Is.EquivalentTo(new List<int>{2, 2}));
		}
	}
}