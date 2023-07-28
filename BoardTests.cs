using Gomoku.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Gomoku.Models.Cell;

namespace GomokuTests
{
    public class BoardTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Board_SetGridSize()
        {
            var board = new Board();
            board.SetGridSize(10);
            Assert.That(board.GetGridSize, Is.EqualTo(10));
        }
    }
}
