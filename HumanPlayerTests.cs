using Gomoku.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Gomoku.Models.Cell;

namespace GomokuTests
{
    public class HumanPlayerTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void HumanPlayer_When_Null_Board()
        {
            var bd = new BoardBuilder()
                .WithGridSize(10)
                .Build();
            Assert.That(bd.GetGridSize, Is.EqualTo(10));

            var hp = new HumanPlayer("John");
            Assert.That(hp.GetName(), Is.Not.Null);
            Assert.That(() => hp.Move(null, 0, 0), Throws.ArgumentNullException);
        }

        [Test]
        public void HumanPlayer_IsWhite_When_Move_Success()
        {
            var bd = new BoardBuilder()
                .WithGridSize(10)
                .Build();
            Assert.That(bd.GetGridSize, Is.EqualTo(10));

            var cp = new HumanPlayer("John", false);
            bd = cp.Move(bd, 0, 0);

            Assert.That(bd.Grid[0][0].Color, Is.EqualTo(StoneColor.White));
        }

        [Test]
        public void HumanPlayer_IsBlack_When_Move_Success()
        {
            var bd = new BoardBuilder()
                .WithGridSize(10)
                .Build();
            Assert.That(bd.GetGridSize, Is.EqualTo(10));

            var cp = new HumanPlayer("John");
            bd = cp.Move(bd, 0, 0);

            Assert.That(bd.Grid[0][0].Color, Is.EqualTo(StoneColor.Black));
        }

        [Test]
        public void HumanPlayer_When_Coordinates_Greater_Throws_ArgumentOutOfRangeException()
        {
            var bd = new BoardBuilder()
                .WithGridSize(10)
                .Build();
            Assert.That(bd.GetGridSize, Is.EqualTo(10));

            var cp = new HumanPlayer("John");

            Assert.Throws<ArgumentOutOfRangeException>(() =>
            {
                cp.Move(bd, 11, 11);
            });
        }

        [Test]
        public void HumanPlayer_When_Coordinates_Less_Throws_ArgumentOutOfRangeException()
        {
            var bd = new BoardBuilder()
                .WithGridSize(10)
                .Build();
            Assert.That(bd.GetGridSize, Is.EqualTo(10));

            var cp = new HumanPlayer("John");

            Assert.Throws<ArgumentOutOfRangeException>(() =>
            {
                cp.Move(bd, -1, -1);
            });
        }
    }
}
