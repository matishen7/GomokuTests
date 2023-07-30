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

            var cp = new ComputerPlayer();
            Assert.That(cp.GetName(), Is.Not.Null);
            Assert.That(() => cp.Move(null, 0, 0), Throws.ArgumentNullException);
        }

        [Test]
        public void ComputerPlayer_When_Move_Success()
        {
            var bd = new BoardBuilder()
                .WithGridSize(10)
                .Build();
            Assert.That(bd.GetGridSize, Is.EqualTo(10));

            var cp = new ComputerPlayer();
            bd = cp.Move(bd, 0, 0);
            int count = 0;
            for(var i  = 0;i < bd.GetGridSize();i++)
                for (var j = 0; j < bd.Grid[i].Length;j++)
                    if (bd.Grid[i][j].Color == StoneColor.White)
                        count++;

            Assert.That(count, Is.EqualTo(1));
        }

        [Test]
        public void ComputerPlayer_IsBlack_When_Move_Success()
        {
            var bd = new BoardBuilder()
                .WithGridSize(10)
                .Build();
            Assert.That(bd.GetGridSize, Is.EqualTo(10));

            var cp = new ComputerPlayer(isBlack: true);
            bd = cp.Move(bd, 0, 0);
            int count = 0;
            for (var i = 0; i < bd.GetGridSize(); i++)
                for (var j = 0; j < bd.Grid[i].Length; j++)
                    if (bd.Grid[i][j].Color == StoneColor.Black)
                        count++;

            Assert.That(count, Is.EqualTo(1));
        }
    }
}
