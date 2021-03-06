﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using NUnit.Framework;


namespace KataGameOfLife.Tests
{
	[TestFixture]
    public class CellTests
    {
		//http://en.wikipedia.org/wiki/Conway's_Game_of_Life#Rules

		[Test]
		public void Cell_NewDeadCell_ReturnsDeadCell()
		{
			var cell = Cell.NewDeadCell();
			Assert.IsFalse(cell.IsAlive);
		}

		[Test]
		public void Cell_NewLivingCell_ReturnsDeadCell()
		{
			var cell = Cell.NewLivingCell();
			Assert.IsTrue(cell.IsAlive);
		}

		[TestCase(0, ExpectedResult = false)]
		[TestCase(1, ExpectedResult = false)]
		[TestCase(4, ExpectedResult = false)]
		[TestCase(5, ExpectedResult = false)]
		[TestCase(2, ExpectedResult = true)]
		[TestCase(3, ExpectedResult = true)]
		public bool LivingCell_LivingNeighborsTests(int livingNeighBors)
		{
			var cell = Cell.NewLivingCell();
			cell.LivingNeighbors(livingNeighBors);
			return cell.IsAlive;
		}

		[Test]
		public void DeadCell_LivingNeighborsTests()
		{
			var cell = Cell.NewDeadCell();
			cell.LivingNeighbors(3);
			Assert.IsTrue(cell.IsAlive);
		}

		[TestCase('.', ExpectedResult = false)]
		[TestCase('O', ExpectedResult = true)]
		public bool Cell_FromChar_Tests(char aChar)
		{
			var cell = Cell.FromChar(aChar);
			return cell.IsAlive;
		}
	}
}
