﻿using KataSmallestInt;

using NUnit.Framework;


namespace KataSmallestInts.Tests
{
	[TestFixture]
	public class IntArrayTests
	{
		[TestCase(new[] { 78, 56, 232, 12, 11, 43 }, ExpectedResult = 11)]
		[TestCase(new[] { 78, 56, -2, 12, 8, -33 }, ExpectedResult = -33)]
		public int FindSmallestIntTest(int[] args)
		{
			var intArray = new IntArray();
			var result = intArray.FindSmallestInt(args);
			return result;
		}
	}
}
