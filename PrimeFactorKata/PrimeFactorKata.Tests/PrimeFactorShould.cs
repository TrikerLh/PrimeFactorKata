using System.Runtime.InteropServices;
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
			var result = Decompose(1);
			
			Assert.That(result, Is.EquivalentTo(new List<int>()));
		}

		[TestCase(2)]
		[TestCase(3)]
		[TestCase(5)]
		public void Cannot_be_decomposed(int primeNumber)
		{
			var result = Decompose(primeNumber);

			Assert.That(result, Is.EquivalentTo(new List<int>{primeNumber}));
		}

		[Test]
		public void Decomposed_4_in_2_for_2()
		{
			var result = Decompose(4);

			Assert.That(result, Is.EquivalentTo(new List<int>{2, 2}));
		}

		[Test]
		public void Decompose_6_in_2_for_3()
		{
			var result = Decompose(6);

			Assert.That(result, Is.EquivalentTo(new List<int>{2, 3}));
		}

		[Test]
		public void Decompose_8_in_2_for_2_for_2()
		{
			var result = Decompose(8);

			Assert.That(result, Is.EquivalentTo(new List<int>{2, 2, 2}));
		}

		[Test]
		public void Decompose_9_in_3_for_3()
		{
			var result = Decompose(9);

			Assert.That(result, Is.EquivalentTo(new List<int>{3 , 3}));
		}

		private List<int> Decompose(int number)
		{
			return primeFactor.Calculate(number);
		}
	}
}