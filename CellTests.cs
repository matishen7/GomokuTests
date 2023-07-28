using Gomoku.Models;
using static Gomoku.Models.Cell;

namespace GomokuTests
{
    public class CellTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void NewCell_StoneColor_Empty()
        {
            var cell = new Cell();
            Assert.That(cell, Is.Not.Null);
            Assert.That(cell.Color, Is.EqualTo(StoneColor.Empty));
        }
    }
}