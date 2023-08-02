using Gomoku.Models;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Gomoku.Models.Cell;

namespace GomokuTests
{
    public class ComputerPlayerTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void ComputerPlayer_When_Null_Board()
        {
            var bd = new BoardBuilder()
                .WithGridSize(10)
                .Build();
            Assert.That(bd.GetGridSize, Is.EqualTo(10));

            var cp = new ComputerPlayer(StoneColor.Black);
            Assert.That(cp.GetName(), Is.Not.Null);
            Assert.That(() => cp.MakeMove(null), Throws.ArgumentNullException);
        }

        [Test]
        public void ComputerPlayer_When_Move_Success()
        {
            var bd = new BoardBuilder()
                .WithGridSize(10)
                .Build();
            Assert.That(bd.GetGridSize, Is.EqualTo(10));

            var cp = new ComputerPlayer(StoneColor.White);
            var move = cp.MakeMove(bd);
            Assert.That(move.x, Is.GreaterThanOrEqualTo(0));
            Assert.That(move.x, Is.LessThan(10));
            Assert.That(move.y, Is.GreaterThanOrEqualTo(0));
            Assert.That(move.y, Is.LessThan(10));
        }

        [Test]
        public void ComputerPlayer_IsBlack()
        {
            var cp = new ComputerPlayer(StoneColor.Black);
            var color = cp.GetColor();
            Assert.That(color, Is.EqualTo(StoneColor.Black));
        }

        [Test]
        public void ComputerPlayer_IsWhite()
        {
            var cp = new ComputerPlayer(StoneColor.White);
            var color = cp.GetColor();
            Assert.That(color, Is.EqualTo(StoneColor.White));
        }
    }
}
